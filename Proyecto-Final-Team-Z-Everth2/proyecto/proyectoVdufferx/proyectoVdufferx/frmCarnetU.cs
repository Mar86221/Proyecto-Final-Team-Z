using System;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class frmCarnetU : Form
    {
        public frmCarnetU()
        {
            InitializeComponent();
        }
        public usuario usuario { get; set; }


        private void picMain_Click(object sender, EventArgs e)
        {
            string correo = txtCorreoQR.Text;
            this.usuario  = usuarioDAO.BuscarCorreoU(correo);
            if (usuario != null)
            {
                this.Close();
                MAIN main = new MAIN();
                main.txtTucuentaCorreo.Text = txtCorreoQR.Text;
                main.ShowDialog();
            }
        }


    }
}