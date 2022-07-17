using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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

    private void pbNuevacoleccion_Click(object sender, EventArgs e)
    {
        frmNuevaColeccion ne = new frmNuevaColeccion();
        ne.Show();
        this.Close();
    }

    private void pbEditarColeccion_Click(object sender, EventArgs e)
    {
        frmEditarColeccion editcollect = new frmEditarColeccion();
        editcollect.Show();
        this.Close();
    }
}