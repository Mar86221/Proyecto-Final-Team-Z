using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class prestamoDAO
{
    
    
    public static bool CrearNuevo(prestamo p)
    {
        bool exito = true;
        try
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection())
            {
                string query = "INSERT INTO PRESTA (id_usuario, id_ejemplar, fecha_prestamo, fecha_devolucion)VALUES" +
                               "(@id_usuario, @id_ejemplar, @fecha_prestamo, @fecha_devolucion)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_usuario", p.id_usuario);
                command.Parameters.AddWithValue("@id_ejemplar", p.id_ejemplar);
                command.Parameters.AddWithValue("@fecha_prestamo", p.fecha_prestamo);
                command.Parameters.AddWithValue("@fecha_devolucion", p.fecha_devolucion);
                
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