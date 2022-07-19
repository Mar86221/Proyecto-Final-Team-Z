using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmEditarEjemplar : Form
{
    
    
    public ejemplar Ejemplar { get; set; }
    
    private OpenFileDialog ofdi = new OpenFileDialog();
    public frmEditarEjemplar()
    {
        InitializeComponent();
    }


    private void frmEditarEjemplar_Load(object sender, EventArgs e)
    {
        cmbColeccionEdit.DataSource = null;
        cmbColeccionEdit.ValueMember = "id";
        cmbColeccionEdit.DisplayMember = "nombre";
        cmbColeccionEdit.DataSource = coleccionDAO.ObtenerNombre();

        cmbIdiomaEdit.DataSource = null;
        cmbIdiomaEdit.ValueMember = "id";
        cmbIdiomaEdit.DisplayMember = "idioma";
        cmbIdiomaEdit.DataSource = idiomaDAO.ObtenerIdioma();

        cmbFormatoEdit.DataSource = null;
        cmbFormatoEdit.ValueMember = "id";
        cmbFormatoEdit.DisplayMember = "formato";
        cmbFormatoEdit.DataSource = formatoDAO.ObtenerFormato();

        cmbEditorialEdit.DataSource = null;
        cmbEditorialEdit.ValueMember = "id";
        cmbEditorialEdit.DisplayMember = "editorial";
        cmbEditorialEdit.DataSource = editorialDAO.ObtenerEditorial();

        cmbAutor.DataSource = null;
        cmbAutor.ValueMember = "id";
        cmbAutor.DisplayMember = "nombre_autor";
        cmbAutor.DataSource = autorDAO.ObtenerTodos();
        
        gbAutoryPortada.Hide();
        txtID_autor.Hide();
        txtID_coleccion.Hide();
        txtID_editorial.Hide();
        txtID_ejemplar.Hide();
        txtID_idioma.Hide();
        txtID_Formato.Hide();
        txtNombre.Hide();
        txtfecha.Hide();
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
                command.Parameters.AddWithValue("@idioma", cmbIdiomaEdit.Text);
                
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
                command.Parameters.AddWithValue("@formato", cmbFormatoEdit.Text);
                
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
                command.Parameters.AddWithValue("@nombre", cmbColeccionEdit.Text);
                
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
                command.Parameters.AddWithValue("@editorial", cmbEditorialEdit.Text);
                
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
                command.Parameters.AddWithValue("@nombre", txtNombre.Text);
                
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
        
        
        string ruta = System.AppDomain.CurrentDomain.BaseDirectory + @"Libros\" + txtPortada.Text;

        
        
        
        if (txtNombreEjemplarEdit.Text.Length > 0 &&
            txtPalabrasclaveEdit.Text.Length > 0 &&
            txtEtiquetaEdit.Text.Length > 0)
        {
            ejemplar ejm = new ejemplar();

            ejm.nombre = txtNombreEjemplarEdit.Text;
            ejm.Palabras_claves = txtPalabrasclaveEdit.Text;
            ejm.fecha_publicacion = dtpFechaEdit.Value;
            ejm.id_coleccion = Convert.ToInt32(txtID_coleccion.Text);
            ejm.id_editorial = Convert.ToInt32(txtID_editorial.Text);
            ejm.id_idioma = Convert.ToInt32(txtID_idioma.Text);
            ejm.id_formato = Convert.ToInt32(txtID_Formato.Text);
            ejm.etiqueta = txtEtiquetaEdit.Text;
            ejm.nombrebuscado = txtNombre.Text;

            if (ejemplarDAO.Actualizar(ejm))
            {
                MessageBox.Show("Ejemplar actualizado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                gbAutoryPortada.Show();
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


    private void pictureBox20_Click(object sender, EventArgs e)
    {

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

    
            ejemplarxautor ejxa = new ejemplarxautor();

            ejxa.id_ejemplarbuscado = Convert.ToInt32(txtID_ejemplar.Text);
            ejxa.id_autor = Convert.ToInt32(txtID_autor.Text);


            Imagen_ejemplar img = new Imagen_ejemplar();

            img.imagen = txtPortada.Text;
            img.id_ejemplarbuscado = Convert.ToInt32(txtID_ejemplar.Text);
            
            if (ejemplarxautorDAO.Actualizar(ejxa) && Imagen_ejemplarDAO.Actualizar(img))
            {
                MessageBox.Show("Ejemplar actualizado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Error en la base de Datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

    }
}