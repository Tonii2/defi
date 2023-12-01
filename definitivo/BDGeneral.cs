using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace definitivo
{
    public class BDGeneral
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=pou;Data Source=LAPTOP-RHMTR2G9\\SQLEXPRESS;TrustServerCertificate=True");
            conexion.Open();

            return conexion;
        }
    }
}
