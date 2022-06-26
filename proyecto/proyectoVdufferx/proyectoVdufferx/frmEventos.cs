using System;
using System.Windows.Forms;

namespace proyectoVdufferx;

public partial class frmEventos : Form
{
    public frmEventos()
    {
        InitializeComponent();
    }

    private void frmEventos_Load(object sender, EventArgs e)
    {
        dgvEventos.DataSource = null;
        dgvEventos.DataSource = eventosDAO.ObtenerTodos();
        dgvEventos.Columns[0].Visible = false;
        dgvEventos.AutoResizeColumns();
    }
}