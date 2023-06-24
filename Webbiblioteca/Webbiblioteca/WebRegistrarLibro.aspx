<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebRegistrarLibro.aspx.cs" Inherits="Webbiblioteca.WebRegistrase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   
    <title>Registra tu Libro</title>
     <link rel="stylesheet" href="estilos.css" type="text/css" />
</head>
<body class="body">
    <form id="form1" runat="server">
           <sesion class="nav">    
           <a href="#">Inicio</a>
           <a href="#">Registrate</a>
           <a href="#">Consultar libro</a>
               <a href="#">¨Solicitar Prestamo de Libro</a> 
        <center>
             <div class="div2">
                     <center> <h1>Registro de libros</h1></center>
                
                <asp:TextBox ID="txt_isbn" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese el ISBN del libro"></asp:TextBox>
                 <br />
                <asp:TextBox ID="txt_nombre_libro" runat="server" Width="200px" CssClass="cajas" placeholder="Nombre del libro"></asp:TextBox>
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
                <asp:Button ID="bnt_registrarse1" runat="server" Text="Registrar" CssClass="bton_consultar" OnClick="bnt_registrarse_Click" Width="73px"  />
                 <asp:Button ID="bnt_consultarLibro" runat="server" Text="Consultar" CssClass="bton_consultar" OnClick="Button1_Click" />
                 <asp:Button ID="bnt_actualizar" runat="server" Text="Actualizar" CssClass="bton_consultar" OnClick="bnt_actualizar_Click" />
               </div>
               
               
               </center>
            

                        

              
        
        
    </form>
</body>
</html>
