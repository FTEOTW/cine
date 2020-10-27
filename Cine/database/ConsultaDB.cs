using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace Cine.database
{
    class ConsultaDB
    {
        private string consulta;
        private string error;
        private bool ejecucion;
        private DataTable GetTable;
        private SqlDataReader dataReader;

        public SqlDataReader pDataReader
        {
            get { return dataReader; }
            set { this.dataReader = value; }
        }

        public DataTable pGetTable
        {
            get { return GetTable; }
            set { GetTable = value; }
        }

        public bool Pejecucion
        {
            get { return ejecucion; }
            set { ejecucion = value; }
        }

        // Esta clase es la encargada de ejecutar las consultas en la BD
        //previamente hecha la conexion
        public string Perror
        {
            get { return error; }
            set { error = value; }
        }

        public string Pconsulta
        {
            get { return consulta; }
            set { consulta = value; }
        }

        public ConsultaDB(string consulta)
        {
            this.consulta = consulta;
        }
        public ConsultaDB()
        {
        }

        public bool ejecutarConsulta(string consulta, int tipo)
        {
            try
            {
                ejecucion = true;
                ConexionDB conexionDB = new ConexionDB();
                conexionDB.Conexion_hoy();
                if (tipo == 1)//get table
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexionDB.Pconn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    this.GetTable = dataTable;
                }
                else
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = ConexionDB.conn;
                    com.CommandText = consulta;
                    com.ExecuteNonQuery();
                }
            }
            catch (Exception ec)
            {
                ejecucion = false;
                this.error = ec.Message;
                throw;
            }
            return ejecucion;
        }
    }
}
