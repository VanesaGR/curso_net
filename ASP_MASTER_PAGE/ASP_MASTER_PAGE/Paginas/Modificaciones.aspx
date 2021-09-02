<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Modificaciones.aspx.cs" Inherits="ASP_MASTER_PAGE.Modificaciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Css/Estilos.css" rel="stylesheet" />

    <div><br /><br />
        <h1>MODIFICACION DE CLIENTES</h1>
    </div>

    <div class="fila">
        <div class="label">
            <asp:Label ID="Label1" runat="server" Text="Id: " ForeColor="Black"></asp:Label>
        </div>
        <div class="datos">
            <asp:DropDownList ID="ddlistIdMod" runat="server" DataSourceID="SqlDataSource1" DataTextField="id" DataValueField="id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:simulacroMartesSqlConnectionSTring %>" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>
            &nbsp;
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
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
            <asp:Button ID="Button1" runat="server" Text="Modificar" ForeColor="Black" OnClick="Button1_Click" />
        </div>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label7" runat="server" ForeColor="Black"></asp:Label>
        </div>
    </div>
    
</asp:Content>
