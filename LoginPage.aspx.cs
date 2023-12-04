using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConstructPOE
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var en = new RegisteredUsersEntities();
            var hasher = new Encyption(); //Password Hasher class
            var password = hasher.hash(txtkeypass.Text);
            try
            {
                var Authentication = en.Users.FirstOrDefault(lam => lam.Name == txtusername.Text && lam.Pass == password);
                if (Authentication == null) { Response.Write( "Authentication failed, User does not exist or Invalid password"); }
                else { Response.Redirect("MainPage.aspx"); }
            }
            catch { }
        }
    }
}