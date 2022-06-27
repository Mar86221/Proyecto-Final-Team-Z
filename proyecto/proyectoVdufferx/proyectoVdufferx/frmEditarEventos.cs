using System;
using System.Windows.Forms;

namespace proyectoVdufferx;

public partial class frmEditarEventos : Form
{
    private OpenFileDialog ofdi = new OpenFileDialog();
    public frmEditarEventos()
    {
        InitializeComponent();
    }

    private void picBuscaredit_Click(object sender, EventArgs e)
    {
        ofdi.InitialDirectory = "Eventos";
        ofdi.Filter = "Archivos png (*.png)|*.png|Archivos jpg (*.jpg)|*.jpg";
        if (ofdi.ShowDialog() == DialogResult.OK)
        {
            txtImagenedit.Text = ofdi.SafeFileName;
        }

        ofdi.Dispose();
    }

    private void picOked_Click(object sender, EventArgs e)
    {
        eventos r = new eventos();
        string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Eventos\" + txtImagenedit.Text;

        r.imagen = ruta;
        r.titulo = txtNombreEdit.Text;
        r.cant_asistentes = Convert.ToInt32(txtAsistentesrdit.Text);
        r.fecha_inicio = Convert.ToDateTime(dtpInicioed.Text + " " + cmbHoraInicioed.Text + ":" + cmbMinInicioed.Text);
        r.fecha_final = Convert.ToDateTime(dtpFinaled.Text + " " + cmbHoraFinaled.Text + ":" + cmbMinFinaled.Text);
        r.titulobuscado = txtNombre.Text;
        if (eventosDAO.Actualizar(r))
        {
            MessageBox.Show("Evento creado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }else
        {
            MessageBox.Show("Error de la base de datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }

    private void frmEditarEventos_Load(object sender, EventArgs e)
    {
        frmEventos frmev = new frmEventos();
        frmev.txtTituloEliminar.Text = txtNombre.Text;
    }
}