using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;


namespace proyectoVdufferx
{
    public class ejemplarDAO
    {
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
        
        public static List<Coleccion> ObtenerColecciones()
        {
            string cadena = Resources.cadena_conexion;
            List<Coleccion> lista = new List<Coleccion>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id,nombre  FROM COLECCION";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Coleccion coleccion = new Coleccion();
                        coleccion.id = Convert.ToInt32(reader["id"].ToString());
                        coleccion.nombre = reader["nombre"].ToString();
                        lista.Add(coleccion);
                    }
                }

                connection.Close();
            }
            return lista;
        }
        
        public static List<Editorial> ObtenerEditoriales()
        {
            string cadena = Resources.cadena_conexion;
            List<Editorial> lista = new List<Editorial>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id,editorial  FROM EDITORIAL";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Editorial editorial = new Editorial();
                        editorial.id = Convert.ToInt32(reader["id"].ToString());
                        editorial.editorial = reader["editorial"].ToString();
                        lista.Add(editorial);
                    }
                }

                connection.Close();
            }
            return lista;
        }
        
        public static List<Idioma> ObtenerIdiomas()
        {
            string cadena = Resources.cadena_conexion;
            List<Idioma> lista = new List<Idioma>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id,idioma  FROM IDIOMA";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Idioma idioma = new Idioma();
                        idioma.id = Convert.ToInt32(reader["id"].ToString());
                        idioma.idioma = reader["idioma"].ToString();
                        lista.Add(idioma);
                    }
                }

                connection.Close();
            }
            return lista;
        }

       

    }
}