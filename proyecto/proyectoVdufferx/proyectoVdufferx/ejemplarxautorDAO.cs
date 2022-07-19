using System;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class ejemplarxautorDAO
{
    public static bool CrearNuevo(ejemplarxautor ejxa)
    {
        bool exito = true;
        try
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "INSERT INTO EJEMPLARXAUTOR (id_ejemplar, id_autor) VALUES (@id_ejemplar, @id_autor)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_ejemplar", ejxa.id_ejemplar);
                command.Parameters.AddWithValue("@id_autor", ejxa.id_autor);

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