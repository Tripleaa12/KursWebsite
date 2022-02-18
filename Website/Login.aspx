<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Website.Login" %>

<!DOCTYPE html>

<html>
<head>
  <title>Login</title>
  <link rel="stylesheet" type="text/css" href="style1.css">
    <style>
        body{
            background-color:#42455a;
        }
    </style>
</head>
<body>
  <div class="header">
  	<h2>Login</h2>
  </div>
	 
  <form runat="server">
  	<div class="input-group">
  		<label>Username</label>
  		<asp:TextBox ID="TextBoxNameLogin" runat= "server"></asp:TextBox>
  	</div>
  	<div class="input-group">
  		<label>Password</label>
  	<asp:TextBox ID="TextBoxPassLogin" runat="server"></asp:TextBox>
  	</div>
  	<div class="input-group">
          <asp:Button ID="Button1" CssClass="btn" OnClick="Button1_Click" runat="server" Text="Login" Height="38px" Width="555px"/>
  		
  	</div>
      <asp:Label ID="LabelLoginError" ForeColor="Red" runat="server" Text="Invalid username or password"  Visible="false"></asp:Label>
      <br />
      <asp:Label ID="LabelNoInput" ForeColor="Red" runat="server" Text="Username or password can not be empty" Visible="false"></asp:Label>
  	<p>
  		Not yet a member? <a href="WebForm1.aspx">Sign up</a>
  	</p>
  </form>


</body>
</html>