using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class tipoDAO
{
    public static List<tipo> ObtenerTodos()
    {
        string cadena = Resources.cadena_conexion;
        List<tipo> lista = new List<tipo>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT id, tipo FROM TIPO";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                { 
                    tipo tip = new tipo();
                    tip.id = Convert.ToInt32(reader["id"].ToString());
                    tip.tipe = reader["tipo"].ToString();
                    lista.Add(tip);
                }
            }

            connection.Close();
        }

        return lista;
    }
}