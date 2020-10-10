﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Cine
{
    class DataBase
    {
        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader dr;
        DataTable dt;
        string cadenaConexion;

        public OleDbDataReader pDr
        {
            get { return dr; }
            set { dr = value; }
        }

        public DataBase(string cadenaConexion)
        {
            conexion = new OleDbConnection();
            comando = new OleDbCommand();
            dr = null;
            dt = new DataTable();
            this.cadenaConexion = cadenaConexion;
        }
        public void conectar()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void desconectar()
        {
            conexion.Close();
        }
        public DataTable consultarTabla(string nombreTabla)
        {
            dt = new DataTable();
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            dt.Load(comando.ExecuteReader());
            desconectar();
            return dt;
        }
        public void leerTabla(string nombreTabla)
        {
            conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla;
            dr = comando.ExecuteReader();
        }
        public void actualizar(string consultaSql)
        {
            conectar();
            comando.CommandText = consultaSql;
            comando.ExecuteNonQuery();
            desconectar();
        }
    }
}