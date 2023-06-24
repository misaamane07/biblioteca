<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRegistrarUsuario.aspx.cs" Inherits="Webbiblioteca.WebRegistrarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="estilos.css" type="text/css" />
    <title>Registrar usuario</title>
</head>
<body>
    <form id="form1" runat="server">
              <sesion class="nav">    
           <a href="#">Inicio</a>
           <a href="#">Registrate</a>
           <a href="#">Consultar libro</a> 
           <a href="#">¨Solicitar Prestamo de Libro</a> 
           
        <center>

             <div class="div2">
                     <center> <h1>Registrar Usuario</h1></center>
                
                <asp:TextBox ID="txt_id" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su Identificacion"></asp:TextBox>
                 <br />
                <asp:TextBox ID="txt_nombres" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su Nombre"></asp:TextBox>
                 <br />
                <asp:TextBox ID="txt_apellidos" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su Apellido"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_Contacto" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su Contacto"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_Direccion" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su Direccion"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_Correo" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su Correo"></asp:TextBox>
                <br />
                <asp:DropDownList ID="cbx_estado_usuario" runat="server" CssClass="combo" placeholder="Estado" Width="200px" ></asp:DropDownList>
                <br />
                 <asp:Button ID="bnt_Registrar" runat="server" Text="Registrarse" CssClass="botones" OnClick="bnt_Registrar_Click"/>
                 
                 <asp:Button ID="bnt_consultar_subcrip" runat="server" Text="Consultar"  CssClass="botones" OnClick="Button1_Click" />
                 <asp:Button ID="bnt_actualizar" runat="server" Text="Actualizar"  CssClass="botones" OnClick="bnt_actualizar_Click" />
               </div>
             </center>
    </form>
</body>
</html>
