using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace proyectoVdufferx
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private Boolean verificadorCorrero(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private void picRegistrarme2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 &&
                txtInstitucion.Text.Length > 0 &&
                txtTelefono.Text.Length > 0 &&
                txtCorreo.Text.Length > 0)
                
            {
                usuario u = new usuario();
                u.nombre = txtNombre.Text;
                u.direccion = txtDireccion.Text;
                u.institucion = txtInstitucion.Text;
                u.telefono = txtTelefono.Text;
                if (verificadorCorrero(txtCorreo.Text))
                {
                    u.correo = txtCorreo.Text;
                }
                else
                {
                    errorCorreo.SetError(pictureBox7,"Correo invalido");
                }
                
                switch (cmbOcupacion.Text)
                {
                    case "Estudiante":
                    {
                        u.id_ocupacion = 1;
                        break;
                    }
                    case "Empleado":
                    {
                        u.id_ocupacion = 2;
                        break;
                    }
                    case "Desempleado":
                        u.id_ocupacion = 3;
                        break;

                }

                if (usuarioDAO.CrearNuevo(u))
                {
                    MessageBox.Show("Usuario registrado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close( );
                }
                else
                {
                    MessageBox.Show("Error de la base de datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                
            }
            else
            {
                MessageBox.Show("Datos invalidos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtEnter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name == "pb"+ txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }

                if (ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString() )
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
            
        }

        private void txtLeave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is PictureBox && ctrl.Name == "pb"+ txt.Tag.ToString())
                {
                    if (txt.Text==string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.FromArgb(33,62,153);
                    }
                }

                if (ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString() )
                {
                    if (txt.Text==string.Empty)
                    {
                        ctrl.ForeColor = Color.Red;
                    }
                    else
                    {
                        ctrl.ForeColor = Color.FromArgb(33,62,153);;
                    }
                }
            }
        }

        
    }
}