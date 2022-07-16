using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }


        public void picTucuenta_Click(object sender, EventArgs e)
        {
            if (txtTucuentaNombre.Text.Length > 0)
            {
                grpTuCuenta.Show();
            }
            else
            {
                grpTuCuenta.Show();
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
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
                    }

                    PicTuCuentaDatos.ImageLocation = txtTucuentaFotografia.Text;
                }
            }

        }

        private void MAIN_Load(object sender, EventArgs e)
        {
            grpTuPrestamo.Hide();
            grpTuCuenta.Hide();
            txtTucuentaFotografia.Hide();
            
           
            
          
        }


        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            frmEjemplares otraventana = new frmEjemplares();
            otraventana.txtCorreoEj.Text = txtTucuentaCorreo.Text;//////////////////////////////////
            otraventana.Show();
        }

        private void picTucuenta_DoubleClick(object sender, EventArgs e)
        {
            grpTuCuenta.Hide();
        }

        private void MAIN_Click(object sender, EventArgs e)
        {
            grpTuPrestamo.Hide();
            grpTuCuenta.Hide();
        }

        private void picTuprestamo_Click(object sender, EventArgs e)
        {
            if (txtTuprestamoNombreE.Text.Length > 0)
            {
                grpTuPrestamo.Show();
            }
            else{
                grpTuPrestamo.Show();
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "SELECT EJEMPLAR.nombre,PRESTA.fecha_devolucion,PRESTA.fecha_prestamo FROM USUARIO INNER JOIN PRESTA ON USUARIO.id = PRESTA.id_usuario INNER JOIN EJEMPLAR ON EJEMPLAR.id = PRESTA.id_ejemplar WHERE USUARIO.correo = @correobuscado2";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@correobuscado2", Convert.ToString(txtTucuentaCorreo.Text));

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre_ejemplar = reader["nombre"].ToString();
                            string fecha_prestamo = reader["fecha_prestamo"].ToString();
                            string fecha_devolucion = reader["fecha_devolucion"].ToString();

                            txtTuprestamoNombreE.AppendText(nombre_ejemplar + " :" );
                            txtTuprestamoFechaP.AppendText(fecha_prestamo + " :");
                            txtTuprestamoFechaD.AppendText(fecha_devolucion + " :");
                        }

                        connection.Close();
                    }
                }
            }
        }


        private void picTuprestamo_DoubleClick(object sender, EventArgs e)
        {
            grpTuPrestamo.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmEventos frev = new frmEventos();
            frev.txtCuentaU.Text = txtTucuentaCorreo.Text;
            frev.Show();

        }
    }
}