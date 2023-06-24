using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_ConsulatUsuario
    {
        private string str_id;
        private string str_nombres;
        private string str_apellidos;
        private string str_contacto;
        private string str_direccion;
        private string str_correo;
        private int int_estado;
        private string str_msn;
        SqlCommand con; SqlDataReader lectura;
        Cls_Conexion objconexion = new Cls_Conexion();
        public void fnt_ConsultarL(string isnb)
        {
            {
                con = new SqlCommand("SP_ConsultarUsuario", objconexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", isnb);
                objconexion.connection.Open();
                lectura = con.ExecuteReader();
                if (lectura.Read() == true)
                {
                    str_nombres = Convert.ToString(lectura[0]);
                    str_apellidos = Convert.ToString(lectura[1]);
                    str_contacto = Convert.ToString(lectura[2]);
                    str_direccion = Convert.ToString(lectura[3]);
                    str_correo = Convert.ToString(lectura[4]);
                    int_estado = Convert.ToUInt16(lectura[5]);
                    objconexion.connection.Close();
                    str_msn = "";
                }
            }
        }
        public string getNombre() { return this.str_nombres; }
        public string getApellido() { return this.str_apellidos; }
        public string getContacto() { return this.str_contacto; }
        public string getDireccion() { return this.str_direccion; }
        public string getcorreo() { return this.str_correo; }
        public int getEstado() { return this.int_estado; }
    
    }
}