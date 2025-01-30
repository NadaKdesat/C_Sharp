<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="user_profil.aspx.cs" Inherits="Task_7.user_profil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Profile paage</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section style="background-color: #eee;">
                <div class="container py-5">
                    <div class="row">
                        <div class="col">
                            <nav aria-label="breadcrumb" class="bg-body-tertiary rounded-3 p-3 mb-4">
                                <ol class="breadcrumb mb-0">
                                    <li class="breadcrumb-item"><a href="./home_page.aspx">Home</a></li>
                                    <li class="breadcrumb-item active" aria-current="page">User Profile</li>
                                </ol>
                            </nav>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-4">
                            <div class="card mb-4">
                                <div class="card-body text-center">
                                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava3.webp" alt="avatar"
                                        class="rounded-circle img-fluid" style="width: 150px;">
                                    <div class="d-flex justify-content-center mb-2">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-8">
                            <div class="card mb-4">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <p class="mb-0">Name</p>
                                        </div>
                                        <div class="col-sm-9">
                                            <asp:Label ID="name" runat="server" />
                                        </div>
                                    </div>
                                    <hr>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <p class="mb-0">Email</p>
                                        </div>
                                        <div class="col-sm-9">
                                            <asp:Label ID="email" runat="server" />
                                        </div>
                                    </div>
                                    <hr>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <p class="mb-0">Phone</p>
                                        </div>
                                        <div class="col-sm-9">
                                            <asp:Label ID="phone" runat="server" />
                                        </div>
                                    </div>
                                    <hr>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <p class="mb-0">Age</p>
                                        </div>
                                        <div class="col-sm-9">
                                            <asp:Label ID="age" runat="server" />
                                        </div>
                                    </div>
                                    <hr>
                                    <div class="row">
                                        <div class="col-sm-3">
                                            <p class="mb-0">Address</p>
                                        </div>
                                        <div class="col-sm-9">
                                            <asp:Label ID="address" runat="server" />
                                        </div>
                                    </div>
                                    <hr>
                                    <asp:Button ID="edit_button" runat="server" Text="Edit" CssClass="btn btn-outline-primary ms-1" OnClientClick="$('#myModal').modal('show'); return false;" />
                                    <div class="modal" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                                        <div class="modal-dialog" role="document">
                                            <div class="modal-content">
                                                <div class="modal-header">
                                                    <h5 class="modal-title" id="myModalLabel">Edit User Information</h5>
                                                </div>
                                                <div class="modal-body">
                                                    <!-- Form to Edit User Data -->
                                                    <div class="form-group mb-2">
                                                        <label for="userName" class="col-sm-3">Username</label>
                                                        <asp:TextBox ID="userName" class="col-sm-6" runat="server" ></asp:TextBox>
                                                    </div>
                                                    <div class="form-group mb-2">
                                                        <label for="userPhone" class="col-sm-3">Phone Number</label>
                                                        <asp:TextBox ID="userPhone" class="col-sm-6" runat="server" ></asp:TextBox>
                                                    </div>
                                                    <div class="form-group mb-2">
                                                        <label for="userAge" class="col-sm-3">Age</label>
                                                        <asp:TextBox ID="userAge" class="col-sm-6" runat="server" ></asp:TextBox>
                                                    </div>
                                                    <div class="form-group mb-2">
                                                        <label for="userAddress" class="col-sm-3">Address</label>
                                                        <asp:TextBox ID="userAddress" class="col-sm-6" runat="server" ></asp:TextBox>
                                                    </div>
                                                </div>
                                                <div class="modal-footer">
                                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                                    <asp:Button ID="saveChanges" runat="server" Text="Save Changes" CssClass="btn btn-primary" OnClick="saveChanges_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </section>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.5.2/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</body>
</html>
