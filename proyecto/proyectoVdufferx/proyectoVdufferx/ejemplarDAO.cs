using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;


namespace proyectoVdufferx
{
    public class ejemplarDAO
    {

        public static bool CrearNuevo(ejemplar ej)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "INSERT INTO EJEMPLAR (nombre, Palabras_claves, fecha_publicacion, id_coleccion, id_editorial, id_idioma, id_formato, etiqueta)  VALUES  (@nombre,@Palabras_claves, @fecha_publicacion,@id_coleccion,@id_editorial,@id_idioma,@id_formato,@etiqueta)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", ej.nombre);
                    command.Parameters.AddWithValue("@Palabras_claves", ej.Palabras_claves);
                    command.Parameters.AddWithValue("@fecha_publicacion", ej.fecha_publicacion);
                    command.Parameters.AddWithValue("@id_coleccion", ej.id_coleccion);
                    command.Parameters.AddWithValue("@id_editorial", ej.id_editorial);
                    command.Parameters.AddWithValue("@id_idioma", ej.id_idioma);
                    command.Parameters.AddWithValue("@id_formato", ej.id_formato);
                    command.Parameters.AddWithValue("@etiqueta", ej.etiqueta);
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception)
            {
                exito = false;
            }

            return exito;
        }
        
        
        public static List<ejemplarmain> ObtenerTodos()
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplarmain> lista = new List<ejemplarmain>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor  FROM IMAGEN_EJEMPLAR INNER JOIN EJEMPLAR ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id INNER JOIN EJEMPLARXAUTOR ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id INNER JOIN AUTOR ON EJEMPLARXAUTOR.id_autor = AUTOR.id";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Libros\" + reader["imagen"].ToString();
                        ejemplarmain ejemplarm = new ejemplarmain();
                        ejemplarm.imagen = ruta;
                        ejemplarm.nombre = reader["nombre"].ToString();
                        ejemplarm.nombre_autor = reader["nombre_autor"].ToString();
                        lista.Add(ejemplarm);
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
        
        public static List<formato> ObtenerFormatos()
        {
            string cadena = Resources.cadena_conexion;
            List<formato> lista = new List<formato>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id,formato FROM FORMATO";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        formato formato = new formato();
                        formato.id = Convert.ToInt32(reader["id"].ToString());
                        formato.Formato = reader["formato"].ToString();
                        lista.Add(formato);
                    }
                }

                connection.Close();
            }

            return lista;

        }
       
       

    }
}