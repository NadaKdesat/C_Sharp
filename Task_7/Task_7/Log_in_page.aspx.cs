using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Task_7
{
    public partial class Log_in_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Button_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("users.txt");
            string[] adminEmails = { "admin1@gmail.com", "admin2@gmail.com", "admin3@gmail.com" };

            string[] users = File.ReadAllLines(file);
            if (adminEmails.Contains(email.Text) && password.Text == "1234")
            {
                Response.Redirect("admin_page.aspx");
                return;
            }
            foreach (string user in users)
            {
                string[] userData = user.Split(' ');
                if (email.Text == userData[1] && password.Text == userData[2])
                {
                    
                    string file2 = Server.MapPath("user.txt");
                    if (!File.Exists(file2))
                    {
                        File.Create(file2);
                    }
                    using (StreamWriter sw = new StreamWriter(file2, false))
                    {
                        sw.WriteLine($"{userData[0]} {userData[1]} {userData[2]}");
                    }
                    Response.Redirect("user_profil.aspx");
                }
            }
            result.Text = "Invalid username or password";
            result.Visible = true;


            

        }
    }
}