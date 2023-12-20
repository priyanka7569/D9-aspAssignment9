using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assessment_9_Web_Form_Customer
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            LblInfo.Visible = false;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblInfo.Visible=true;
            LblInfo.Text += "Welcome " + TxtCustName.Text;
            LblInfo.Text += "Your Mobile Number: " + TxtCustMob.Text;
            LblInfo.Text += "Your Email: " + TxtCustEmail.Text;
            LblInfo.Text += "Your Password: " + TxtCustPassword.Text;
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string name = args.Value;
            args.IsValid = name.Length == 6;
        }
    }
}
