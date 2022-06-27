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
                errorCorreo.SetError(pbCor, "El correo no existe");
            }
            else
            {
                if (txtCorreo.Text == "MHRSbz5meUQ@admin.com")
                {
                    pbIngresar2.Show();
                    pbRegistrarUsuario.Show();

                }
                else
                {
                    pbIngresar2.Show();
                }
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.Show();
            main.txtTucuentaCorreo.Text = txtCorreo.Text;
            
            this.Close();
        }

        private void pbRegistrarUsuario_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {
            pbIngresar2.Hide();
            pbRegistrarUsuario.Hide();
        }
    }
}