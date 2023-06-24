using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Webbiblioteca
{
    public class Cls_Conexion
    {
        public SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CJCGVNT\\LEON;Initial Catalog=dbs_biblioteca;Integrated Security=True");
    }
}