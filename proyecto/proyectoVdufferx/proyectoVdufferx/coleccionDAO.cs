using System;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class coleccionDAO
{
    public static bool CrearNuevo(Coleccion C)
    {
        bool exito = true;
        try
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "INSERT INTO COLECCION (nombre, id_genero, id_tipo) VALUES (@nombre, @id_genero, @id_tipo)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", C.nombre);
                command.Parameters.AddWithValue("@id_genero", C.id_genero);
                command.Parameters.AddWithValue("@id_tipo", C.id_tipo);


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