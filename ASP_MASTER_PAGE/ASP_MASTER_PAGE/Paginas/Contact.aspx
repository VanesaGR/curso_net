<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ASP_MASTER_PAGE.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Página de contacto</h3>
    <address>
        Avda. Constitución s/n<br />
        41008 Sevilla
        <br />
        <abbr title="Phone">P:</abbr>
        425.555.0100        
    </address>
    <asp:Image ID="Image1" runat="server" src="Img/estrella.png"/>

    <address>
        <strong>Soporte técnico:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
