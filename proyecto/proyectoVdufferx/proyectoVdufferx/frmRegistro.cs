using System;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Documents;

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
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }
        private Boolean verificadorCorreo(string correo)
        {
            return Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public Boolean verificadorNumero(string numero)
        {
            return Regex.IsMatch(numero, @"\A[0-9]{7,10}\z");
        }
        OpenFileDialog ofd = new OpenFileDialog();
        public void btnBuscar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "Descargas";
            ofd.Filter = "Archivos png (*.png)|*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFotografia.Text = ofd.FileName;
            }
            ofd.Dispose();
        }
        
        private void picRegistrarme2_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0 &&
                txtDireccion.Text.Length > 0 &&
                txtTelefono.Text.Length > 0 &&
                txtCorreo.Text.Length > 0 &&
                cmbInstitucion.Text.Length > 0 &&
                cmbOcupacion.Text.Length > 0 &&
                txtFotografia.Text.Length > 0)
                
            {
                usuario u = new usuario();
                u.nombre = txtNombre.Text;
                u.direccion = txtDireccion.Text;
                u.fotografia = txtFotografia.Text;
                if (verificadorNumero(txtTelefono.Text))
                {
                    u.telefono = txtTelefono.Text;
                }
                else
                {
                   errorNumero.SetError(pbTel, "Numero de telefono invalido");
                }
                if (verificadorCorreo(txtCorreo.Text))
                {
                    u.correo = txtCorreo.Text;
                }
                else
                {
                    errorCorreo.SetError(pbCor,"Correo invalido");
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
                    case "Otros":
                        u.id_ocupacion = 3;
                        break;

                }

                switch (cmbInstitucion.Text)
                {
                    case "Instituto":
                    {
                        u.id_institucion = 1;
                        break;
                    }
                    case "Empresa":
                    {
                        u.id_institucion = 2;
                        break;
                    }
                    case "Otros":
                    {
                        u.id_institucion= 3;
                        break;
                    }
                }

                if (usuarioDAO.CrearNuevo(u))
                {
                    MessageBox.Show("Usuario registrado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmCarnetU Datos = new frmCarnetU();
                    Datos.txtNombreQR.Text = txtNombre.Text;
                    Datos.txtCorreoQR.Text = txtCorreo.Text;
                    Datos.picUser.Image = Image.FromFile(ofd.FileName);
                    //Datos.picQR.Image = Image.FromFile(ofd.FileName);
                    QRCoder.QRCodeGenerator QR = new QRCoder.QRCodeGenerator();
                    ASCIIEncoding ASSCII = new ASCIIEncoding();
                    var z = QR.CreateQrCode(ASSCII.GetBytes(Datos.txtCorreoQR.Text), QRCoder.QRCodeGenerator.ECCLevel.H);
                    QRCoder.PngByteQRCode png = new QRCoder.PngByteQRCode();
                    png.SetQRCodeData(z);
                    var arr = png.GetGraphic(10);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(arr, 0, arr.Length);
                    Bitmap b = new Bitmap(ms);
                    Datos.picQR.Image = b;
                    Datos.Show();
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