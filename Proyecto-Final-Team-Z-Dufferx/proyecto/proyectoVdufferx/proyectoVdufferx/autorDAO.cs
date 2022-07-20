using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class autorDAO
{
    public static List<autor> ObtenerTodos()
    {
        string cadena = Resources.cadena_conexion;
        List<autor> lista = new List<autor>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT AUTOR.nombre_autor FROM AUTOR";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    autor au = new autor();
                    au.nombre_autor = reader["nombre_autor"].ToString();
                    lista.Add(au);
                }
            }

            connection.Close();
        }

        return lista;
    }
}