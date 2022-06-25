using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmPrestar : Form
{
    public prestamo Prestamo{ get; set;}
    public frmPrestar()
    {
        InitializeComponent();
    }

    private void frmPrestar_Load(object sender, EventArgs e)
    {
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
        txtID.Hide();
        int idem = Convert.ToInt32(txtID.Text);
        this.Prestamo = prestamoDAO.id_prestamo(Convert.ToInt32(txtID.Text));
        if (Prestamo == null)
        {
            pbReservar.Hide();
        }
        else
        {
            pbPrestar.Hide();
        }
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
   
   private void pbPrestar_Click(object sender, EventArgs e)
   {
       panel1.Show();
   }

   private void pbReservar_Click(object sender, EventArgs e)
   {
       panel2.Show();
   }

   private void button1_Click(object sender, EventArgs e)
   {
       textBox1.Text = dtpPrestamo.Text;
   }
   
}

