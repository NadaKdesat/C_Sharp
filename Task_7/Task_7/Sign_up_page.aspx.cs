using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class Sign_up_page : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }    

        protected void register_button_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("users.txt");
            bool isValid=true;
            if (!File.Exists(file))
            {
                File.Create(file);
            }

            if (!Regex.IsMatch(name.Text, "^[A-Za-z][A-Za-z0-9_-]{2,20}$"))
            {
                invalid_username.Text = "Invalid username";
                invalid_username.Visible = true;
                isValid = false;
            }
            else
            {
                invalid_username.Visible = false;
            }
            if (!Regex.IsMatch(email.Text, "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$"))
            {
                invalid_email.Text = "Invalid email";
                invalid_email.Visible = true;
                isValid = false;
            }
            else
            {
                invalid_email.Visible = false;
            }
            if (!Regex.IsMatch(password.Text, "^[A-Za-z0-9]{4,12}$"))
            {
                invalid_password.Text = "Password must be between 4 and 12 characters and contain only letters and numbers.";
                invalid_password.Visible = true;
            }
            else
            {
                invalid_password.Visible = false;
            }
            if (password.Text != repeat_password.Text)
            {
                invalid_repeat_password.Text = "Passwords do not match.";
                invalid_repeat_password.Visible = true;
                isValid = false;
            }
            else
            {
                invalid_repeat_password.Visible = false;
            }

            if (!termsCheckbox.Checked)
            {
                checkbox_message.Text = "You must agree to the terms of service.";
                checkbox_message.Visible = true;
                isValid = false;
            }
            else
            {
                checkbox_message.Visible = false;
            }

            string[] users = File.ReadAllLines(file);
            bool isExists = true;

            if (users.Length != 0)
            {
                foreach (string user in users)
                {
                    string[] userData = user.Split(' ');
                    if (name.Text == userData[0] && !string.IsNullOrEmpty(name.Text))
                    {
                        user_exists.Text = "This username is already taken.";
                        user_exists.Visible = true;
                        return;
                    }
                    else if (email.Text == userData[1] && !string.IsNullOrEmpty(email.Text))
                    {
                        user_exists.Text = "This email is already registered.";
                        user_exists.Visible = true;
                        return;
                    }
                    else
                    {
                        user_exists.Visible = false;
                        isExists = false;
                    }
                }
            }
            else
            {
                isExists = false;
            }
            if (!isExists && isValid) { 
                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine($"{name.Text} {email.Text} {password.Text}");
                }
                Response.Redirect("Log_in_page.aspx");
            }
        }
    }
}