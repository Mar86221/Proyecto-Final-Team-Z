using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class editorialDAO
{
    public static List<Editorial> ObtenerEditorial()
    {
        string cadena = Resources.cadena_conexion;
        List<Editorial> Lista = new List<Editorial>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT EDITORIAL.editorial FROM EDITORIAL";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Editorial edit = new Editorial();
                    edit.editorial = reader["editorial"].ToString();
                    
                    Lista.Add(edit);
                }
            }
            
            connection.Close();
        }

        return Lista;
    }
}