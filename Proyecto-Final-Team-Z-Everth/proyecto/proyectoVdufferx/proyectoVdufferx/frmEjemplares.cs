using System;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class frmEjemplares : Form
    {
        public frmEjemplares()
        {
            InitializeComponent();
        }

        private void frmEjemplares_Load(object sender, EventArgs e)
        {
            cmbAutores.Hide();
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = ejemplarDAO.ObtenerTodos();
        }

        private void btnFiltrarAu_Click(object sender, EventArgs e)
        {
            cmbAutores.Show();
            cmbAutores.DataSource = null;
            cmbAutores.ValueMember = "id";
            cmbAutores.DisplayMember = "nombre_autor";
            cmbAutores.DataSource = ejemplarDAO.ObtenerAutores();
        }
    }
}