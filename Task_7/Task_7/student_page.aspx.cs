using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class student_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void books_Click(object sender, EventArgs e)
        {
            Response.Redirect("books_page.aspx");
        }

        protected void meetings_Click(object sender, EventArgs e)
        {
            Response.Redirect("meetings_page.aspx");
        }
    }
}