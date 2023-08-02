<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Faculty_Register.aspx.cs" Inherits="Project_2.Faculty_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }
        header {
            height: 5vh;
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 20px;
            background-color: #27449a;
            color: #fff;
        }
        main {
            height: 80vh;
            display: flex;
            justify-content: center;
            align-items: center;
            background-color: #f2f2f2;
            background-image: url('university.jpeg');
            background-repeat: no-repeat;
            background-size: cover;
            background-position: center;
        }
        footer {
            height: 5vh;
            background-color: #333;
            color: #fff;
            text-align: center;
            padding: 20px;
        }

        .container {
            width: 500px;
            height: 550px;
            margin: 0 auto;
            border: 3px solid white;
            border-radius: 10px;
            padding: 10px;
            margin-bottom: 10px;
            text-align: center;
            background-image: url('university.jpeg');
            background-repeat: no-repeat;
            background-size: cover;
            background-position: center;
            box-shadow: #7eec32 0 0 10px;
        }

        h1 {
            text-align: center;
            margin-bottom: 20px;
            color:blue;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
            color:black;
        }

        .form-group input[type="text"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px;
            border-radius: 3px;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        .btn-login {
            width: 100%;
            padding: 10px;
            background-color: #333;
            color: #fff;
            border: none;
            border-radius: 3px;
            cursor: pointer;
        }

        .btn-login:hover {
            background-color: #555;
        }

        .additional-links {
            text-align: right;
        }
        .university-logo {
            display: flex;
            align-items: center;
        }

            .university-logo img {
                height: 40px;
                margin-right: 10px;
            }

        .additional-links a {
            text-decoration: none;
            color: #333;
            margin-right: 10px;
        }
        #h1{
            color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
        <div class="university-logo">
            <img src="Logo.png" alt="University Logo">
            <h1 id="h1">PRESIDENCY UNIVERSITY</h1>
        </div>
            <h2>Faculty Registration Page</h2>
    </header>
        <main>
        <div class="container">
            <h1>Faculty Registartion</h1>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            <div class="form-group">
                <label for="Fname">First Name</label>
                <asp:TextBox ID="Fname" runat="server" CssClass="form-control" required/></div>
            <div class="form-group">
                <label for="Lname">Last Name</label>
                <asp:TextBox ID="Lname" runat="server" CssClass="form-control" required/></div>
            <div class="form-group">
                <label for="Email">Email</label>
                <asp:TextBox ID="Email" runat="server"  CssClass="form-control" required/>
            </div>
            <div class="form-group">
                <label for="Password">Password</label>
                <asp:TextBox ID="Password" runat="server" TextMode="Password" CssClass="form-control" required/>
            </div>
            <div class="form-group">
                <label for="Squation">Favourite Number(Sequrity Question)</label>
                <asp:TextBox ID="Squestion" runat="server" CssClass="form-control" required/>
            </div>
            <div>
                <asp:Button ID="btnLogin" runat="server" Text="Submit" OnClick="Submit_Click" CssClass="btn-login" /><br />
                <asp:HyperLink ID="hlRegister" runat="server" NavigateUrl="Faculty_Login.aspx" Text="Login" CssClass="additional-link" />
                
            </div>
        </div>
            </main>
    </form>
    <footer>
        &copy; 2023 Presidency University. All rights reserved.
    </footer>
</body>
</html>
