using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DataAccess
/// </summary>
public class DataAccess
{

    private static SqlConnection con = new SqlConnection(
        ConfigurationManager.ConnectionStrings["constr"].ToString()
        );

    public DataAccess()
    {
    }

    private static void OpenConnection() {
        if (con.State != ConnectionState.Open)
        {
            con.Open();
        }
    }

    private static void CloseConnection() {
        if (con.State != ConnectionState.Closed)
        {
            con.Close();
        }
    }

    public static DataTable GetData(string sql)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter(sql,con);
        da.Fill(dt);
        return dt;
    }

    public static DataTable GetData(SqlCommand cmd)
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.Connection = con;
        da.SelectCommand = cmd;
        da.Fill(dt);
        return dt;
    }

    public static void ExecuteStoredProc(SqlCommand cmd)
    {
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        OpenConnection();
        cmd.ExecuteNonQuery();
        CloseConnection();
    }

}

// TODO: design register page
