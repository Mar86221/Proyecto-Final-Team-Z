using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class formatoDAO
{
    public static List<formato> ObtenerFormato()
    {
        string cadena = Resources.cadena_conexion;
        List<formato> Lista = new List<formato>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT  FORMATO.formato FROM FORMATO";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    formato frm = new formato();
                    frm.Formato = reader["formato"].ToString();
                    
                    Lista.Add(frm);
                }
            }
            
            connection.Close();
        }

        return Lista;
    }
}