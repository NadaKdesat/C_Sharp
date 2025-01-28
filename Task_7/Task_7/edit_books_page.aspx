<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit_books_page.aspx.cs" Inherits="Task_7.edit_books_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Books</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>

<body>
    <form id="form1" runat="server">
        <div class="ms-3">
            <h4>Edit A Book Information</h4>


            <div class="card-body" id="details">

                <div class="row align-items-center pt-4 pb-3">
                    <div class="col-md-12 ">

                        <h6 class="mb-2">Search For A Book By ID To Edit:</h6>

                    </div>
                    <br />
                    <div class="col-md-4 pe-3">
                        <asp:TextBox runat="server" ID="bookIdSearch" class="input form-control form-control-lg"></asp:TextBox>

                    </div>
                    <div class="col-md-4 pe-5">
                        <asp:Button runat="server" ID="search" Text="Search" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" OnClick="search_Click" />
                    </div>
                </div>


                <hr class="mx-n3">

                <asp:Label runat="server" ID="msg" Visible="false" Style="color: red;"></asp:Label>
                <!-------------------------------->
                <div class="row align-items-center py-3">
                    <div class="col-md-3 ps-5">

                        <asp:Label Visible="false" runat="server" ID="id" class="mb-0">Book ID</asp:Label>

                    </div>
                    <div class="col-md-9 pe-5">
                        <asp:TextBox Visible="false" runat="server" ID="bookId" class="input form-control form-control-lg"></asp:TextBox>
                    </div>
                </div>

                <div class="row align-items-center py-3">
                    <div class="col-md-3 ps-5">

                        <asp:Label Visible="false" runat="server" ID="name" class="mb-0">Book Name</asp:Label>

                    </div>
                    <div class="col-md-9 pe-5">
                        <asp:TextBox Visible="false" runat="server" ID="bookName" class="input form-control form-control-lg"></asp:TextBox>
                    </div>
                </div>


                <div class="row align-items-center py-3">
                    <div class="col-md-3 ps-5">

                        <asp:Label Visible="false" runat="server" ID="type" class="mb-0">Book Type</asp:Label>
                    </div>
                    <div class="col-md-9 pe-5">
                        <asp:TextBox Visible="false" runat="server" ID="bookType" class="input form-control form-control-lg"></asp:TextBox>
                    </div>
                </div>


                <div class="row align-items-center py-3">
                    <div class="col-md-3 ps-5">

                        <asp:Label Visible="false" runat="server" ID="level" class="mb-0">Book Level</asp:Label>
                    </div>
                    <div class="col-md-9 pe-5">
                        <asp:TextBox Visible="false" runat="server" ID="bookLevel" class="input form-control form-control-lg"></asp:TextBox>
                    </div>
                </div>


                <div class="px-5 py-4">
                    <asp:Button Visible="false" runat="server" ID="save" Text="Save Changes" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" OnClick="save_Click" />
                </div>
                <asp:Label runat="server" ID="successMsg" Visible="false" Style="color: green;"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
