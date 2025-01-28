using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class add_books_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBook_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("books.txt");
            if (!File.Exists(file))
            {
                File.CreateText(file);
            }
            if(string.IsNullOrEmpty(bookId.Text) || string.IsNullOrEmpty(bookName.Text) ||
                string.IsNullOrEmpty(bookKind.Text) || string.IsNullOrEmpty(bookLevel.Text))
            {
                massege.Text = "Please Fill All Feilds!";
                massege.Visible = true;
                return;
            }
            using(StreamWriter sw=new StreamWriter(file, true))
            {
                sw.WriteLine($"{bookId.Text} {bookName.Text} {bookKind.Text} {bookLevel.Text}");
            }
            success_massege.Text = "Book Was Added Successfully!";
            success_massege.Visible = true;
        }
    }
}