using System;
using System.Windows.Forms;

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
        //dgvEventos.Columns[0].Visible = false;
        dgvEventos.AutoResizeColumns();
    }
    int renglon;
    private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        renglon = e.RowIndex;
        string nombre;
        nombre = dgvEventos.Rows[renglon].Cells["imagen"].Value.ToString();
        txtImagen.Text = nombre;
        picImagen.Image = System.Drawing.Image.FromFile(txtImagen.Text);
    }
    
    private void btnInsertar_Click(object sender, EventArgs e)
    {
        frmNuevoEvento frnuev = new frmNuevoEvento();
        frnuev.Show();
        this.Close();
    }
}