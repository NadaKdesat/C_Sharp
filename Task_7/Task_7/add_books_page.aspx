<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_books_page.aspx.cs" Inherits="Task_7.add_books_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Books</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="ms-2">
            <h4 style="margin-bottom: 20px">Add A Book</h4>
            <label>ID</label>
            <asp:TextBox ID="bookId" runat="server" Width="99%" />
            <br /><br />
            <label>Name</label>
            <asp:TextBox ID="bookName" runat="server" Width="99%" />
            <br /><br />
            <label>Kind</label>
            <asp:TextBox ID="bookKind" runat="server" Width="99%" />
            <br /><br />
            <label>Level</label>
            <asp:TextBox ID="bookLevel" runat="server" Width="99%" />
            <br /><br />
            <asp:Button runat="server" ID="addBook" Text="Add Book" class="btn btn-primary btn-lg" OnClick="addBook_Click" />
            <asp:Label runat="server" ID="massege" Visible="false" style="color:red; font-size:12px"></asp:Label>
            <asp:Label runat="server" ID="success_massege" Visible="false" style="color:green; font-size:12px"></asp:Label>
        </div>
    </form>
</body>
</html>
