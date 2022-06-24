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
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "INSERT INTO USUARIO (nombre,direccion,id_institucion,telefono,correo, fotografia)VALUES" +
                        " (@nombre, @direccion, @id_institucion,@telefono,@correo,@fotografia)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", u.nombre);
                    command.Parameters.AddWithValue("@direccion", u.direccion);
                    command.Parameters.AddWithValue("@id_institucion", u.id_institucion);
                    command.Parameters.AddWithValue("@telefono", u.telefono);
                    command.Parameters.AddWithValue("@correo", u.correo);
                    command.Parameters.AddWithValue("fotografia", u.fotografia);


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

        public static usuario BuscarCorreoU(string correo)
        {
            string cadena = Resources.cadena_conexion;
            usuario u = null;

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT correo FROM USUARIO " + "WHERE correo = @correo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@correo", correo);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        u = new usuario();
                        u.correo = reader["correo"].ToString();
                    }
                }
                connection.Close();
            }

            return u;
        }
}
}