<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign_up_page.aspx.cs" Inherits="Task_7.Sign_up_page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign up</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet" />
    <style>
        .invalid_message {
            color: red;
            font-size: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="vh-100" style="background-color: #eee;">
                <div class="container h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-lg-12 col-xl-11">
                            <div class="card text-black" style="border-radius: 25px;">
                                <div class="card-body p-md-5">
                                    <div class="row justify-content-center">
                                        <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                                            <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Sign up</p>

                                            <div class="mx-1 mx-md-4">

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                                                        <label class="form-label" for="form3Example3c">Your Name</label>
                                                        <asp:TextBox class="form-control" ID="name" runat="server" />
                                                        <asp:Label CssClass="invalid_message" ID="invalid_username" Text="text" runat="server" Visible="false" />
                                                    </div>
                                                </div>

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                                                        <label class="form-label" for="form3Example3c">Your Email</label>
                                                        <asp:TextBox class="form-control" ID="email" TextMode="Email" runat="server" />
                                                        <asp:Label CssClass="invalid_message" ID="invalid_email" Text="text" runat="server" Visible="false" />
                                                    </div>
                                                </div>

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                                                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                                                        <label class="form-label" for="form3Example4c">Password</label>
                                                        <asp:TextBox class="form-control" TextMode="Password" ID="password" runat="server" />
                                                        <asp:Label CssClass="invalid_message" ID="invalid_password" Text="text" runat="server" Visible="false" />
                                                    </div>
                                                </div>

                                                <div class="d-flex flex-row align-items-center mb-4">
                                                    <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                                                    <div data-mdb-input-init class="form-outline flex-fill mb-0">
                                                        <label class="form-label" for="form3Example4cd">Repeat your password</label>
                                                        <asp:TextBox class="form-control" TextMode="Password" ID="repeat_password" runat="server" />
                                                        <asp:Label CssClass="invalid_message" ID="invalid_repeat_password" Text="text" runat="server" Visible="false" />
                                                    </div>
                                                </div>

                                                <div class="form-check justify-content-center mb-5">
                                                    <asp:CheckBox ID="termsCheckbox" class="form-check-input me-2" TextMode="checkbox" runat="server" Text="" />
                                                    <label class="form-check-label" for="form2Example3">
                                                        I agree all statements in <a href="#!">Terms of service</a>
                                                    </label>
                                                    <asp:Label CssClass="invalid_message" ID="checkbox_message" Text="text" runat="server" Visible="false" />
                                                </div>

                                                <div class="justify-content-center mx-4 mb-3 mb-lg-4">
                                                    <asp:Button data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" ID="register_button" Text="Register" runat="server" OnClick="register_button_Click" />
                                                    <br />
                                                    <asp:Label CssClass="invalid_message" ID="user_exists" Text="text" runat="server" Visible="false" />
                                                    <p class="small fw-bold mt-2 pt-1 mb-0">
                                                        already have an account? <a href=".\Log_in_page.aspx"
                                                            class="link-danger">Log in</a>
                                                    </p>
                                                </div>

                                            </div>

                                        </div>
                                        <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                                            <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-registration/draw1.webp"
                                                class="img-fluid" alt="Sample image">
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
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
