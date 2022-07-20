using System;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class reservaDAO
{
    public static bool CrearNuevo(reserva r)
    {
        bool exito = true;
        try
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "INSERT INTO RESERVA (id_usuario, id_ejemplar, fecha_reserva, fecha_devolucion)VALUES" +
                               "(@id_usuario, @id_ejemplar, @fecha_reserva, @fecha_devolucion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_usuario", r.id_usuario);
                command.Parameters.AddWithValue("@id_ejemplar", r.id_ejemplar);
                command.Parameters.AddWithValue("@fecha_reserva", r.fecha_reserva);
                command.Parameters.AddWithValue("@fecha_devolucion", r.fecha_devolucion);
                
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