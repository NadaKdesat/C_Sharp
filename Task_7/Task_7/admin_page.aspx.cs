using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class admin_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_books_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_books_page.aspx");
        }

        protected void edit_books_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit_books_page.aspx");
        }

        protected void schedual_meetings_Click(object sender, EventArgs e)
        {
            Response.Redirect("add_meetings_page.aspx");
        }
    }
}