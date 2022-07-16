using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoVdufferx;

public partial class frmNuevaColeccion : Form
{
    private SqlConnection connection =
        new SqlConnection(@"Server=localhost;Database=BINAES_BDD;Trusted_Connection=True;");

    public frmNuevaColeccion()
    {
        InitializeComponent();
    }

    private void frmNuevaColeccion_Load(object sender, EventArgs e)
    {
        cmbGenero.DataSource = null;
        cmbGenero.ValueMember = "id";
        cmbGenero.DisplayMember = "genero";
        cmbGenero.DataSource = generoDAO.ObtenerTodos();
        
        cmbTipo.DataSource = null;
        cmbTipo.ValueMember = "id";
        cmbTipo.DisplayMember = "tipo";
        cmbTipo.DataSource = tipoDAO.ObtenerTodos();

    }
}