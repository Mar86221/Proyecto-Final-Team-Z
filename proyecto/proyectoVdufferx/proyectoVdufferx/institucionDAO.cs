using System;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx
{
    public static class institucionDAO
    {
        public static bool CrearNuevo(institucion i)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "INSERT INTO INSTITUCION (institucion,id_ocupacion) VALUES" +
                        "(@institucion,@id_ocupacion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@institucion", i.ninstitucion);
                    command.Parameters.AddWithValue("@id_ocupacion", i.id_ocupacion);
                    
                    
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