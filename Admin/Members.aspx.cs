using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Members : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = Convert.ToInt16(Request.QueryString["Id"]);
            DataRow dr = MemberData.Select(id);
            if (dr != null)
            {
                txtID.Text = Convert.ToString(dr["Id"]);
                txtName.Text = Convert.ToString(dr["Name"]);
                txtEmail.Text = Convert.ToString(dr["Email"]);
                txtPassword.Text = Convert.ToString(dr["Password"]);
                txtPhone.Text = Convert.ToString(dr["Phone"]);
                //btnDelete.Text = (Convert.ToBoolean(dr["Active"]) == true) ? "Disable" : "Enable";
                SetEdit();
            }
        }
    }
    public void ClearForm()
    {
        txtID.Text = "";
        txtName.Text = "";
        txtEmail.Text = "";
        txtPassword.Text = "";
        txtPhone.Text = "";
        SetNew();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        MemberData.Insert(new MemberModel
        {
            Name = txtName.Text,
            Email = txtEmail.Text,
            Password = txtPassword.Text,
            Phone = txtPhone.Text
        });
        GridView1.DataBind();
        ClearForm();
        pnlMessageOk.Visible = true;
        lblMessageOk.Text = "New Member Added!";
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        MemberData.Update(new MemberModel
        {
            Name = txtName.Text,
            Email = txtEmail.Text,
            Password = txtPassword.Text,
            Phone = txtPhone.Text,
            Id = Convert.ToInt16(txtID.Text)
        });
        GridView1.DataBind();
        SetNew();
        ClearForm();
        pnlMessageOk.Visible = true;
        lblMessageOk.Text = "Data Updated!";
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //TODO : soft delete or delete

        GridView1.DataBind();
        SetNew();
        ClearForm();
        pnlMessageOk.Visible = true;
        lblMessageOk.Text = "Member Deleted!";
    }

    public void SetEdit()
    {
        btnUpdate.Enabled = true;
        btnDelete.Enabled = true;
        btnInsert.Enabled = false;
    }

    public void SetNew()
    {
        btnUpdate.Enabled = false;
        btnDelete.Enabled = false;
        btnInsert.Enabled = true;
    }
}