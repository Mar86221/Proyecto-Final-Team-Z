using System;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        

        public void MAIN_Load(object sender, EventArgs e)
        {
            grpTuCuenta.Hide();
            txtTucuentaFotografia.Hide();
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            frmEjemplares otraventana = new frmEjemplares();
            otraventana.ShowDialog();
        }

        private void picTucuenta_DoubleClick(object sender, EventArgs e)
        {
            grpTuCuenta.Hide();
        }
    }
}