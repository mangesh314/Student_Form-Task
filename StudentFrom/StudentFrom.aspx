<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentFrom.aspx.cs" Inherits="StudentFrom.StudentFrom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <%--<tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Student ID"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtid" runat="server"></asp:TextBox></td>
                </tr>--%>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="DBO"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtdbo" runat="server" TextMode="Date"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblradio" runat="server" Text="Gender"></asp:Label>
                    </td>
                    <td>
                        <asp:RadioButtonList ID="rbtn" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Language"></asp:Label></td>
                    <td>
                        <asp:DropDownList ID="ddllanguage" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                    <td>
                        <asp:Button ID="btnsave" runat="server" Text="Save" /></td>
                    <td>
                        <asp:Button ID="btnclear" runat="server" Text="Clear" />
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdstudent" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField DataField="Language" HeaderText="Language" />

            </Columns>
        </asp:GridView>

    </form>
</body>
</html>
