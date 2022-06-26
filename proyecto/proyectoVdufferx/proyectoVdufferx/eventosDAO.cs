using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public class eventosDAO
{
    public static bool CrearNuevo(eventos e)
    {
        bool exito = true;
        try
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "INSERT INTO EVENTO (imagen, titulo, cant_asistentes, fecha_inicio, fecha_final, id_area) VALUES (@imagen, @titulo, @cant_asistentes, @fecha_inicio, @fecha_final, @id_area)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@imagen", e.imagen);
                command.Parameters.AddWithValue("@titulo", e.titulo);
                command.Parameters.AddWithValue("@cant_asistentes", e.cant_asistentes);
                command.Parameters.AddWithValue("@fecha_inicio", e.fecha_inicio);
                command.Parameters.AddWithValue("@fecha_final", e.fecha_final);
                command.Parameters.AddWithValue("@id_area", e.id_area);


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
    public static List<eventomain> ObtenerTodos()
    {
        string cadena = Resources.cadena_conexion;
        List<eventomain> listaev = new List<eventomain>();

        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT EVENTO.imagen, EVENTO.titulo, EVENTO.cant_asistentes, EVENTO.fecha_inicio, EVENTO.fecha_final, AREA.nombre  FROM EVENTO INNER JOIN AREA ON EVENTO.id_area = AREA.id";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                { 
                    string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Eventos\" + reader["imagen"].ToString();
                    eventomain evento = new eventomain();
                    evento.imagen = ruta;
                    evento.titulo = reader["titulo"].ToString();
                    evento.cant_asistentes = Convert.ToInt32(reader["cant_asistentes"].ToString());
                    evento.fecha_inicio = Convert.ToDateTime(reader["fecha_inicio"].ToString());
                    evento.fecha_final = Convert.ToDateTime(reader["fecha_final"].ToString());
                    evento.nombre = reader["nombre"].ToString();
                    listaev.Add(evento);
                }
            }

            connection.Close();
        }

        return listaev;
    }

}