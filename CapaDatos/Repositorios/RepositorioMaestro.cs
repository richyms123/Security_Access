using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorios
{
    public class RepositorioMaestro : RepositorioConexion
    {
        protected List<SqlParameter> parametrosSql;
        protected int ExecuteNonQuery(string querySql)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(querySql, conexion))
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = querySql;
                    foreach (SqlParameter parametro in parametrosSql)
                    {
                        comando.Parameters.Add(parametro);
                    }
                    int filasAfectadas = comando.ExecuteNonQuery();
                    parametrosSql.Clear();
                    return filasAfectadas;
                }
            }
        }

        protected object ExecuteScalar(string querySql)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(querySql, conexion))
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = querySql;
                    foreach (SqlParameter parametro in parametrosSql)
                    {
                        comando.Parameters.Add(parametro);
                    }
                    object valor = comando.ExecuteScalar();
                    parametrosSql.Clear();
                    return valor;
                }
            }
        }

        protected DataTable ExecuteReader(string querySql)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(querySql, conexion))
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = querySql;

                    SqlDataReader lector = comando.ExecuteReader();
                    using (DataTable tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }

        protected DataTable ExecuteReaderParametros(string querySql)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(querySql, conexion))
                {
                    comando.Connection = conexion;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = querySql;
                    foreach (SqlParameter parametro in parametrosSql)
                    {
                        comando.Parameters.Add(parametro);
                    }
                    SqlDataReader lector = comando.ExecuteReader();
                    using (DataTable tabla = new DataTable())
                    {
                        tabla.Load(lector);
                        lector.Dispose();
                        return tabla;
                    }
                }
            }
        }
    }
}
