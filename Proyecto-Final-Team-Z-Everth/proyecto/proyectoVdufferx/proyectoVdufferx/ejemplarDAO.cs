using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx
{
    public class ejemplarDAO
    {
        public static List<ejemplar> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplar> lista = new List<ejemplar>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT * FROM EJEMPLAR";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ejemplar ejemplar = new ejemplar();
                        ejemplar.etiqueta = reader["etiqueta"].ToString();
                        ejemplar.nombre = reader["nombre"].ToString();
                        ejemplar.Palabras_claves = reader["Palabras_claves"].ToString();
                        ejemplar.fecha_publicacion = reader["fecha_publicacion"].ToString();
                        ejemplar.id_coleccion = Convert.ToInt32(reader["id_coleccion"].ToString());
                        ejemplar.id_editorial = Convert.ToInt32(reader["id_editorial"].ToString());
                        ejemplar.id_idioma = Convert.ToInt32(reader["id_idioma"].ToString());
                        ejemplar.id_formato = Convert.ToInt32(reader["id_formato"].ToString());
                        lista.Add(ejemplar);
                    }
                }

                connection.Close();
            }

            return lista;
        }

        public static List<autor> ObtenerAutores()
        {
            string cadena = Resources.cadena_conexion;
            List<autor> lista = new List<autor>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id,nombre_autor FROM AUTOR";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        autor au = new autor();
                        au.id = Convert.ToInt32(reader["id"].ToString());
                        au.nombre_autor = reader["nombre_autor"].ToString();
                        lista.Add(au);
                    }
                }

                connection.Close();
            }

            return lista;

        }
    }
}