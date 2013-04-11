<%@ Page Language="C#" AutoEventWireup="true" CodeFile="实验1.aspx.cs" Inherits="实验1" Debug="true" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>实验题 1</title>
    <style type="text/css">
        .style1
        {
            width: 38%;
            height: 119px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="headDiv">
            <p>实验题 1 </p> 
            <p><a href=Default.aspx>返回主页</a></p>
        </div>
        <div style="text-align:center">
            
            <table class="style1" align="center">
                <tr>
                    <td>
                        学号：</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox_id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        姓名：</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        性别：</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox_sex" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        地址：</td>
                    <td align="left">
                        <asp:TextBox ID="TextBox_address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        照片：</td>
                    <td align="left">
&nbsp;<asp:FileUpload ID="FileUpload_photo" runat="server" />
                    </td>
                </tr>
            </table>
            <p>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="插入" onclick="Button1_Click" />&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="查询" onclick="Button2_Click" />&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="按学号删除" onclick="Button3_Click" />&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="按学号更新" onclick="Button4_Click" />&nbsp;
                    <asp:Button ID="Button5" runat="server" Text="显示学生信息" onclick="Button5_Click" 
                        PostBackUrl="~/display.aspx" />
            </p>
            <p>
                
                <asp:RadioButton ID="RadioButtonById" runat="server" GroupName="choose" 
                    Text="按学号查询"/>
                <asp:RadioButton ID="RadioButtonByName" runat="server" GroupName="choose" 
                    Text="按姓名查询" />
                <asp:RadioButton ID="RadioButonBySex" runat="server" GroupName="choose" 
                    Text="按性别查询" />
            </p>
            <p>

                

                <asp:Label ID="Label1" runat="server"></asp:Label>

                

            </p>
        </div>
    </div>
    </form>
</body>
</html>
