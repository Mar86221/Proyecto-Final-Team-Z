using System;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class frmIngresar : Form
    {
        public usuario usuario { get; set; }
        public frmIngresar()
        {
            InitializeComponent();
        }


        private void bttIngresar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;

            this.usuario  = usuarioDAO.BuscarCorreoU(correo);
            if (usuario == null)
            {
                MessageBox.Show("El correo no existe","BINAES",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                
            }
        }
    }
}