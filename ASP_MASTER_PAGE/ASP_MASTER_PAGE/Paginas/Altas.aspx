<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Altas.aspx.cs" Inherits="ASP_MASTER_PAGE.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Css/Estilos.css" rel="stylesheet" />
    <div><br /><br />
        <h1>ALTAS DE CLIENTES</h1>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label1" runat="server" Text="Id: " ForeColor="Black"></asp:Label>
        </div>
        <div class="datos">
            <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label2" runat="server" Text="Nombre" ForeColor="Black"></asp:Label>            
        </div>
        <div class="datos">
            <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label3" runat="server" Text="Apellido 1: " ForeColor="Black"></asp:Label>
        </div>
        <div class="datos">
            <asp:TextBox ID="txtApellido1" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label4" runat="server" Text="Apellido 2:" ForeColor="Black"></asp:Label>
        </div>
        <div class="datos">
            <asp:TextBox ID="txtApellido2" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label5" runat="server" Text="Ciudad:" ForeColor="Black"></asp:Label>
        </div>
        <div class="datos">
            <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label6" runat="server" Text="Categoría:" ForeColor="Black"></asp:Label>
        </div>
        <div class="datos">
            <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
            <br />
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label7" runat="server" ForeColor="Black"></asp:Label>
        </div>
    </div>
    <div class="fila">
        <asp:Button ID="Button1" runat="server" Text="Añadir" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombre" ErrorMessage="Error. Faltan datos." ForeColor="#990000"></asp:RequiredFieldValidator>
    </div>
</asp:Content>
