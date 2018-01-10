using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
/// <summary>
/// Summary description for DataManager
/// </summary>
public class DataManager
{
	public DataManager()
	{
       
		//
		// TODO: Add constructor logic here
		//
	}
    public static string connectionString
    {
        get {

            return (ConfigurationManager.ConnectionStrings["CSString"].ToString());
        }
    
    }
    public static int executeNonQuery(SqlCommand command)
    {
        Int32 count;
        SqlConnection conn = new SqlConnection(connectionString);
       
        command.Connection = conn;

        conn.Open();
        count = command.ExecuteNonQuery();
        conn.Close();
        return (count);
    }
    public static Object executeScalar(SqlCommand command)
    {
        Object val;
        SqlConnection conn = new SqlConnection(connectionString);

        command.Connection = conn;

        conn.Open();
        val = command.ExecuteScalar();
        conn.Close();
        return (val);
    }
    public static DataSet executeDataset(SqlCommand command)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = new SqlConnection(connectionString);
        command.Connection = conn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = command;
        adapter.Fill(ds);
        return (ds);
    }

}