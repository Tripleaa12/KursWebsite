<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="Website.Quiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Jojo siwa</title>
     
    <link rel="stylesheet" type="text/css" href="style1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <style>
       
       
       
      
        .auto-style1 {
            width: 225px;
            height: 208px;
            margin-left:170px;
            
            
        }
       
      
    </style>
         
        <p>
        
            &nbsp;</p>
        <h1>
            Velkommen 

   <asp:LoginName ID="LoginName1" runat="server" />
            
   

        </h1>
        <p>Før du tar denne testen, hva er fornavnet ditt?</p>

        
        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        
        </td>
    <table>
               <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Hvilken redigerings app er det vi brukte?"> </asp:Label></td><td >
                          
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                   
                   
               </tr>
               <tr>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Hva heter det når du tar videoen du redigerte til mobilen?"></asp:Label></td><td>
                       <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
               </tr>
               <tr>
                   
                   <td>

                       <asp:Label ID="Label3" runat="server" Text="Hva heter det når du deler to video deler fra hverandre?"></asp:Label></td><td>
                       <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                  
               </tr>
               <tr>
                   <td></td><td>
                       <asp:Button ID="ButtonSubmit" CssClass="btn" runat="server" Text="Send inn" OnClick="ButtonSubmit_Click" /></td>
                    
               </tr>
           </table>
       
                 <asp:Label ID="LabelWronginput" runat="server" Text="Du må skrive svar inn i alle feltene" Visible="false"></asp:Label>
                  <img src="Quiz.jpg" class="auto-style1" />
         
        <p>
        
      <asp:Button ID="Button2" CssClass="btn" runat="server" Text="Tilbake hjem" OnClick="Button2_Click" />
            </p>
         
    </form>
    
   
    
   

</body>
</html>
 