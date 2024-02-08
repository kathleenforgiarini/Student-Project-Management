<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="SMTI_Student_Project_Management.GUI.LoginPage1" %>

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
    .auto-style7 {
        width: 2px;
        text-align: center;
    }
    .auto-style12 {
        width: 96px;
        text-align: left;
    }
        .auto-style15 {
            width: 2px;
        }
        .auto-style16 {
            width: 27px;
        }
        .auto-style17 {
            text-align: center;
            width: 27px;
        }
    </style>
</head>
<body style="width: 401px">
    <form id="form1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="4"><strong>SMTI Student-Project Management</strong></td>
            </tr>
            <tr>
                <td class="auto-style2" colspan="4">LogIn</td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style3" colspan="3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style16">
                    <asp:RadioButtonList ID="radioType" runat="server" Width="105px">
                        <asp:ListItem Selected="True" Value="teacher">Teacher</asp:ListItem>
                        <asp:ListItem Value="student">Student</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style12">ID:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="txtBoxId" runat="server" Width="224px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style12">Password:</td>
                <td class="auto-style17">
                    <asp:TextBox ID="txtBoxPassword" runat="server" Width="224px"></asp:TextBox>
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style17">
                    <asp:Button ID="btnLogin" runat="server" BackColor="#009933" BorderColor="#336600" Font-Bold="True" ForeColor="White" OnClick="btnLogin_Click" Text="Login" Width="163px" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </div>
</form>
</body>
</html>
