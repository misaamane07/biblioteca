<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webconsultaconprestamos.aspx.cs" Inherits="Webbiblioteca.Webconsultaconprestamos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Solicita tu libro</title>
</head>
            
<body>
    <a href="#">Inicio</a>
    <a href="#">Registrate</a>
    <a href="#">Consultar libro</a>
    <br />

           <Center><h1>Has tu solicitud</h1></Center>
 <br />
     
    <form id="form1" runat="server">
        <div>
           <center> <h2>Consulta usuario</h2></center>
         <center>  <asp:TextBox ID="txt_idp" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese su identificacion"></asp:TextBox>
            <asp:TextBox ID="txt_nombrep" runat="server" Width="200px" CssClass="cajas" placeholder=""></asp:TextBox>
             <br />
             <br />
            <asp:Button ID="bnt_consultarLibro" runat="server" Text="Consultar" CssClass="bton_consultar"  /></center> 
        </div>
        <div class="div2">
            <center> <h2>Consulta Libro</h2></center>
         <center>  <asp:TextBox ID="txt_isbn" runat="server" Width="200px" CssClass="cajas" placeholder="Ingrese el isbn"></asp:TextBox>
                    <asp:TextBox ID="txt_nombrelibro" runat="server" Width="200px" CssClass="cajas" placeholder="ISBN"></asp:TextBox>
             <br />
                   <asp:TextBox ID="txt_autor" runat="server" Width="200px" CssClass="cajas" placeholder="Autor"></asp:TextBox>
                   <asp:TextBox ID="txt_genero" runat="server" Width="200px" CssClass="cajas" placeholder="Genero"></asp:TextBox>
             <br />
              
                   <asp:TextBox ID="txt_cantidad_ejem" runat="server" Width="200px" CssClass="cajas" placeholder="Cantidad Ejemplares"></asp:TextBox>
                   <asp:TextBox ID="txt_n_paginas" runat="server" Width="200px" CssClass="cajas" placeholder="Numero de paginas"></asp:TextBox>
             <br />
                    
             <br />
            <asp:Button ID="Button1" runat="server" Text="Consultar" CssClass="bton_consultar"  />
            <asp:Button ID="Registrar" runat="server" Text="Registrar" CssClass="bton_consultar"  /></center>
        </div>
    </form>
</body>
</html>
