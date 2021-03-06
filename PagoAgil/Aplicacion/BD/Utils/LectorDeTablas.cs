﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgil.Aplicacion.BD
{
    public class LectorDeTablas
    {

        private static LectorDeTablas instance = new LectorDeTablas();

        public static LectorDeTablas getInstance()
        {
            return instance;
        }

        private LectorDeTablas()
        {
        }

        public DataTable obtenerMejorado(String funcion)
        {

            return this.prepararTabla("SELECT * FROM SQL_BOYS." + funcion);

        }

        public DataTable obtenerCiertasColumnas(String query, string[] columnasAMostrar)
        {

            DataTable dt = this.obtenerMejorado(query);

            DataTable dt2 = new DataView(dt).ToTable(false, columnasAMostrar);

            return dt2;

        }

        public DataTable obtenerCiertasColumnas(string query, List<string> columnasElectas)
        {
            return this.obtenerCiertasColumnas(query, columnasElectas.ToArray());
        }

        public DataTable obtenerCiertasColumnasOrdenadas(String query, string[] columnasAMostrar, Boolean ascendente)
        {

            DataTable dt = this.obtenerCiertasColumnas(query, columnasAMostrar);

            string tipoDeOrden = ascendente ? "asc" : "desc";

            dt.DefaultView.Sort = columnasAMostrar[0] + " " + tipoDeOrden;

            return dt;

        }

        public DataTable obtenerCiertasColumnasOrdenadas(string query, List<string> columnasElectas, Boolean ascendente)
        {
            return this.obtenerCiertasColumnasOrdenadas(query, columnasElectas.ToArray(), ascendente);
        }

        private DataTable prepararTabla(String query)
        {

            SqlCommand comando = new SqlCommand(query, Conexion.getInstance().obtenerConexion());

            SqlDataReader reader = comando.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(reader);

            return dt;

        }

        /* ⇊ DEPRECADO ⇊ */

        [System.Obsolete("obtener() esta deprecado. Utilizá obtenerMejorado().")]
        public TablaDTO obtener(String query)
        {

            SqlCommand comando = new SqlCommand(query, Conexion.getInstance().obtenerConexion());

            SqlDataReader reader = comando.ExecuteReader();

            return this.obtenerTabla(reader);

        }

        [System.Obsolete]
        private TablaDTO obtenerTabla(SqlDataReader reader)
        {

            TablaDTO tablaADevolver = new TablaDTO();

            while (reader.Read())
            {
                
                tablaADevolver.agregarFila(this.obtenerFila(reader));

            }

            reader.Close();

            return tablaADevolver;
        }

        [System.Obsolete]
        private FilaDTO obtenerFila(SqlDataReader reader)
        {
            FilaDTO filaADevolver = new FilaDTO();

            int columnas = reader.FieldCount;

            for (int i = 0; i < columnas; i++)
            {

                filaADevolver.agregarElemento(reader.GetValue(i).ToString());

            }

            return filaADevolver;
        }

    }
}
