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

        private void frmEjemplares_Load(object sender, EventArgs e)
        {
            cmbFormato.Hide();
            cmbAutores.Hide();
            txtImagen.Hide();
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = ejemplarDAO.ObtenerTodos();
            DgvEjemplares.Columns[0].Visible = false;
        }
        
        private void btnFiltrarAu_Click(object sender, EventArgs e)
        {
            cmbAutores.Show();
            cmbAutores.DataSource = null;
            cmbAutores.ValueMember = "id";
            cmbAutores.DisplayMember = "nombre_autor";
            cmbAutores.DataSource = ejemplarDAO.ObtenerAutores();
        }

        private void btnFiltrarF_Click(object sender, EventArgs e)
        {
            cmbFormato.Show();
            cmbFormato.DataSource = null;
            cmbFormato.ValueMember = "id";
            cmbFormato.DisplayMember = "formato";
            cmbFormato.DataSource = ejemplarDAO.ObtenerFormatos();
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