using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class generoDAO
{
    public static List<genero> ObtenerTodos()
    {
        string cadena = Resources.cadena_conexion;
        List<genero> lista = new List<genero>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT id, genero FROM GENERO";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                { 
                    genero gen = new genero();
                    gen.id = Convert.ToInt32(reader["id"].ToString());
                    gen.genrer = reader["genero"].ToString();
                    lista.Add(gen);
                }
            }

            connection.Close();
        }

        return lista;
    }
}