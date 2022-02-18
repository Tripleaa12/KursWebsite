using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dblayer dblayer = new dblayer();
            dblayer.IsvalidEmail(TextBoxemail.Text);
            bool isvalidEmail = dblayer.IsvalidEmail(TextBoxemail.Text);
            if (TextBoxpassword.Text != TextBoxconfirm.Text)
            {
                Labelpassworderror.Visible = true;
               

                return;
                
                
            }

            else if (string.IsNullOrEmpty(TextBoxpassword.Text) || string.IsNullOrEmpty(TextBoxemail.Text) || string.IsNullOrEmpty(TextBoxname.Text))
            {
                LabelNoInput.Visible = true;

                return;
            }

            else if(isvalidEmail == false)
            {
                Labelwrongemail.Visible = true;
            }
            
            else
            {
                dblayer.InsertPerson(TextBoxname.Text, TextBoxemail.Text, TextBoxpassword.Text);
                Response.Redirect("login.aspx");
            }

            
           


              

            
         
         


            
        }
        
    }
}