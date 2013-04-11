using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class 实验2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Label1.Text = "";
    }
    
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        Panel2.Visible = true;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        
        MyDataBase studentsDB = new MyDataBase("studentDB");

        studentsDB.sqlCommand.CommandText = "select *from users where name=@name";
        studentsDB.sqlCommand.Parameters.AddWithValue("@name", TextBox_name.Text);  
        try
        {

            studentsDB.openConnection();
            SqlDataReader sqlDRed = studentsDB.sqlCommand.ExecuteReader();
            sqlDRed.Read();
            if (!sqlDRed.HasRows)
            {
                Label1.Text="用户不存在";
            }
            else if (sqlDRed.GetString(1).Equals( TextBox_password.Text))
            {
                Session["result"] = "欢迎您" + sqlDRed.GetString(0);
                Server.Transfer("~/logResult.aspx");
            }
            else
            {
                Label1.Text = "密码错误";
            }
            
        }
        catch (Exception ex)
        {
            Label1.Text = "错误:"+ex.Message;
        }
        finally
        {
            studentsDB.closeConnection();
           
        }

    }

    protected void Button_ok_Click(object sender, EventArgs e)
    {

    }
}