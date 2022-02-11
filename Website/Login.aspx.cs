using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Website
{
    public partial class Login : System.Web.UI.Page
    {
        dblayer _dblayer = new dblayer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool foundPerson = _dblayer.SelectPerson(TextBoxNameLogin.Text, TextBoxPassLogin.Text);

            // Valid login
            if (foundPerson)
            {
                
                FormsAuthentication.RedirectFromLoginPage(TextBoxNameLogin.Text, false);
            }

            

            else 
            {
                LabelLoginError.Visible = true;
               
            }
            



        }
    }
}