using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Documents;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class coleccionDAO
{
    public static List<coleccionmain> ObtenerTodos()
    {
        string cadena = Resources.cadena_conexion;
        List<coleccionmain> Lista = new List<coleccionmain>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT COLECCION.nombre, GENERO.genero, TIPO.tipo FROM COLECCION, GENERO, TIPO WHERE COLECCION.id_genero = GENERO.id AND COLECCION.id_tipo = TIPO.id;";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    coleccionmain collect = new coleccionmain();
                    collect.nombre = reader["nombre"].ToString();
                    collect.genero = reader["genero"].ToString();
                    collect.tipo = reader["tipo"].ToString();
                    
                    Lista.Add(collect);
                }
            }
            connection.Close();
        }

        return Lista;
    }




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