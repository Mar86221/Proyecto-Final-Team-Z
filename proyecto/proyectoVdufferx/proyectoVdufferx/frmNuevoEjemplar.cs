using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmNuevoEjemplar : Form
{

    public ejemplar Ejemplar { get; set; }
    
    private OpenFileDialog ofdi = new OpenFileDialog();
    public frmNuevoEjemplar()
    {
        InitializeComponent();
    }

    private void frmNuevoEjemplar_Load(object sender, EventArgs e)
    {
        cmbColeccion.DataSource = null;
        cmbColeccion.ValueMember = "id";
        cmbColeccion.DisplayMember = "nombre";
        cmbColeccion.DataSource = coleccionDAO.ObtenerNombre();

        cmbIdioma.DataSource = null;
        cmbIdioma.ValueMember = "id";
        cmbIdioma.DisplayMember = "idioma";
        cmbIdioma.DataSource = idiomaDAO.ObtenerIdioma();

        cmbFormato.DataSource = null;
        cmbFormato.ValueMember = "id";
        cmbFormato.DisplayMember = "formato";
        cmbFormato.DataSource = formatoDAO.ObtenerFormato();

        cmbEditorial.DataSource = null;
        cmbEditorial.ValueMember = "id";
        cmbEditorial.DisplayMember = "editorial";
        cmbEditorial.DataSource = editorialDAO.ObtenerEditorial();

        cmbAutor.DataSource = null;
        cmbAutor.ValueMember = "id";
        cmbAutor.DisplayMember = "nombre_autor";
        cmbAutor.DataSource = autorDAO.ObtenerTodos();
    }

    private void pbOk_Click(object sender, EventArgs e)
    {
        if (txtID_idioma.Text.Length > 0)
        {
            
        }

        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT IDIOMA.id FROM IDIOMA WHERE IDIOMA.idioma = @idioma";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@idioma", cmbIdioma.Text);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        txtID_idioma.AppendText(a.ToString());
                    }
                    
                    connection.Close();
                }
            }
        }
        
        if (txtID_Formato.Text.Length > 0)
        {
            
        }

        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT FORMATO.id FROM FORMATO WHERE FORMATO.formato = @formato";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@formato", cmbFormato.Text);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        txtID_Formato.AppendText(a.ToString());
                    }
                    
                    connection.Close();
                }
            }
        }
        
        
        if (txtID_coleccion.Text.Length > 0)
        {
            
        }

        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT COLECCION.id FROM COLECCION WHERE COLECCION.nombre = @nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", cmbColeccion.Text);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        txtID_coleccion.AppendText(a.ToString());
                    }
                    
                    connection.Close();
                }
            }
        }
        
        
        if (txtID_editorial.Text.Length > 0)
        {
            
        }

        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT EDITORIAL.id FROM EDITORIAL WHERE EDITORIAL.editorial = @editorial";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@editorial", cmbEditorial.Text);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        txtID_editorial.AppendText(a.ToString());
                    }
                    
                    connection.Close();
                }
            }
        }

        if (txtID_autor.Text.Length > 0)
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT AUTOR.id FROM AUTOR WHERE AUTOR.nombre_autor = @nombre_autor";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre_autor", cmbAutor.Text);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        txtID_autor.AppendText(a.ToString());
                    }
                    
                    connection.Close();
                }
            }
        }

        string ruta = System.AppDomain.CurrentDomain.BaseDirectory + @"Libros\" + txtPortada.Text;


        txtfecha.Text = dtpFecha.Text;
        
        
        if (txtNombreEjemplar.Text.Length > 0 &&
            txtPalabrasclave.Text.Length > 0 &&
            txtEtiqueta.Text.Length > 0)
        {
            ejemplar ejm = new ejemplar();

            ejm.nombre = txtNombreEjemplar.Text;
            ejm.Palabras_claves = txtPalabrasclave.Text;
            ejm.fecha_publicacion = dtpFecha.Value;
            ejm.id_coleccion = Convert.ToInt32(txtID_coleccion.Text);
            ejm.id_editorial = Convert.ToInt32(txtID_editorial.Text);
            ejm.id_idioma = Convert.ToInt32(txtID_idioma.Text);
            ejm.id_formato = Convert.ToInt32(txtID_Formato.Text);
            ejm.etiqueta = txtEtiqueta.Text;

            if (ejemplarDAO.CrearNuevo(ejm))
            {
                MessageBox.Show("Ejemplar creado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
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

        if (txtID_ejemplar.Text.Length > 0)
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query = "SELECT EJEMPLAR.id FROM EJEMPLAR WHERE EJEMPLAR.nombre = @nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", txtNombreEjemplar.Text);
                
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int a = Convert.ToInt32(reader["id"].ToString());
                        txtID_ejemplar.AppendText(a.ToString());
                    }
                    
                    connection.Close();
                }
            }
        }

        if (txtID_autor.Text.Length > 0 &&
            txtID_ejemplar.Text.Length > 0)
        {
            ejemplarxautor ejxa = new ejemplarxautor();

            ejxa.id_ejemplar = Convert.ToInt32(txtID_ejemplar.Text);
            ejxa.id_autor = Convert.ToInt32(txtID_autor.Text);
            
            if (ejemplarxautorDAO.CrearNuevo(ejxa))
            {
                MessageBox.Show("Creado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Error en la base de Datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

    }
    

    private void picBuscaPortada_Click(object sender, EventArgs e)
    {
        ofdi.InitialDirectory = "Libros";
        ofdi.Filter = "Archivos jpg (*.jpg)|*.jpg";
        if (ofdi.ShowDialog() == DialogResult.OK)
        {
            txtPortada.Text = ofdi.SafeFileName;
        }

        ofdi.Dispose();
    }
}