using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JobHunterApp
{
    public partial class GoogleMapWindow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            lbl1.Text = "Look for the Logo!";
            Method1(txt1.Text);
            
        }

        protected string Method1(string k)
        {
            string coord = k.ToString();
            return coord;

        }
    }
}