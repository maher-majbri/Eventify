using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for TrainerDate
/// </summary>
public class TrainerDate
{
    public TrainerDate()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public static void Insert(TrainerModel model)
    {
        SqlCommand cmd = new SqlCommand(" spTrinerInsert");
        cmd.Parameters.AddWithValue("@Name", model.Name);
        cmd.Parameters.AddWithValue("@Email", model.Email);
        cmd.Parameters.AddWithValue("@Password", model.Password);
        cmd.Parameters.AddWithValue("@Phone", model.Phone);
        DataAccess.ExecuteStoredProc(cmd);

    }

    public static void update(TrainerModel model)
    {
        SqlCommand cmd = new SqlCommand(" spTrinerUpdate");
        cmd.Parameters.AddWithValue("@Name", model.Name);
        cmd.Parameters.AddWithValue("@Email", model.Email);
        cmd.Parameters.AddWithValue("@Password", model.Password);
        cmd.Parameters.AddWithValue("@Phone", model.Phone);
        cmd.Parameters.AddWithValue("@Id", model.Id);
        DataAccess.ExecuteStoredProc(cmd);

    }

    public static DataTable Select()
    {
        return DataAccess.GetData("SELECT * FORM Triner");

    }

    public static DataRow select(int id)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FORM Triner WERE id=@Id");
        cmd.Parameters.AddWithValue("@Id", id);
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

    public static DataRow login(string email, string password)
    {
        SqlCommand cmd = new SqlCommand("SELECT * FORM Triner WHERE Email=@Email AND Password=@Password");
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
}