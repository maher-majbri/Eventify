using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class LoginMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // TODO: validation

        // check if the member can login
        DataRow dr= MemberData.Login(txtEmail.Text, txtPassword.Text);
        if (dr != null)
        {
            Session["MemberId"] = dr["Id"];
            Session["MemberName"] = dr["Name"];
            Session["MemberEmail"] = dr["Email"];
            Session["MemberPassword"] = dr["Password"];
            Response.Redirect("Member");
        }
        else
        {
            pnlMessage.Visible = true;
        }

    }
 
}