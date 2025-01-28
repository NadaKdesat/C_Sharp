<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="books_page.aspx.cs" Inherits="Task_7.books_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Books page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="ms-2">
            <h4 style="text-align:center; margin-bottom: 20px;">All Book</h4>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Book ID</th>
                        <th scope="col">Book Name</th>
                        <th scope="col">Book Kind</th>
                        <th scope="col">Book Level</th>
                    </tr>
                </thead>
                <tbody runat="server" id="booksData">
                    
                </tbody>
            </table>
        </div>
    </form>
</body>
</html>
