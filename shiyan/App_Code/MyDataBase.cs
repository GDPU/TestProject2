using System;
using System.Collections.Generic;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public class MyDataBase
{
    private string connectString;
    private SqlConnection sqlConnection;
    public SqlCommand sqlCommand;

    public MyDataBase(string connectionString)
    {
        connectString = ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
        sqlConnection = new SqlConnection(connectString);
        sqlCommand = new SqlCommand();
        sqlCommand.Connection = sqlConnection;
    }
    public void openConnection()
    {
        sqlConnection.Open();
        // Response.Write("Conneted to school succeed" + "<br/>");
    }
    public void closeConnection()
    {
        sqlConnection.Close();
    }
   
}
