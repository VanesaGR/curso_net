<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bajas.aspx.cs" Inherits="ASP_MASTER_PAGE.Bajas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="../Css/Estilos.css" rel="stylesheet" />

    <div><br /><br />
        <h1>BAJAS DE CLIENTES</h1>
    </div>

    <div class="fila">
        <div class="label">
            <asp:Label ID="Label1" runat="server" Text="Introduce el id a eliminar: " ForeColor="Black"></asp:Label>            
        </div>
        <div class="control">
            <asp:DropDownList ID="ddlistIdBaja" runat="server" DataSourceID="SqlDataSource2" DataTextField="id" DataValueField="id"></asp:DropDownList>
            &nbsp;
            <asp:Button ID="Button1" runat="server" Text="Borrar" OnClick="Button1_Click" />
        </div>
    </div>
    <div class="fila">
            <p>                
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource2">
                    <Columns>                        
                        <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                        <asp:BoundField DataField="apellido1" HeaderText="apellido1" SortExpression="apellido1" />
                        <asp:BoundField DataField="apellido2" HeaderText="apellido2" SortExpression="apellido2" />
                        <asp:BoundField DataField="ciudad" HeaderText="ciudad" SortExpression="ciudad" />
                        <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=ASATA406\SQLEXPRESSVANESA;Initial Catalog=SIMULACROMARTESSQL;Persist Security Info=True;User ID=sa;Password=1234" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [cliente]"></asp:SqlDataSource>                
            </p>
    </div>
    <div class="fila">
        <div class="label">
            <asp:Label ID="Label7" runat="server" ForeColor="Black"></asp:Label>
        </div>
    </div>
    
</asp:Content>

