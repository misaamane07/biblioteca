using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_estado_usuario
    {

        private DataTable dt;
        Cls_Conexion obj_conexion = new Cls_Conexion();
        public void fnt_Cargar_estado()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_Cargar_estado", obj_conexion.connection);
            dt = new DataTable();
            obj_conexion.connection.Open();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            //da.SelectCommand.Parameters.AddWithValue("@ot_cliente", txtot.Text);
            da.Fill(dt);
            obj_conexion.connection.Close();
        }
        public DataTable getEstado() { return this.dt; }
    }
}