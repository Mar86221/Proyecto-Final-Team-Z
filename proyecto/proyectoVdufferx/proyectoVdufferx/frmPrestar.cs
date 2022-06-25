using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmPrestar : Form
{
    public frmPrestar()
    {
        InitializeComponent();
    }

    private void frmPrestar_Load(object sender, EventArgs e)
    {
        pbReservar.Hide();
        txtID.Hide(); 
        int idejem = Convert.ToInt32(txtID.Text);
        id_prestamo(idejem);

        string cadena = Resources.cadena_conexion;
        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT EJEMPLAR.id, IMAGEN_EJEMPLAR.imagen,AUTOR.nombre_autor, EDITORIAL.editorial,COLECCION.nombre,EJEMPLAR.etiqueta FROM IMAGEN_EJEMPLAR INNER JOIN EJEMPLAR ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id INNER JOIN EJEMPLARXAUTOR ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id INNER JOIN AUTOR ON EJEMPLARXAUTOR.id_autor = AUTOR.id INNER JOIN EDITORIAL ON EDITORIAL.id = EJEMPLAR.id_editorial INNER JOIN COLECCION ON COLECCION.id = EJEMPLAR.id_coleccion where EJEMPLAR.nombre = @ejemplar";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ejemplar", Convert.ToString(txtNombreEjemplar.Text));
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    string nombre_autor = reader["nombre_autor"].ToString();
                    string editorial = reader["editorial"].ToString();
                    string coleccion = reader["nombre"].ToString();
                    string isbm = reader["etiqueta"].ToString();
                    
                    txtID.AppendText(id.ToString());
                    txtAutorEjemplar.AppendText(nombre_autor);
                    txtEditorial.AppendText(editorial);
                    txtColeccionEjemplar.AppendText(coleccion);
                    txtIsbm.AppendText(isbm);
                }
            }

            connection.Close();
        }
        panel1.Hide();
        panel2.Hide();
    }

   /* using (SqlConnection connection = new SqlConnection(cadena))
    {
        string query = "SELECT nombre,telefono,fotografia FROM USUARIO where correo = @correobuscado";
        SqlCommand command = new SqlCommand(query, connection);
        command.Parameters.AddWithValue("@correobuscado", Convert.ToString(txtTucuentaCorreo.Text));

        connection.Open();
        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                string nombre = reader["nombre"].ToString();
                string telefono = reader["telefono"].ToString();
                string fotografia = reader["fotografia"].ToString();

                txtTucuentaNombre.AppendText(nombre);
                txtTucuentaTelefono.AppendText(telefono);
                txtTucuentaFotografia.AppendText(fotografia);
            }

            connection.Close();
        }*/
   
      public static prestamo id_prestamo(int id)
           {
               string cadena = Resources.cadena_conexion;
               prestamo p = null;
               using (SqlConnection connection = new SqlConnection(cadena))
               {
                   string query = "SELECT id_ejemplar FROM PRESTA INNER JOIN EJEMPLAR ON PRESTA.id_ejemplar = @idejemplar";
                   SqlCommand command = new SqlCommand(query, connection);
                   command.Parameters.AddWithValue("@idejemplar", id);
   
                   connection.Open();
                   using (SqlDataReader reader = command.ExecuteReader())
                   {
                       while (reader.Read())
                       {
                           p = new prestamo();
                           p.id_ejemplar = Convert.ToInt32(reader["id_ejemplar"]);
                       }
                       connection.Close();
                   }
               }
               return p;
           }

   private void pbPrestar_Click(object sender, EventArgs e)
   {
       
   }
}