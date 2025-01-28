<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_page.aspx.cs" Inherits="Task_7.admin_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3 style="text-align: center;">Powers of library owner</h3>
            <br />
            <div class="row gap-3 ms-3">
                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title">Add Books</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <asp:Button runat="server" class="btn btn-primary" Text="Add Books" ID="add_books" OnClick="add_books_Click" />
                    </div>
                </div>

                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title">Edit Books</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <asp:Button runat="server" class="btn btn-primary" Text="Edit Books" ID="edit_books" OnClick="edit_books_Click" />
                    </div>
                </div>
                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title">Schedual Meetings</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <asp:Button runat="server" class="btn btn-primary" Text="Schedual Meetings" ID="schedual_meetings" OnClick="schedual_meetings_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
