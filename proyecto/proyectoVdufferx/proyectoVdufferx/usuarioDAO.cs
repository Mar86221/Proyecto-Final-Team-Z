using System;
using System.Data.SqlClient;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx
{
    public static class usuarioDAO
    {
        public static bool CrearNuevo(usuario u)
        {
            bool exito = true;
            try {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena)){
                    string query = "INSERT INTO USUARIO (nombre,direccion,institucion,telefono,correo,id_ocupacion)VALUES" +
                                   " (@nombre, @direccion, @institucion,@telefono,@correo,@id_ocupacion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", u.nombre);
                    command.Parameters.AddWithValue("@direccion", u.direccion);
                    command.Parameters.AddWithValue("@institucion", u.institucion);
                    command.Parameters.AddWithValue("@telefono", u.telefono);
                    command.Parameters.AddWithValue("@correo", u.correo);
                    command.Parameters.AddWithValue("@id_ocupacion", u.id_ocupacion);
                    
                    
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception) {
                exito = false;
            }
            return exito;
        }
    }
}