using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_consultaLibro
    {
        private string str_nombre;
        private string str_autor;
        private string str_editoreal;
        private int int_N_paginas;
        private string str_genero;
        private string str_fecha;
        private int int_estado;
        private int int_Cantidad_ejem;
        private string str_msn;
        SqlCommand con; SqlDataReader lectura;
        Cls_Conexion objconexion = new Cls_Conexion();
        public void fnt_ConsultarL(string isnb) 
        {
            {
                con = new SqlCommand("SP_ConsultarLibro", objconexion.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@isbn", isnb);
                objconexion.connection.Open();
                lectura = con.ExecuteReader();
                if (lectura.Read()== true)
                {
                    str_nombre = Convert.ToString(lectura[0]);
                    str_autor = Convert.ToString(lectura[1]);
                    str_editoreal = Convert.ToString(lectura[2]);
                    int_N_paginas = Convert.ToInt16(lectura[3]);
                    str_genero = Convert.ToString(lectura[4]);
                    str_editoreal = Convert.ToString(lectura[5]);
                   
                    int_estado = Convert.ToInt16(lectura[6]);
                    int_Cantidad_ejem = Convert.ToInt16(lectura[7]);
                    objconexion.connection.Close();
                    str_msn = "";
                }
            }
        }
        public string getNombre() { return this.str_nombre; }
        public string getAutor() { return this.str_autor; }
        public string getEditoreal() { return this.str_editoreal; }
        public int getPaginas() { return this.int_N_paginas; }
        public string getFecha() { return this.str_fecha; }
        public string getgenero() { return this.str_genero; }
        public string geteditoreal() { return this.str_editoreal; }
        public int getCantidadEjem() { return this.int_Cantidad_ejem; }
        public int getesatdo() { return this.int_estado; }

    }
}

