using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_actualizarlibro
    {
        private string str_mensaje;
        Cls_Conexion objConexion = new Cls_Conexion();
        public void fnt_Actualizar(string isbn, string Nombre, string autor, string editoreal, int N_paginas, string genero, string fecha_p, int estado, int Cantidad_ejem)
        {
            if (isbn == "" || Nombre == "" || autor == "" || editoreal == "" || genero == "" || fecha_p == "")
            {
                str_mensaje = "Debe ingresar todos los datos de registro";
            }
            else
            {

                SqlCommand con = new SqlCommand("SP_ActualizarLibro", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@isbn", isbn);
                con.Parameters.AddWithValue("@Nombre", Nombre);
                con.Parameters.AddWithValue("@Autor", autor);
                con.Parameters.AddWithValue("@Editoreal", editoreal);
                con.Parameters.AddWithValue("@N_paginas", N_paginas);
                con.Parameters.AddWithValue("@Genero", genero);
                con.Parameters.AddWithValue("@fecha", fecha_p);
                con.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
                con.Parameters.AddWithValue("@Cantidad_ejemplares", Cantidad_ejem);
                objConexion.connection.Open();
                con.ExecuteNonQuery();
                objConexion.connection.Close();
                str_mensaje = "El libro" + Nombre + "de" + "" + autor + "fue actualizado con exito";

            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
}