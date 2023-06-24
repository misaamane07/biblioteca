<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebPrestamos.aspx.cs" Inherits="Webbiblioteca.WebPrestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Prestamo de libros</title>
    <link rel="stylesheet" href="estilos.css" type="text/css" />
</head>
    <hader>
        <sesion class="nav">    
           <a href="#">Inicio</a>
           <a href="#">Registrate</a>
           <a href="#">Consultar libro</a>
           <a href="#">¨Solicitar Prestamo de Libro</a>
    </hader>
   <center> <h1>Prestamos de libros</h1>
    <p>Lennar el formulario que 
      se presenta a continuacion</p></center>
    <br />
<body>
    <form id="form1" runat="server">
        <div>
            <center>
            <asp:TextBox ID="txt_id" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su identificacion"></asp:TextBox>
                 <br />
                <asp:TextBox ID="txt_nombre_l" runat="server" Width="200px" CssClass="cajas" placeholder="Nombre del libro"></asp:TextBox>
                 <br />
                <asp:TextBox ID="txt_autor" runat="server" Width="200px" CssClass="cajas" placeholder="Nombre del autor"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_editorial" runat="server" Width="200px" CssClass="cajas" placeholder="Nombre de la editorial"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_N_paginas" runat="server" Width="200px" CssClass="cajas" placeholder="Numero de paginas"></asp:TextBox>
                <br />
                <asp:TextBox ID="txt_Genero" runat="server" Width="200px" CssClass="cajas" placeholder="Genero del libro"></asp:TextBox>
                <br />
                <asp:TextBox ID="cl_fecha_p" runat="server" Width="200px" CssClass="cajas" placeholder="Fecha de publicacion" TextMode="Date"></asp:TextBox>
                <br />
                <asp:DropDownList ID="cbx_estado" runat="server" CssClass="combo" placeholder="Estado" Width="200px" ></asp:DropDownList>
                <br />
                <asp:TextBox ID="txt_cantidad_ejemplares" runat="server" Width="200px" CssClass="cajas" placeholder="Cantidad de ejemplares"></asp:TextBox>
                <br />
                <asp:Button ID="bnt_prestamo" runat="server" Text="Registrar" CssClass="bton_consultar"  Width="73px"  />
                 <asp:Button ID="bnt_consultarp" runat="server" Text="Consultar" CssClass="bton_consultar"  />
          </center>
        </div>
    </form>
</body>
</html>
