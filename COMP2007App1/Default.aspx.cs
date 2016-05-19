using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007App1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            TextBoxFullName.Text = TextBoxFirstName.Text +" "+ TextBoxLastName.Text;
        }
    }
}
// default code behind file