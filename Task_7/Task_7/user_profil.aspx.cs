using System;
using System.IO;
using System.Web.UI;

namespace Task_7
{
    public partial class user_profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadUserData()
        {
            string file = Server.MapPath("user.txt");
            if (File.Exists(file))
            {
                string user = File.ReadAllText(file);
                string[] userData = user.Split(' ');

                string file2 = Server.MapPath("users.txt");
                string[] users = File.ReadAllLines(file2);
                foreach (string u in users)
                {
                    string[] userData2 = u.Split(' ');
                    if (userData2[1] == userData[1] && userData2.Length > 3)
                    {
                        name.Text = userData2[0];
                        email.Text = userData2[1];
                        phone.Text = userData2[3];
                        age.Text = userData2[4];
                        address.Text = userData2[5];

                        userName.Text = userData2[0];
                        userPhone.Text = userData2[3];
                        userAge.Text = userData2[4];
                        userAddress.Text = userData2[5];
                        break;
                    }
                    else
                    {
                        name.Text = userData[0];
                        userName.Text = userData[0];
                        email.Text = userData[1];
                    }
                }
            }
        }

        protected void saveChanges_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("users.txt");
            string[] users = File.ReadAllLines(file);
            if (!string.IsNullOrEmpty(userName.Text) && !string.IsNullOrEmpty(userPhone.Text) && !string.IsNullOrEmpty(userAge.Text) && !string.IsNullOrEmpty(userAddress.Text))
            {
                for (int i = 0; i < users.Length; i++)
                {
                    string[] userData = users[i].Split(' ');
                    if (email.Text == userData[1])
                    {
                        users[i] = $"{userName.Text} {userData[1]} {userData[2]} {userPhone.Text} {userAge.Text} {userAddress.Text}";
                        name.Text = userData[0];
                        email.Text = userData[1];
                        phone.Text = userPhone.Text;
                        age.Text = userAge.Text;
                        address.Text = userAddress.Text;
                        break; 
                    }
                }
                File.WriteAllLines(file, users);
                LoadUserData();
            }
        }
    }
}