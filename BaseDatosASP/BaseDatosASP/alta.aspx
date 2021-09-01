<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alta.aspx.cs" Inherits="BaseDatosASP.alta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Clave: "></asp:Label>&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mail: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Alta" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Retornar</asp:HyperLink>
        </div>
    </form>
</body>
</html>
