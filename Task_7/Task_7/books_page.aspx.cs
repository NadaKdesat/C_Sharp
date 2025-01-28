using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_7
{
    public partial class books_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowBooks();
        }

        private void ShowBooks()
        {
            string file = Server.MapPath("books.txt");
            string[] Books = File.ReadAllLines(file);
            foreach (string Book in Books)
            {
                string[] bookData = Book.Split(' ');
                booksData.InnerHtml += $"<tr><td>{bookData[0]}</td> <td>{bookData[1]}</td> <td>{bookData[2]}</td> <td>{bookData[3]}</td></tr>";
            }
        }
    }
}