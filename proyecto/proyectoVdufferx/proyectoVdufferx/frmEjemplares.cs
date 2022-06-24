using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using proyectoVdufferx.Properties;
using DataGrid = System.Windows.Controls.DataGrid;
using Image = System.Windows.Controls.Image;


namespace proyectoVdufferx
{
    
    public partial class frmEjemplares : Form
    {
        public frmEjemplares()
        {
            InitializeComponent();
        }
        public static List<ejemplarmain> FiltrarAutor(string autor)
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplarmain> lista = new List<ejemplarmain>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor  FROM IMAGEN_EJEMPLAR  INNER JOIN EJEMPLAR  ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id  INNER JOIN EJEMPLARXAUTOR  ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id  INNER JOIN AUTOR  ON EJEMPLARXAUTOR.id_autor = AUTOR.id  WHERE AUTOR.nombre_autor = @autor";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@autor", Convert.ToString(autor));

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Libros\" + reader["imagen"].ToString();
                        ejemplarmain ejemplarm = new ejemplarmain();
                        ejemplarm.imagen = ruta;
                        ejemplarm.nombre = reader["nombre"].ToString();
                        ejemplarm.nombre_autor = reader["nombre_autor"].ToString();
                        lista.Add(ejemplarm);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        public static List<ejemplarmain> FiltrarFormato(string formato)
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplarmain> lista = new List<ejemplarmain>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor  FROM IMAGEN_EJEMPLAR  INNER JOIN EJEMPLAR  ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id  INNER JOIN EJEMPLARXAUTOR  ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id  INNER JOIN AUTOR  ON EJEMPLARXAUTOR.id_autor = AUTOR.id  INNER JOIN FORMATO ON EJEMPLAR.id_formato = FORMATO.id WHERE FORMATO.formato = @formato";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@formato", Convert.ToString(formato));

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Libros\" + reader["imagen"].ToString();
                        ejemplarmain ejemplarm = new ejemplarmain();
                        ejemplarm.imagen = ruta;
                        ejemplarm.nombre = reader["nombre"].ToString();
                        ejemplarm.nombre_autor = reader["nombre_autor"].ToString();
                        lista.Add(ejemplarm);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        
        public static List<ejemplarmain> FiltrarNombreCompleto(string nombreC)
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplarmain> lista = new List<ejemplarmain>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor  FROM IMAGEN_EJEMPLAR  INNER JOIN EJEMPLAR  ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id  INNER JOIN EJEMPLARXAUTOR  ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id  INNER JOIN AUTOR  ON EJEMPLARXAUTOR.id_autor = AUTOR.id  INNER JOIN FORMATO ON EJEMPLAR.id_formato = FORMATO.id WHERE EJEMPLAR.nombre = @nombreC";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombreC", Convert.ToString(nombreC));

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Libros\" + reader["imagen"].ToString();
                        ejemplarmain ejemplarm = new ejemplarmain();
                        ejemplarm.imagen = ruta;
                        ejemplarm.nombre = reader["nombre"].ToString();
                        ejemplarm.nombre_autor = reader["nombre_autor"].ToString();
                        lista.Add(ejemplarm);
                    }
                }

                connection.Close();
            }

            return lista;
        }
        private void frmEjemplares_Load(object sender, EventArgs e)
        {
            txtImagen.Hide();
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = ejemplarDAO.ObtenerTodos();
            DgvEjemplares.Columns[0].Visible = false;
            ////
            cmbAutores.DataSource = null;
            cmbAutores.ValueMember = "id";
            cmbAutores.DisplayMember = "nombre_autor";
            cmbAutores.DataSource = ejemplarDAO.ObtenerAutores();
            ////
            cmbFormato.DataSource = null;
            cmbFormato.ValueMember = "id";
            cmbFormato.DisplayMember = "formato";
            cmbFormato.DataSource = ejemplarDAO.ObtenerFormatos();
        }
        
        private void btnFiltrarAu_Click(object sender, EventArgs e)
        {
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = FiltrarAutor(Convert.ToString(cmbAutores.Text));
            DgvEjemplares.Columns[0].Visible = false;
        }

        private void btnFiltrarF_Click(object sender, EventArgs e)
        {
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = FiltrarFormato(Convert.ToString(cmbFormato.Text));
            DgvEjemplares.Columns[0].Visible = false;
        }

        private void btnBuscarNombreCompleto_Click(object sender, EventArgs e)
        {
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = FiltrarNombreCompleto(Convert.ToString(txtBuscarNombreCompleto.Text));
            DgvEjemplares.Columns[0].Visible = false;
        }
        
        int renglon;
        private void DgvEjemplares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
            string nombre;
            nombre = DgvEjemplares.Rows[renglon].Cells["imagen"].Value.ToString();
            txtImagen.Text = nombre;
            picImagen.Image = System.Drawing.Image.FromFile(txtImagen.Text);
        }

        private void DgvEjemplares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        
    }
}