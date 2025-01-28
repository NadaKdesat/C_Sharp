using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class meetings_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowMeetings();
        }

        private void ShowMeetings()
        {
            string file = Server.MapPath("meetings.txt");
            string[] Meetings = File.ReadAllLines(file);
            foreach (string Meeting in Meetings)
            {
                string[] meetingData = Meeting.Split(' ');
                meetingsData.InnerHtml += $"<tr><td>{meetingData[0]}</td> <td>{meetingData[1]}</td> <td>{meetingData[2]}</td> <td>{meetingData[3]}</td></tr>";
            }
        }
    }
}