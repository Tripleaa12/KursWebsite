 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website.WebForm1" %>

<!DOCTYPE html>

<html>
<head>
  <title>Registrering</title>
   <link rel="stylesheet" type="text/css" href="style1.css">
    <style>
        body{
            background-color:#42455a;
        }
        .auto-style1 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            padding: 10px;
            font-size: 15px;
            color: white;
            background: #003366;
            border-radius: 5px;
            margin-left: 0px;
        }
    </style>
</head>
<body>
  <div class="header">
  	<h2>Register</h2>
  </div>
	
  <form method="post" runat="server" >
  	<?php include('errors.php'); ?>
  	<div class="input-group">
  	  <label>Username</label>
  	  <asp:TextBox ID="TextBoxname" runat= "server"></asp:TextBox>
  	</div>
  	<div class="input-group">
  	  <label>Email</label>
  	  <asp:TextBox ID="TextBoxemail" runat="server"></asp:TextBox>
  	</div>
  	<div class="input-group">
          
  	  <label>Password</label>
          <asp:TextBox ID="TextBoxpassword" runat="server"></asp:TextBox>
  	</div>
  	<div class="input-group">
  	  <label>Confirm password</label>
  	  <asp:TextBox ID="TextBoxconfirm" runat="server" ></asp:TextBox>
  	</div>
      <asp:Label ID="LabelNoInput" runat="server" Text="Inputs needed" Visible="false"></asp:Label>
      <asp:Label ID="Labelpassworderror" runat="server" Text="passwords has to match"  Visible="false"></asp:Label>
  	<div class="input-group">
          <asp:Label ID="RegisterWork" runat="server" Text="Du har registrert deg, gå videre til login." Visible="false"></asp:Label>
          
          <asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Register" CssClass="auto-style1" Height="38px" Width="555px" />
  	  
  	</div>
  	<p>
  		Already a member? <a href="login.aspx">Sign in</a>
  	</p>
  </form>


</body>
</html>
