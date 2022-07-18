using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class idiomaDAO
{
    public static List<Idioma> ObtenerIdioma()
    {
        string cadena = Resources.cadena_conexion;
        List<Idioma> Lista = new List<Idioma>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT IDIOMA.idioma FROM IDIOMA";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Idioma idiom = new Idioma();
                    idiom.idioma = reader["idioma"].ToString();
                    
                    Lista.Add(idiom);
                }
            }
            
            connection.Close();
         
        }

        return Lista;
    }
}