using System;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class NuevaInstitucion : Form
    {
        public NuevaInstitucion()
        {
            InitializeComponent();
        }


        private void pbOK_Click(object sender, EventArgs e)
        {
            frmRegistro a = new frmRegistro();
            institucion i = new institucion();
           txtNovoInstitucion.Text = i.ninstitucion;
           i.id_ocupacion = 4;
            /*switch (a.cmbOcupacion.Text)
            {
                case "Estudiante":
                {
                    i.id_ocupacion = 1;
                    break;
                }
                case "Trabajador":
                {
                    i.id_ocupacion = 2;
                    break;
                }
                case "Desempleado":
                {
                    i.id_ocupacion = 3;
                    break;
                }
               
            }
             */
            this.Close();

            if (institucionDAO.CrearNuevo(i))
            {
                MessageBox.Show("Institucion registrada existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error de la base de datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}