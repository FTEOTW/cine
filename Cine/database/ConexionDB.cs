using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine.database
{
    class ConexionDB
    {
        public static SqlConnection conn = null;
        public SqlConnection Pconn
        {
            get { return conn; }
            set { conn = value; }
        }

        public void Conexion_hoy()
        {
            //Esta clase es la encargada de crear la conexion de la aplicacion con la DB
            //para usar el programa en otra pc hay que cambiar estos parametros:
            //Data Source = indica en donde esta montado el servidor
            //Initial Catalog = indica el nombre de la base de datos
            if (conn == null)
            {
                conn = new SqlConnection(
                    "Data Source=LAPTOP-KACP1EFJ\\EAVILASQL;" +
                    "Initial Catalog=CINE;" +
                    "Integrated Security=SSPI");
                conn.Open();
            }
        }
    }
}
