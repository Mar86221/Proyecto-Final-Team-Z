using System;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx
{
    public static class Imagen_ejemplarDAO
    {
        public static bool CrearNuevo(Imagen_ejemplar ie)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "INSERT INTO IMAGEN_EJEMPLAR (imagen,id_ejemplar) VALUES" +
                        "(@imagen,@id_ejemplar)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@imagen", ie.imagen);
                    command.Parameters.AddWithValue("@id_ejemplar", ie.id_ejemplar);
                    
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
    }
}