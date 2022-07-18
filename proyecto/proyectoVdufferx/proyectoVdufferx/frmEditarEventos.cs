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

        if (txtNombreEdit.Text.Length > 0 &&
            txtAsistentesrdit.Text.Length > 0 &&
            cmbHoraInicioed.Text.Length >0 &&
            cmbMinInicioed.Text.Length >0 &&
            cmbHoraFinaled.Text.Length >0 &&
            cmbMinFinaled.Text.Length >0)
        {
            r.imagen = ruta;
            r.titulo = txtNombreEdit.Text;
            r.cant_asistentes = Convert.ToInt32(txtAsistentesrdit.Text);
            r.fecha_inicio = Convert.ToDateTime(dtpInicioed.Text + " " + cmbHoraInicioed.Text + ":" + cmbMinInicioed.Text);
            r.fecha_final = Convert.ToDateTime(dtpFinaled.Text + " " + cmbHoraFinaled.Text + ":" + cmbMinFinaled.Text);
            r.titulobuscado = txtNombre.Text;
            if (eventosDAO.Actualizar(r))
            {
                MessageBox.Show("Evento modificado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                this.Close();
            }else
            {
                MessageBox.Show("Error en la base de Datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
           
          }
        else
        {
            MessageBox.Show("Datos invalidos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        }

     

    private void frmEditarEventos_Load_1(object sender, EventArgs e)
    {
        //txtNombre.Hide();
    }
}