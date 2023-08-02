<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Details.aspx.cs" Inherits="Project_2.Student_Deatils" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title> <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }
        main {
            height: 70vh;
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
            height: 10vh;
            background-color: #333;
            color: #fff;
            text-align: center;
            padding: 20px;
        }

        .container {
            width: 500px;
            height: 300px;
            margin: 0 auto;
            border: 3px solid white;
            border-radius: 10px;
            padding: 10px;
            margin-bottom: 10px;
            text-align: center;
            background-image: url('light.jpg');
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
            color:blue;
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
        header {
            height: 10vh;
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 20px;
            background-color: #27449a;
            color: #fff;
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
        .navigation {
            display: flex;
        }

            .navigation .a {
                margin-right: 20px;
                color: #fff;
                text-decoration: none;
                border:2px solid white;
                box-sizing:border-box;
                padding:10px;
                border-radius:10px;
                background:blue;
            }
            .navigation .a:hover{
            background:white;
            color:blue;
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
            <h2>Welcome,<asp:Label ID="name" runat="server" Text=""></asp:Label></h2>
            <nav class="navigation">
                <asp:Button CssClass="a" runat="server" Text="Update Details" OnClick="Update_Click" />
                <asp:Button CssClass="a" runat="server" Text="Assignments" OnClick="Assignment_Click" />
                <asp:Button CssClass="a" runat="server" Text="Sign Out" OnClick="Sign_Out" />
        </nav>
    </header>
        <main>
            <div class="container"><br />
            <h1>Student Details</h1>
            <h4>Fisrt Name :<asp:Label ID="FName" runat="server" Text=""></asp:Label></h4>
            <h4>Last Name :<asp:Label ID="LName" runat="server" Text=""></asp:Label></h4>
            <h4>Email :<asp:Label ID="Email" runat="server" Text=""></asp:Label></h4>
                </div>
        </main>
    </form>
     <footer>
        &copy; 2023 Presidency University. All rights reserved.
    </footer>
</body>
</html>
