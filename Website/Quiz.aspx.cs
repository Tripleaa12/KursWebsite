using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class Quiz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            dblayer dblayer = new dblayer();
            dblayer.InsertValuesToDB(TextBoxUserName.Text, Label1.Text, TextBox1.Text, Label2.Text, TextBox2.Text, Label3.Text, TextBox3.Text);

            if(string.IsNullOrEmpty(TextBoxUserName.Text) || string.IsNullOrEmpty(TextBox1.Text) || string.IsNullOrEmpty(TextBox3.Text) || string.IsNullOrEmpty(TextBox2.Text))
            {
                LabelWronginput.Visible = true;

                return;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}