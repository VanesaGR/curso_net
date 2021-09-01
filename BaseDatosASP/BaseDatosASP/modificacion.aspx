<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificacion.aspx.cs" Inherits="BaseDatosASP.modificacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Clave: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Mail: "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Modificar" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Retornar</asp:HyperLink>
            <br />

        </div>
    </form>
</body>
</html>
