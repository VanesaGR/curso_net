<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CuestionarioASP_NET.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="Css/estilos.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="titulo">Examen de matemáticas</div>

        <div class="foto">
            <asp:Image ID="darth" runat="server" src="Imagenes/darthvader6.png" ImageAlign="Right"/>
        </div>

        <div class="uno">
            <p class="pregunta">Hay 5 estuches en la mesa. Cada uno contiene como mínimo 10 lápices y como máximo 14. 
            ¿Cuál de estos podría ser el total de lápices?
            </p>
            <asp:RadioButton ID="respuesta1" runat="server" Text="45" Groupname="A"/><br />
            <asp:RadioButton ID="respuesta2" runat="server" Text="75" Groupname="A"/><br />
            <asp:RadioButton ID="correcta1" class="correcta" runat="server" Text="65" Groupname="A"/><br />
            <asp:RadioButton ID="respuesta4" runat="server" Text="35" Groupname="A"/><br />
        </div>             

        <div class="dos">
            <p class="pregunta"> Si X es menor que Y por una diferencia de 6 e Y es el doble de Z, 
                ¿cuál es el valor de X cuando Z es igual a 2?</p>
            <asp:RadioButton ID="respuesta5" runat="server" Text="5" Groupname="B"/><br />
            <asp:RadioButton ID="respuesta6" runat="server" Text="8" Groupname="B"/><br />
            <asp:RadioButton ID="correcta2" runat="server" Class="correcta" Text="-2" Groupname="B"/><br />
            <asp:RadioButton ID="respuesta8" runat="server" Text="10" Groupname="B"/>
            <br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" Groupname="B"/>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" BackColor="#FFCCCC" BorderColor="Black" BorderWidth="2px" BorderStyle="Solid"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="DEBERÍAS INTRODUCIR LA CANCIÓN"
                ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
            <br />
            <br />
            Introduce el rango adecuado (entre 10 y 20)
            <asp:TextBox ID="TextBox2" runat="server" BackColor="#FFCCFF" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="ERROR DE RANGO" MaximumValue="20" MinimumValue="10" Type="Integer">EL VALOR NO ESTÁ EN EL RANGO PERMITIDO</asp:RangeValidator>
            <br />
            <br />
            Contraseña<br />
&nbsp;<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            Comprueba contraseña<br />
&nbsp;<asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="NO SON IGUALES!!!"></asp:CompareValidator>
            <br />
            <br />
        </div>
        
        <div class="tres">
            <asp:Button ID="Button1" runat="server" Text="Calcula" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Reset" OnClick="Button2_Click" /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="¿Acertarás o no?"></asp:Label>
            <br />
            <br />
            Introduce un correo electrónico válido
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Email"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="ESO NO ES UN EMAIL!!!" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"></asp:RegularExpressionValidator>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
        
    </form>
</body>
</html>
