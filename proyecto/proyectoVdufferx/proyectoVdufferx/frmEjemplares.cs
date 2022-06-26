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
        
        
        public static List<ejemplarmain> FiltrarTOT(string todo)
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplarmain> lista = new List<ejemplarmain>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor FROM IMAGEN_EJEMPLAR INNER JOIN EJEMPLAR ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id INNER JOIN EJEMPLARXAUTOR ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id INNER JOIN AUTOR ON EJEMPLARXAUTOR.id_autor = AUTOR.id INNER JOIN FORMATO ON EJEMPLAR.id_formato = FORMATO.id WHERE EJEMPLAR.nombre LIKE '%' + @todo + '%' OR EJEMPLAR.nombre = '@todo' OR EJEMPLAR.Palabras_claves LIKE '%' + @todo + '%'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@todo", Convert.ToString(todo));

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
        public static List<ejemplarmain> Filtros(string autor, string formato)
        {
            string cadena = Resources.cadena_conexion;
            List<ejemplarmain> lista = new List<ejemplarmain>();

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                string query =
                    "SELECT IMAGEN_EJEMPLAR.imagen, EJEMPLAR.nombre, AUTOR.nombre_autor  FROM IMAGEN_EJEMPLAR  INNER JOIN EJEMPLAR  ON IMAGEN_EJEMPLAR.id_ejemplar = EJEMPLAR.id INNER JOIN EJEMPLARXAUTOR  ON EJEMPLARXAUTOR.id_ejemplar = EJEMPLAR.id INNER JOIN AUTOR  ON EJEMPLARXAUTOR.id_autor = AUTOR.id INNER JOIN FORMATO ON EJEMPLAR.id_formato = FORMATO.id WHERE  AUTOR.nombre_autor = @autor and FORMATO.formato = @formato";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@autor", Convert.ToString(autor));
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
        
        private void frmEjemplares_Load(object sender, EventArgs e)
        {
          //  txtIdEjemplarEliminar.Hide();
          //  txtEliminarEJemplar.Hide();
          if (txtCorreoEj.Text != "MHRSbz5meUQ@admin.com")
          {
              picEliminarEjemplar.Hide();
              picEditarEjemplar.Hide();
              PicInsertarE.Hide();
          }
            txtCorreoEj.Hide();
            txtPrestar.Hide();
            txtImagen.Hide();
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = ejemplarDAO.ObtenerTodos();
            DgvEjemplares.Columns[0].Visible = false;
            DgvEjemplares.AutoResizeColumns();

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
            ///
            
        }
        
        private void picFiltrar_Click(object sender, EventArgs e)
        {
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = Filtros(Convert.ToString(cmbAutores.Text), Convert.ToString(cmbFormato.Text));
            DgvEjemplares.Columns[0].Visible = false;
        }

        private void picBuscarTo_Click(object sender, EventArgs e)
        {
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = FiltrarTOT(Convert.ToString(txtBuscarTo.Text));
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
            ///
            string nombreejemplar;
            nombreejemplar = DgvEjemplares.Rows[renglon].Cells["nombre"].Value.ToString();
            txtEliminarEJemplar.Text = nombreejemplar;
        }

        int renglonprestar;
        private void DgvEjemplares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            renglonprestar = e.RowIndex;
            string nombreprestar;
            nombreprestar = DgvEjemplares.Rows[renglonprestar].Cells["nombre"].Value.ToString();
            txtPrestar.Text = nombreprestar;
            frmPrestar frmp = new frmPrestar();
            frmp.txtNombreEjemplar.Text = nombreprestar;
            frmp.txtCorreoU.Text = txtCorreoEj.Text;/////////////////////////////////
            renglon = e.RowIndex;
            string nombre;
            nombre = DgvEjemplares.Rows[renglon].Cells["imagen"].Value.ToString();
            txtImagen.Text = nombre;
            picImagen.Image = System.Drawing.Image.FromFile(txtImagen.Text);
            frmp.pbPortada.Image = System.Drawing.Image.FromFile(txtImagen.Text);
            frmp.ShowDialog();
           
        }

        private void picEliminarEjemplar_Click(object sender, EventArgs e)
        {
            if (txtIdEjemplarEliminar.Text.Length > 0)
            {
                
            }
            else
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "SELECT id FROM EJEMPLAR WHERE EJEMPLAR.nombre = @iduser";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@iduser", Convert.ToString(txtEliminarEJemplar.Text));
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idu = Convert.ToInt32(reader["id"].ToString());
                            txtIdEjemplarEliminar.AppendText(idu.ToString());
                        }
                    }

                    connection.Close();
                }
            }
            static bool eliminarEjemplarxatuor(int id)
            {
                bool exito = true;
                try
                {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena))
                    {
                        string query =
                            "DELETE EJEMPLARXAUTOR FROM EJEMPLARXAUTOR WHERE EJEMPLARXAUTOR.id_ejemplar = @idejemplarbuscado";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idejemplarbuscado", id);

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

            static bool eliminarImagenEjemplar(int id)
            {
                bool exito = true;
                try
                {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena))
                    {
                        string query =
                            "DELETE IMAGEN_EJEMPLAR FROM IMAGEN_EJEMPLAR WHERE IMAGEN_EJEMPLAR.id_ejemplar = @idejemplarbuscado";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idejemplarbuscado", id);

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

            static bool eliminarEjemplarPresta(int id)
            {
                bool exito = true;
                try
                {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena))
                    {
                        string query = "DELETE PRESTA FROM PRESTA WHERE PRESTA.id_ejemplar = @idejemplarbuscado";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idejemplarbuscado", id);

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

            static bool eliminarEjemplar(int id)
            {
                bool exito = true;
                try
                {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena))
                    {
                        string query = "DELETE EJEMPLAR FROM EJEMPLAR WHERE EJEMPLAR.id = @idejemplarbuscado";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@idejemplarbuscado", id);

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
            
            eliminarEjemplarxatuor(Convert.ToInt32(txtIdEjemplarEliminar.Text));
            eliminarImagenEjemplar(Convert.ToInt32(txtIdEjemplarEliminar.Text));
            eliminarEjemplarPresta(Convert.ToInt32(txtIdEjemplarEliminar.Text));
            eliminarEjemplar(Convert.ToInt32(txtIdEjemplarEliminar.Text));

            MessageBox.Show("Eliminado con exito", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void picEditarEjemplar_Click(object sender, EventArgs e)
        {
            if (txtIdEjemplarEliminar.Text.Length > 0)
            {
               
            }
            else
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query =
                        "SELECT id FROM EJEMPLAR WHERE EJEMPLAR.nombre = @iduser";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@iduser", Convert.ToString(txtEliminarEJemplar.Text));
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idu = Convert.ToInt32(reader["id"].ToString());
                            txtIdEjemplarEliminar.AppendText(idu.ToString());
                        }
                    }

                    connection.Close();
                }
                
                frmEjemplarEditar otraventana = new frmEjemplarEditar();
                otraventana.Show();
                otraventana.txtIdEliminarE.Text = txtIdEjemplarEliminar.Text;
            }
        }

        private void picEliminarEjemplar_DoubleClick(object sender, EventArgs e)
        {
            
            
        }

        private void PicInsertarE_Click(object sender, EventArgs e)
        {
            frmEjemplarInsertar otraventana = new frmEjemplarInsertar();
            otraventana.Show();
        }
    }
}