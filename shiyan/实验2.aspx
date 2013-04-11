<%@ Page Language="C#" AutoEventWireup="true" CodeFile="实验2.aspx.cs" Inherits="实验2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 47%;
            height: 141px;
        }
        .style2
        {
            height: 31px;
        }
        .style3
        {
            height: 31px;
            width: 261px;
        }
        .style4
        {
        }
        .style5
        {
            height: 31px;
            width: 179px;
        }
        .style7
        {
            width: 179px;
        }
        .style8
        {
            width: 179px;
            height: 16px;
        }
        .style9
        {
            height: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="headDiv">
            <p>实验题 2 </p> 
            <p><a href=Default.aspx>返回主页</a></p>
        </div>
        <div align="center">
            
            <asp:Panel ID="Panel1" runat="server">
                <table class="style1" border="1">
                    <tr>
                        <td abbr="2" class="style5">
                            <asp:Button ID="Button1" runat="server" ForeColor="#666699" Height="25px" 
                                Text="登录" Width="139px"  />
                        </td>
                        <td abbr="2" class="style2">
                            <asp:Button ID="Button2" runat="server" ForeColor="#666699" Height="25px" 
                                Text="注册" Width="203px" onclick="Button2_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            用户名：</td>
                        <td abbr="2" class="style4">
                            <asp:TextBox ID="TextBox_name" runat="server" 
                                ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style7">
                            密 码:</td>
                        <td abbr="2" class="style4">
                            <asp:TextBox ID="TextBox_password" runat="server" TextMode="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="style8">
                            验证码:</td>
                        <td abbr="2" class="style9">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="Button5" runat="server" onclick="Button5_Click" Text="登录" />
                            &nbsp;
                            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </asp:Panel>
            
             <asp:Panel ID="Panel2" runat="server" Visible="False">
                <table class="style1" align="3" border="3">
                    <tr>
                        <td class="style3">
                            <asp:Button ID="Button3" runat="server" ForeColor="#666699" Height="25px" 
                                Text="登录" Width="186px" onclick="Button3_Click" />
                        </td>
                        <td abbr="2" class="style2">
                            <asp:Button ID="Button4" runat="server" ForeColor="#666699" Height="25px" 
                                Text="注册" Width="203px" />
                        </td>
                    </tr>
                    <tr>
                        <td abbr="2" class="style4" colspan="2">
                           <p>
                               用户名：<asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="142px"></asp:TextBox>
                           </p>
                           <p>
                               密码：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                           </p>
                           <p>
                               再次输密码：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                           </p>
                           <p>
                               <asp:Button ID="Button_ok" runat="server" Text="注册" />
                               <asp:Button ID="Button_cansel" runat="server" Text="重置" />
                           </p>
                            </td>
                    </tr>
                </table>
            </asp:Panel>
            
        </div>
    </div>
    </form>
</body>
</html>
