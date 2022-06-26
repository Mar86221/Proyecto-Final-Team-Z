using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmEventos : Form
{
    public frmEventos()
    {
        InitializeComponent();
    }
    

    private void frmEventos_Load_1(object sender, EventArgs e)
    {
        dgvEventos.DataSource = null;
        dgvEventos.DataSource = eventosDAO.ObtenerTodos();
        dgvEventos.Columns[0].Visible = false;
        dgvEventos.AutoResizeColumns();
        txtImagen.Hide();
        txtTituloEliminar.Hide();
    }
    int renglon;
    private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        renglon = e.RowIndex;
        string nombre;
        nombre = dgvEventos.Rows[renglon].Cells["imagen"].Value.ToString();
        txtImagen.Text = nombre;
        picImagen.Image = System.Drawing.Image.FromFile(txtImagen.Text);
        string nombreliminar;
        nombreliminar = dgvEventos.Rows[renglon].Cells["titulo"].Value.ToString();
        txtTituloEliminar.Text = nombreliminar;
        
    }
    

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        static bool eliminarEvento(string titulo)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE EVENTO FROM EVENTO WHERE EVENTO.titulo = @titulo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titulo", titulo);

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
        eliminarEvento(txtTituloEliminar.Text);
        MessageBox.Show("Eliminado con exito");
    }

    private void btnInsertar_Click_1(object sender, EventArgs e)
    {
        frmNuevoEvento frnuev = new frmNuevoEvento();
        frnuev.Show();
        this.Close();
    }

    private void btnEliminar_Click_1(object sender, EventArgs e)
    {
        static bool eliminarEvento(string titulo)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE EVENTO FROM EVENTO WHERE EVENTO.titulo = @titulo";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@titulo", titulo);

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
        eliminarEvento(txtTituloEliminar.Text);
        MessageBox.Show("Eliminado con exito");
        this.Close();
    }


}