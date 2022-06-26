using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class areaDAO
{
    public static List<area> ObtenerTodos()
    {
        string cadena = Resources.cadena_conexion;
        List<area> lista = new List<area>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT id, nombre FROM AREA";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                { 
                    area are = new area();
                    are.id = Convert.ToInt32(reader["id"].ToString());
                    are.nombre = reader["nombre"].ToString();
                    lista.Add(are);
                }
            }

            connection.Close();
        }

        return lista;
    }
}