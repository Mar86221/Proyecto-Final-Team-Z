using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmEditarColeccion : Form
{
    public frmEditarColeccion()
    {
        InitializeComponent();
    }

    private void frmEditarColeccion_Load(object sender, EventArgs e)
    {
        cmbGeneroEdit.DataSource = null;
        cmbGeneroEdit.ValueMember = "id";
        cmbGeneroEdit.DisplayMember = "genrer";
        cmbGeneroEdit.DataSource = generoDAO.ObtenerTodos();

        cmbTipoEdit.DataSource = null;
        cmbTipoEdit.ValueMember = "id";
        cmbTipoEdit.DisplayMember = "tipe";
        cmbTipoEdit.DataSource = tipoDAO.ObtenerTodos();
        
        textBox1edit.Hide();
        textBox2edit.Hide();
        txtNombre.Hide();
    }


    private void pbOKedit_Click(object sender, EventArgs e)
    {
        if (textBox1edit.Text.Length > 0 )
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id FROM GENERO WHERE GENERO.genero = @genero";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@genero", cmbGeneroEdit.Text);
        
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        textBox1edit.AppendText(a.ToString());
                    }
        
                    connection.Close();
                }
            }
        }

        if (textBox2edit.Text.Length > 0)
        {
            
        }

        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id FROM TIPO WHERE TIPO.tipo = @tipo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tipo", cmbTipoEdit.Text);
        
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        textBox2edit.AppendText(a.ToString());
                    }
        
                    connection.Close();
                }
            }
        }

        if (txtNombreEdit.Text.Length > 0)
        {
            Coleccion co = new Coleccion();

            co.nombre = txtNombreEdit.Text;
            co.id_genero = Convert.ToInt32(textBox1edit.Text);
            co.id_tipo = Convert.ToInt32(textBox2edit.Text);
            co.nombrebuscado = txtNombre.Text;

            if (coleccionDAO.Actualizar(co))
            {
                MessageBox.Show("Colección modificada existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Colecciones col = new Colecciones();
                col.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en la base de Datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        else
        {
            MessageBox.Show("Datos invalidos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        
        
        
    }
}