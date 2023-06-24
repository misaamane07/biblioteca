using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_RegistrarSolicitudPrestamo
    {
        private string str_mensaje;
        Cls_Conexion objConexion = new Cls_Conexion();
        public void fnt_CrearU(string id, string Nombres, string isbn, string NombreL, string Autor, string Genero, int cantidadeje, int n_paginas)
        {
            if (id == "" || Nombres == "" || isbn == "" || NombreL == "" || Autor == "" || Genero == "")
            {
                str_mensaje = "Debe ingresar todos los datos de registro";
            }
            else
            {

                SqlCommand con = new SqlCommand("SP_Registrar_cliente", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@PKid", id);
                con.Parameters.AddWithValue("@Nombres", Nombres);
                con.Parameters.AddWithValue("@isbn", isbn);
                con.Parameters.AddWithValue("@Nombre", NombreL);
                con.Parameters.AddWithValue("@Autor", Autor);
                con.Parameters.AddWithValue("@Genero", Genero);
                con.Parameters.AddWithValue("@", n_paginas);
                con.Parameters.AddWithValue("@Cantidad_ejemplares", cantidadeje);
                objConexion.connection.Open();
                con.ExecuteNonQuery();
                objConexion.connection.Close();
                str_mensaje = "El " + Nombres + "con C.C" + "" + id + " su solicitud fue terminada con exito";

            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
}