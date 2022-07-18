using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class Colecciones : Form
{
    public Colecciones()
    {
        InitializeComponent();
    }

    private void Colecciones_Load(object sender, EventArgs e)
    {
        
        
        DgvColecciones.DataSource = null;
        DgvColecciones.DataSource = coleccionDAO.ObtenerTodos();
        DgvColecciones.Columns[0].Visible = false;
        DgvColecciones.AutoResizeColumns();
        
    }

    int renglon;

    private void pbNuevacoleccion_Click(object sender, EventArgs e)
    {
        frmNuevaColeccion ne = new frmNuevaColeccion();
        ne.Show();
        this.Close();
    }

    private void pbEditarColeccion_Click(object sender, EventArgs e)
    {
        frmEditarColeccion editcollect = new frmEditarColeccion();
        editcollect.txtNombre.Text = txtColectEliminar.Text;
        editcollect.Show();
        this.Close();
    }

    

    private void DgvColecciones_CellClick_1(object sender, DataGridViewCellEventArgs e)
    {
        renglon = e.RowIndex;
        string nombreeliminar;
        nombreeliminar = DgvColecciones.Rows[renglon].Cells["nombre"].Value.ToString();
        txtColectEliminar.Text = nombreeliminar;
    }

    private void picEliminarColeccion_Click(object sender, EventArgs e)
    {
        static bool eliminarColeccion(string nombre)
        {
            bool exito = true;
            try
            {
                string cadena = Resources.cadena_conexion;
                using (SqlConnection connection = new SqlConnection(cadena))
                {
                    string query = "DELETE COLECCION FROM COLECCION WHERE COLECCION.nombre = @nombre";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception )
            {
                exito = false;
            }

            return exito;
        }

        eliminarColeccion(txtColectEliminar.Text);
        MessageBox.Show("Colección eliminada con éxito");

        frmEjemplares frmej = new frmEjemplares();
        frmej.Show();
        this.Close();
    }
}