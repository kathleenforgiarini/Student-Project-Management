<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SMTI_Student_Project_Management.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 97%;
        }
        .auto-style2 {
            text-align: center;
            font-size: large;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style5 {
            width: 96px;
            text-align: center;
        }
        .auto-style6 {
            width: 310px;
        }
        .auto-style7 {
            width: 2px;
            text-align: center;
        }
        .auto-style8 {
            width: 261px;
        }
        .auto-style9 {
            width: 261px;
            text-align: center;
        }
        .auto-style10 {
            width: 310px;
            text-align: center;
        }
        .auto-style12 {
            width: 96px;
            text-align: left;
        }
        .auto-style13 {
            width: 137px;
        }
        .auto-style14 {
            width: 137px;
            text-align: center;
        }
    </style>
</head>
<body style="width: 414px; margin-top: 15px">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="5"><strong>SMTI Student-Project Management</strong></td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="5">LogIn</td>
                </tr>
                <tr>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3" colspan="3">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="105px">
                            <asp:ListItem>Teacher</asp:ListItem>
                            <asp:ListItem>Student</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style12">ID:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtBoxId" runat="server" Width="224px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style12">Password:</td>
                    <td class="auto-style14">
                        <asp:TextBox ID="txtBoxPassword" runat="server" Width="224px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Button ID="btnLogin" runat="server" BackColor="#009933" BorderColor="#336600" Font-Bold="True" ForeColor="White" Text="Login" Width="163px" />
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
