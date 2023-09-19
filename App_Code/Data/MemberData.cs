using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MemberData
/// </summary>
public class MemberData
{
    public MemberData()
    {
    }

    public static void Insert(MemberModel model) {
        SqlCommand cmd = new SqlCommand("spMemberInsert");
        cmd.Parameters.AddWithValue("@Name",model.Name);
        cmd.Parameters.AddWithValue("@Email",model.Email);
        cmd.Parameters.AddWithValue("@Password",model.Password);
        cmd.Parameters.AddWithValue("@Phone", model.Phone);
        DataAccess.ExecuteStoredProc(cmd);
    }

    public static void Update(MemberModel model)
    {
        SqlCommand cmd = new SqlCommand("spMemberUpdate");
        cmd.Parameters.AddWithValue("@Name", model.Name);
        cmd.Parameters.AddWithValue("@Email", model.Email);
        cmd.Parameters.AddWithValue("@Password", model.Password);
        cmd.Parameters.AddWithValue("@Phone", model.Phone);
        cmd.Parameters.AddWithValue("@Id", model.Id);
        DataAccess.ExecuteStoredProc(cmd);
    }

    //TODO : delete/soft delete

    public static DataTable Select()
    {
        return DataAccess.GetData("SELECT * FROM Members");
    }

    public static DataRow Select(int id)
    {
        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Members WHERE Id=@Id"
            );
        cmd.Parameters.AddWithValue("@Id", id);
        DataTable dt = DataAccess.GetData(cmd);
        if (dt.Rows.Count > 0)
        {
            return dt.Rows[0];
        }
        else {
            return null;
        }
    }


    public static DataRow Login(string email , string password)
    {
        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Members WHERE Email=@Email AND Password=@Password"
            );
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.Parameters.AddWithValue("@Password", password);
        DataTable dt = DataAccess.GetData(cmd);
        if (dt.Rows.Count > 0)
        {
            return dt.Rows[0];
        }
        else
        {
            return null;
        }
    }


    public static bool EmailExist(string email)
    {
        SqlCommand cmd = new SqlCommand(
            "SELECT * FROM Members WHERE Email=@Email"
            );
        cmd.Parameters.AddWithValue("@Email", email);
        DataTable dt = DataAccess.GetData(cmd);
        if (dt.Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}