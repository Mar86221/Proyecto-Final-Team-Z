using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void picRegistrarme_Click(object sender, EventArgs e)
        {
            frmRegistro otraventana = new frmRegistro();
            otraventana.Show();
            this.Hide();
        }

        private void picIngresar_Click(object sender, EventArgs e)
        {
            frmIngresar otraventana = new frmIngresar();
            otraventana.Show();
            this.Hide();
            
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            picRegistrarme.Hide();
        }
    }
}