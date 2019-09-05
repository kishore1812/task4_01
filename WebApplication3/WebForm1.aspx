<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

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
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Product Name:
                        <asp:TextBox ID="productname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Product Price:
                        <asp:TextBox ID="productprice" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                <td>Product Description:
                    <asp:TextBox ID="productdesc" runat="server"></asp:TextBox>
                </td>
            </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
