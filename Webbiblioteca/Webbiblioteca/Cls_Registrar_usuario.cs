﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_Registrar_usuario
    {
        private string str_mensaje;
        Cls_Conexion objConexion = new Cls_Conexion();
        public void fnt_CrearU(string id, string Nombres, string apellidos, string Contacto, string Direccion, string Correo,  int estado)
        {
            if (id == "" || Nombres == "" || apellidos == "" || Contacto == "" || Direccion == "" || Correo == "")
            {
                str_mensaje = "Debe ingresar todos los datos de registro";
            }
            else
            {

                SqlCommand con = new SqlCommand("SP_Registrar_cliente", objConexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@PKid", id);
                con.Parameters.AddWithValue("@Nombres", Nombres);
                con.Parameters.AddWithValue("@Apellidos", apellidos);
                con.Parameters.AddWithValue("@Contacto", Contacto);
                con.Parameters.AddWithValue("@Direccion", Direccion);
                con.Parameters.AddWithValue("@Correo", Correo);
                con.Parameters.AddWithValue("@FKCodigo_tbl_estado", estado);
                objConexion.connection.Open();
                con.ExecuteNonQuery();
                objConexion.connection.Close();
                str_mensaje = "El libro" + Nombres + "de" + "" + apellidos + "fue registrado con exito";

            }
        }
        public string getMensaje() { return this.str_mensaje; }
    }
}