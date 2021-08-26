<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Mi_primer_ASP.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="StyleSheet1.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            width: 602px;
            height: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        Ingrese primer valor  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Ingrese segundo valor <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><br />
        <asp:ListBox ID="DropDownList1" runat="server">
            <asp:ListItem>Suma</asp:ListItem>
            <asp:ListItem>Resta</asp:ListItem>
        </asp:ListBox>
        <br /><br />
        
        <asp:Button ID="Button1" runat="server" Text="Resultado" OnClick="Button1_Click1" />
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Resultado"></asp:Label>
    </form>
</body>
</html>
