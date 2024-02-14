<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProjAssignment.aspx.cs" Inherits="SMTI_Student_Project_Management.GUI.ProjAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            font-size: x-large;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style5 {
            width: 151px;
        }
        .auto-style6 {
            width: 115px;
        }
        .auto-style7 {
            width: 32px;
        }
        .auto-style8 {
            width: 116px;
        }
        .auto-style9 {
            width: 40px;
        }
        .auto-style12 {
            width: 151px;
            height: 26px;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 115px;
            height: 26px;
        }
        .auto-style15 {
            width: 32px;
            height: 26px;
        }
        .auto-style16 {
            width: 40px;
            height: 26px;
        }
        .auto-style17 {
            width: 116px;
            height: 26px;
        }
        .auto-style18 {
            width: 161px;
        }
        .auto-style19 {
            width: 161px;
            height: 26px;
        }
        .auto-style20 {
            text-align: center;
            width: 116px;
        }
        .auto-style21 {
            width: 161px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3" colspan="8"><strong>
                        <asp:Label ID="lblName" runat="server" Text="Label" CssClass="auto-style2"></asp:Label>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20">Select Student</td>
                    <td class="auto-style5">
                        <asp:DropDownList ID="DropDownListStudent" runat="server" Width="270px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="btnListProjects" runat="server" Text="List Projects" OnClick="btnListProjects_Click" Width="170px" />
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20">Select Project</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownListProject" runat="server" Width="270px">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style21">
                        <asp:Button ID="btnListStudents" runat="server" Text="List Students" Width="170px" OnClick="btnListStudents_Click" />
                    </td>
                    <td>&nbsp;</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style3" colspan="2">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style20">Assigned Date</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtAssignedDate" runat="server" Width="262px" ReadOnly="True"></asp:TextBox>
                    </td>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17">&nbsp;</td>
                    <td class="auto-style12">
                        <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="178px" Width="266px" OnSelectionChanged="Calendar1_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                    </td>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style13">
                        <asp:GridView ID="GridView1" runat="server" Width="494px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style14">
                        &nbsp;</td>
                    <td class="auto-style15"></td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style19"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style19"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style16"></td>
                    <td class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Button ID="btnAssignProject" runat="server" Text="Assign Project" Width="133px" OnClick="btnAssignProject_Click" />
                    </td>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
