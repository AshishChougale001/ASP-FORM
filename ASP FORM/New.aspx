<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="ASP_FORM.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name</td>
                    <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                     </td>
                    <td>Mobile No.</td>
                    <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Age</td>
                    <td>
                    <asp:TextBox ID="TextBox3" runat="server" Placeholder="18+"></asp:TextBox>
                     </td>
                    <td>Gender</td>
                    <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
