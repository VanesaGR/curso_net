<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioValidacion.aspx.cs" Inherits="EjercicioValidacion.FormularioValidacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Nombre de usuario"></asp:Label>
    &nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br /><br />
        <asp:Label ID="Label2" runat="server" Text="Clave"></asp:Label>
    &nbsp;
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="LAS CLAVES NO COINCIDEN"></asp:CompareValidator>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Repite la clave"></asp:Label>
    &nbsp;
        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox><br /><br />
        <asp:Label ID="Label4" runat="server" Text="Correo electrónico"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox4" runat="server" TextMode="Email"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="LOS DATOS NO CORRESPONDEN A UN EMAIL" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Nombre"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="País de origen"></asp:Label> 
        &nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>ESPAÑA</asp:ListItem>
            <asp:ListItem>PORTUGAL</asp:ListItem>
            <asp:ListItem>FRANCIA</asp:ListItem>
            <asp:ListItem>ITALIA</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Provincia"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Código Postal"></asp:Label>
        &nbsp;<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Sexo"></asp:Label>
        &nbsp;<asp:RadioButton ID="RadioButton1" runat="server" Text="Hombre" GroupName="Sexo" />
        &nbsp;<asp:RadioButton ID="RadioButton2" runat="server" Text="Mujer" GroupName="Sexo" />
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Fecha de nacimiento<br/>(dd/mm/aaaa)"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" Width="206px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label12" runat="server" Text="Comentarios "></asp:Label>
        <asp:TextBox ID="TextBox10" runat="server" Height="133px" Width="300px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Acepto los términos y condiciones"></asp:Label>
        &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="Acepto" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
        <br />
    </form>
</body>
</html>
