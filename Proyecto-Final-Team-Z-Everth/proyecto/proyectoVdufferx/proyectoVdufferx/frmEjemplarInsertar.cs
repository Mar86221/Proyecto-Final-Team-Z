using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmEjemplarInsertar : Form
{
    public frmEjemplarInsertar()
    {
        InitializeComponent();
    }

    private void frmEjemplarInsertar_Load(object sender, EventArgs e)
    {
        cmbColeccion.DataSource = null;
        cmbColeccion.ValueMember = "id";
        cmbColeccion.DisplayMember = "nombre";
        cmbColeccion.DataSource = ejemplarDAO.ObtenerColecciones();
        ///
        cmbEditorial.DataSource = null;
        cmbEditorial.ValueMember = "id";
        cmbEditorial.DisplayMember = "editorial";
        cmbEditorial.DataSource = ejemplarDAO.ObtenerEditoriales();
        ///
        cmbIdioma.DataSource = null;
        cmbIdioma.ValueMember = "id";
        cmbIdioma.DisplayMember = "idioma";
        cmbIdioma.DataSource = ejemplarDAO.ObtenerIdiomas();
        ///
        cmbFormato.DataSource = null;
        cmbFormato.ValueMember = "id";
        cmbFormato.DisplayMember = "formato";
        cmbFormato.DataSource = ejemplarDAO.ObtenerFormatos();
        ///
        
    }

    private void PicInsertarE_Click_1(object sender, EventArgs e)
    {
       /* string cadena = Resources.cadena_conexion;
        string query =
            "INSERT INTO EJEMPLAR ([etiqueta],[nombre],[Palabras_claves],[fecha_publicacion],[id_coleccion],[id_editoria],[id_idioma],[id_formato])" +
            "VALUES ('"+txtEtiqueta.Text+"','"+txtNombreE.Text+"','"+txtPalabrasClaves.Text+"','"+dtpFechaP.Text+"','"+txtIdEColeccion.Text+"','"+txtIdEditorialE.Text+"','"+txtIdIdiomaE.Text+"','"+txtIdFormatoId.Text+"')";
        SqlCommand command = new SqlCommand(query,cadena);
        command.ExecuteNonQuery();*/
        ejemplar ejemplar = new ejemplar();
         ejemplar.etiqueta = txtEtiqueta.Text;
         ejemplar.nombre = txtNombreE.Text;
         ejemplar.Palabras_claves = txtPalabrasClaves.Text;
         ejemplar.fecha_publicacion = Convert.ToDateTime(dtpFechaP.Text);
         ejemplar.id_coleccion = Convert.ToInt32(txtIdEColeccion.Text);
         ejemplar.id_editorial = Convert.ToInt32(txtIdEditorialE.Text);
         ejemplar.id_idioma = Convert.ToInt32(txtIdIdiomaE.Text);
         ejemplar.id_formato = Convert.ToInt32(txtIdFormatoId.Text);
 
         ejemplarDAO.CrearnuevoEjemplar(ejemplar);
        /*  {
              MessageBox.Show("Ejemplar creado con exito");
          }
          else
          {
              MessageBox.Show("Ha ocurrido un errror");
          }*/
    }

    

    private void cmbColeccion_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (txtIdEColeccion.Text.Length > 0)
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id FROM COLECCION WHERE COLECCION.nombre = @iduser";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@iduser", Convert.ToString(cmbColeccion.Text));
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idu = Convert.ToInt32(reader["id"].ToString());
                        txtIdEColeccion.AppendText(idu.ToString());
                    }
                }

                connection.Close();
            }
        }
    }


    private void cmbEditorial_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (txtIdEditorialE.Text.Length > 0)
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id FROM EDITORIAL WHERE EDITORIAL.editorial = @iduser";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@iduser", Convert.ToString(cmbEditorial.Text));
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idu = Convert.ToInt32(reader["id"].ToString());
                        txtIdEditorialE.AppendText(idu.ToString());
                    }
                }

                connection.Close();
            }
        }

    }

    private void cmbIdioma_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (txtIdIdiomaE.Text.Length > 0)
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id FROM IDIOMA WHERE IDIOMA.idioma = @iduser";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@iduser", Convert.ToString(cmbIdioma.Text));
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idu = Convert.ToInt32(reader["id"].ToString());
                        txtIdIdiomaE.AppendText(idu.ToString());
                    }
                }

                connection.Close();
            }
        }
    }

    private void cmbFormato_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (txtIdFormatoId.Text.Length > 0)
        {
            
        }
        else
        {
            string cadena = Resources.cadena_conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT id FROM FORMATO WHERE FORMATO.formato = @iduser";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@iduser", Convert.ToString(cmbFormato.Text));
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idu = Convert.ToInt32(reader["id"].ToString());
                        txtIdFormatoId.AppendText(idu.ToString());
                    }
                }

                connection.Close();
            }
        }
    }
}