using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmPrestar : Form
{
    public prestamo Prestamo{ get; set;}
    public reserva Reserva { get; set; }
    public frmPrestar()
    {
        InitializeComponent();
    }

    private void frmPrestar_Load(object sender, EventArgs e)
    {
        panelcorreo.Hide();
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
        using (SqlConnection connection = new SqlConnection(cadena))
        {
            string query =
                "SELECT id FROM USUARIO WHERE USUARIO.correo = @iduser";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@iduser", Convert.ToString(txtCorreousuario.Text));
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int idu = Convert.ToInt32(reader["id"].ToString());
                    txtIDu.AppendText(idu.ToString());
                }
            }

            connection.Close();
        }
        panel1.Hide();
        panel2.Hide();
        txtID.Hide();
        txtIDu.Hide();
        txtCorreoU.Hide();
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
       panelcorreo.Show();
   }

   private void pbReservar_Click(object sender, EventArgs e)
   {
       panel2.Show();
       panelcorreo.Show();
   }

   private void picOkPrestar_Click(object sender, EventArgs e)
   {
       string cadena = Resources.cadena_conexion;
       
       using (SqlConnection connection = new SqlConnection(cadena))
       {
           string query =
               "SELECT id FROM USUARIO WHERE USUARIO.correo = @iduser";

           SqlCommand command = new SqlCommand(query, connection);
           command.Parameters.AddWithValue("@iduser", Convert.ToString(txtCorreousuario.Text));
           connection.Open();
           using (SqlDataReader reader = command.ExecuteReader())
           {
               while (reader.Read())
               {
                   int idu = Convert.ToInt32(reader["id"].ToString());
                   txtIDu.AppendText(idu.ToString());
               }
           }

           connection.Close();
       }
       prestamo p = new prestamo();
       p.id_usuario = Convert.ToInt32(txtIDu.Text);
       p.id_ejemplar = Convert.ToInt32(txtID.Text);
       p.fecha_prestamo = Convert.ToDateTime(dtpPrestamo.Text + " " + cmbHorasPrestamo.Text + ":" + cmbMinPrestamo.Text);
       p.fecha_devolucion = Convert.ToDateTime(dtpDevolucionPrestamo.Text + " " + cmbHorDevPrestamo.Text + ":" + cmbMinDevPrest.Text);
       ////'06/25/2022 11:55'
       if (prestamoDAO.CrearNuevo(p))
       {
           MessageBox.Show("Prestamo realizado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }
       else
       {
           MessageBox.Show("Error de la base de datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       }
       
   }

   private void picOKReservar_Click(object sender, EventArgs e)
   {
       reserva r = new reserva();
       r.id_usuario = Convert.ToInt32(txtIDu.Text);
       r.id_ejemplar = Convert.ToInt32(txtID.Text);
       r.fecha_reserva = Convert.ToDateTime(dtpReserva.Text + " " + cmbHoraReserva.Text + ":" + cmbMinReserva.Text);
       r.fecha_devolucion = Convert.ToDateTime(dtpFechadevolucion.Text + " " + cmbHoradevReserva.Text + ":" + cmbMinDevReserva.Text);
       if (reservaDAO.CrearNuevo(r))
       {
           MessageBox.Show("Prestamo realizado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }
       else
       {
           MessageBox.Show("Error de la base de datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       }
   }
}

