<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_page.aspx.cs" Inherits="Task_7.student_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student page</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3 style="text-align: center;">Powers of student</h3>
            <br />
            <div class="row gap-3 ms-3">
                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title">See All Books</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <asp:Button runat="server" class="btn btn-primary" Text="See All Books" ID="books" OnClick="books_Click"/>
                    </div>
                </div>

                <div class="card" style="width: 18rem;">
                    <div class="card-body">
                        <h5 class="card-title">See All Meetings</h5>
                        <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <asp:Button runat="server" class="btn btn-primary" Text="See All Meetings" ID="meetings" OnClick="meetings_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
