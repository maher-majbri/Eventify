using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RegisterMember : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        pnlMessageOk.Visible = false;
        lblMessageOk.Text = "";
        pnlMessageError.Visible = false;
        lblMessageError.Text = "";
    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //TODO : Validate data

        //check if the  member already registerd member in database
        if (MemberData.EmailExist(txtEmail.Text))
        {
            pnlMessageError.Visible = true;
            lblMessageError.Text = "You are already registered!";
        }
        else
        {
            //insert new member in database
            MemberData.Insert(new MemberModel()
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Password=txtPassword.Text,
                Phone=txtPhone.Text
            });
            pnlMessageOk.Visible = true;
            lblMessageOk.Text = "Thank you for registration!";
        }
    }
}