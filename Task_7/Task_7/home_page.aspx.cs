using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class home_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_in_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Log_in_page.aspx");
        }

        protected void Sign_up_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sign_up_page.aspx");
        }
    }
}