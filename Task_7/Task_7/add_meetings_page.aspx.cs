using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class add_meetings_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addMeeting_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("meetings.txt");
            if (!File.Exists(file)) { 
                File.Create(file);
            }
            if(string.IsNullOrEmpty(roomId.Text) || string.IsNullOrEmpty(roomName.Text) ||
                string.IsNullOrEmpty(roomLocation.Text) || string.IsNullOrEmpty(roomCapacity.Text))
            {
                massege.Text = "Please Fill All Feilds!";
                massege.Visible = true;
                return;
            }
            using (StreamWriter sw = new StreamWriter(file)) 
            { 
                sw.WriteLine($"{roomId.Text} {roomName.Text} {roomLocation.Text} {roomCapacity.Text}"); 
            }
            success_massege.Text = "Book Was Added Successfully!";
            success_massege.Visible = true;
        }
    }
}