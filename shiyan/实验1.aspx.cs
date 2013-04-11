using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
public partial class 实验1 : System.Web.UI.Page
{
    //private MyDataBase studentsDB=new MyDataBase("studentDB");

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        MyDataBase studentsDB = new MyDataBase("studentDB");
        Label1.Text = "";
        studentsDB.sqlCommand.CommandText="Insert into studentInfo(stu_id,stu_name,stu_sex,address,photo) values(@id,@name,@sex,@address,@photo)";
        studentsDB.sqlCommand.Parameters.AddWithValue("@id", TextBox_id.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@name", TextBox_name.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@sex", TextBox_sex.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@address", TextBox_address.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@photo", FileUpload_photo.FileBytes);
        try
        {
            studentsDB.openConnection();
            studentsDB.sqlCommand.ExecuteNonQuery();
            Label1.Text = "插入成功";
        }
        catch (Exception ex)
        {
            Label1.Text = "插入失败";
        }
        finally
        {
            studentsDB.closeConnection();
            clear();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        MyDataBase studentsDB = new MyDataBase("studentDB");
        Label1.Text = "";
        if(RadioButtonById.Checked)
        {
            studentsDB.sqlCommand.CommandText="Select * from studentInfo where stu_id=@id";
            studentsDB.sqlCommand.Parameters.AddWithValue("@id",TextBox_id.Text);
        }
        else if(RadioButtonByName.Checked)
        {
            studentsDB.sqlCommand.CommandText="Select * from studentInfo where stu_name=@name";
            studentsDB.sqlCommand.Parameters.AddWithValue("@name",TextBox_name.Text);
        }
        else
        {
            studentsDB.sqlCommand.CommandText="Select * from studentInfo where stu_sex=@sex";
            studentsDB.sqlCommand.Parameters.AddWithValue("@sex", TextBox_sex.Text);
        }
       try
       {
            studentsDB.openConnection();
             SqlDataReader sqlDRder=studentsDB.sqlCommand.ExecuteReader();
             while (sqlDRder.Read())
             {
                 Label1.Text += sqlDRder.GetString(0)+ "  ";
                 Label1.Text += sqlDRder.GetString(1) + "  ";
                 Label1.Text += sqlDRder.GetString(2) + "  "; 
                 Label1.Text += sqlDRder.GetString(3) + "  "+"</br>";
             }
        }
        catch (Exception ex)
        {
            Label1.Text = "查询失败";
        }
        finally
        {
            studentsDB.closeConnection();
            clear();
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        MyDataBase studentsDB = new MyDataBase("studentDB");
        Label1.Text = "";
        studentsDB.sqlCommand.CommandText = "delete from studentInfo where stu_id=@id";
        studentsDB.sqlCommand.Parameters.AddWithValue("@id", TextBox_id.Text);
        try
        {
            studentsDB.openConnection();
            if(studentsDB.sqlCommand.ExecuteNonQuery()>0)
                Label1.Text = "删除成功";
        }
        catch (Exception ex)
        {
            Label1.Text = "删除失败";
        }
        finally
        {
            studentsDB.closeConnection();
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        MyDataBase studentsDB = new MyDataBase("studentDB");
        Label1.Text = "";
        studentsDB.sqlCommand.CommandText = "update studentInfo set stu_name=@name,stu_sex=@sex,address=@address where stu_id=@id";
        studentsDB.sqlCommand.Parameters.AddWithValue("@id", TextBox_id.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@name", TextBox_name.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@sex", TextBox_sex.Text);
        studentsDB.sqlCommand.Parameters.AddWithValue("@address", TextBox_address.Text);
        try
        {
            studentsDB.openConnection();
            if (studentsDB.sqlCommand.ExecuteNonQuery() > 0)
                Label1.Text = "更新成功";
        }
        catch (Exception ex)
        {
            Label1.Text = "更新失败";
        }
        finally
        {
            studentsDB.closeConnection();
            clear();
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
       /*
        MyDataBase studentsDB = new MyDataBase("studentDB");
        Label1.Text = "";
        studentsDB.sqlCommand.CommandText = "Select * from studentInfo";
        try
        {
            studentsDB.openConnection();
            SqlDataReader sqlDRder = studentsDB.sqlCommand.ExecuteReader();
            while (sqlDRder.Read())
            {
                Label1.Text += sqlDRder.GetString(0) + "  ";
                Label1.Text += sqlDRder.GetString(1) + "  ";
                Label1.Text += sqlDRder.GetString(2) + "  ";
                Label1.Text += sqlDRder.GetString(3) + "  " + "</br>";
            }
        }
        catch (Exception ex)
        {
            Label1.Text = "显示失败";
        }
        finally
        {
            studentsDB.closeConnection();
            clear();
        }
    }
    private void clear()
    {
        TextBox_sex.Text = "";
        TextBox_address.Text = "";
        TextBox_name.Text = "";
        TextBox_id.Text = "";
       // FileUpload_photo.
    }
}