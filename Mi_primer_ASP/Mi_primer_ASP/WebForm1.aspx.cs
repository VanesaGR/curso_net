using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mi_primer_ASP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = DateTime.Today.ToString("d");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x =int.Parse(Label1.Text); x++; Label1.Text =x.ToString();
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (DropDownList1.Items[0].Selected)
            {
                int x1 = int.Parse(TextBox1.Text);
                int x2 = int.Parse(TextBox2.Text);
                int suma = x1 + x2; 
                
                Label1.Text = "La suma es:" +suma + "<br>";
            }
            if (DropDownList1.Items[1].Selected)
            {
                int x1 = int.Parse(TextBox1.Text);
                int x2 = int.Parse(TextBox2.Text);
                int resta = x1 - x2;

                Label1.Text = "La resta es:" + resta + "<br>";
            }
        }
    }
}