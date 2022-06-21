using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Input;

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
                //MessageBox.Show("El correo no existe","BINAES",MessageBoxButtons.OK,MessageBoxIcon.Error);
                errorCorreo.SetError(pbCor, "El correo no existe");
            }
            else
            {
                
                MAIN main = new MAIN();
                main.Show();
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }


        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int) Keys.Enter)
            {
                string correo = txtCorreo.Text;

                this.usuario  = usuarioDAO.BuscarCorreoU(correo);
                if (usuario == null)
                {
                    //MessageBox.Show("El correo no existe","BINAES",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    errorCorreo.SetError(pbCor, "El correo no existe");
                }
                else
                {
                    MAIN main = new MAIN();
                    main.Show();
                    this.Close();
                }
            }
        }
    }
}