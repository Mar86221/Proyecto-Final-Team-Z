using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmEjemplarEditar : Form
{
    public frmEjemplarEditar()
    {
        InitializeComponent();
    }

    private void picEditarEjemplar_Click(object sender, EventArgs e)
    {
        static bool ActualizarEjemplar(ejemplar ejemplar)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "UPDATE EJEMPLAR" +
                                   "SET nombre = @nuevonombre, Palabras_claves = @nuevaspalabrasclaves" +
                                   "WHERE EJEMPLAR.id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nuevonombre", ejemplar.nombre);
                    command.Parameters.AddWithValue("@nuevaspalabrasclaves", ejemplar.Palabras_claves);
                    command.Parameters.AddWithValue("@id", ejemplar.id);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                exito = false;
            }

            return exito;
        }

        ejemplar ejemplar = new ejemplar();
        ejemplar.id = Convert.ToInt32(txtIdEliminarE.Text);
        ejemplar.nombre = txtNombreE.Text;
        ejemplar.Palabras_claves = TxtPalabrasClavesE.Text;

        ActualizarEjemplar(ejemplar);
        /*  {
              MessageBox.Show("Actualizada con exito");
          }
          else
          {
              MessageBox.Show("Ha ocurrido un error");
          }*/
    }
}