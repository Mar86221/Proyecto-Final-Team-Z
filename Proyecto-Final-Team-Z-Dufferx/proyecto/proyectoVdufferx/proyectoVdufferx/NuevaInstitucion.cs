using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class NuevaInstitucion : Form
    {
        private SqlConnection connection =
            new SqlConnection(@"Server=localhost;Database=BINAES_BDD;Trusted_Connection=True;");
        public NuevaInstitucion()
        {
            InitializeComponent();
        }


        private void pbOK_Click(object sender, EventArgs e)
        {
            institucion i = new institucion();
            i.ninstitucion = txtNovoInstitucion.Text;
            switch (cmbOcupacion2.Text)
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


            if (institucionDAO.CrearNuevo(i))
            {
                MessageBox.Show("Institucion registrada existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error de la base de datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}