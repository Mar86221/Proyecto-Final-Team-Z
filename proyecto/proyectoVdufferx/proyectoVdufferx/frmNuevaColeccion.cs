using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmNuevaColeccion : Form
{
    private SqlConnection connection =
        new SqlConnection(@"Server=localhost;Database=BINAES_BDD;Trusted_Connection=True;");
    public Coleccion coleccion { get; set; }
    public frmNuevaColeccion()
    {
        InitializeComponent();
    }

    private void frmNuevaColeccion_Load(object sender, EventArgs e)
    {
        cmbGenero.DataSource = null;
        cmbGenero.ValueMember = "id";
        cmbGenero.DisplayMember = "genrer";
        cmbGenero.DataSource = generoDAO.ObtenerTodos();
        
        cmbTipo.DataSource = null;
        cmbTipo.ValueMember = "id";
        cmbTipo.DisplayMember = "tipe";
        cmbTipo.DataSource = tipoDAO.ObtenerTodos();
      //  textBox1.Hide();
        //textBox2.Hide();
    }
    

    private void pbOK_Click(object sender, EventArgs e)
    {
       if (textBox1.Text.Length > 0 )
        {
        
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id FROM GENERO WHERE GENERO.genero = @genero";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@genero", cmbGenero.Text);
        
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        textBox1.AppendText(a.ToString());
                    }
        
                    connection.Close();
                }
            }
        }
        if (textBox2.Text.Length > 0 )
        {
        
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT id FROM TIPO WHERE TIPO.tipo = @tipo";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tipo", cmbTipo.Text);
        
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        textBox2.AppendText(a.ToString());
                    }
        
                    connection.Close();
                }
            }

            Coleccion c = new Coleccion();
            if (txtNombre.Text.Length > 0 &&
                textBox1.Text.Length > 0 &&
                textBox2.Text.Length > 0)
            {
                c.nombre = txtNombre.Text;
                c.id_genero = Convert.ToInt32(textBox1.Text);
                c.id_tipo = Convert.ToInt32(textBox2.Text);
                if (coleccionDAO.CrearNuevo(c))
                {
                    MessageBox.Show("Coleccion creada existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.Close();  
                }
                
                else
                {
                    MessageBox.Show("Error en la base de Datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}