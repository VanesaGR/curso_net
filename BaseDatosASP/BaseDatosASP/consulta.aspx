﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="consulta.aspx.cs" Inherits="BaseDatosASP.consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Ingrese el nombre del usuario: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>

            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/default.aspx">Retornar</asp:HyperLink>

        </div>
    </form>
</body>
</html>
