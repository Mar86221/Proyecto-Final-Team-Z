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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmInicio init = new frmInicio();
            init.Show();
            this.Close();
        }
    }
}