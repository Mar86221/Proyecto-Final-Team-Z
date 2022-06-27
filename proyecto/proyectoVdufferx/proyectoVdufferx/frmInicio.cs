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
        

        private void picIngresar_Click(object sender, EventArgs e)
        {
            frmIngresar otraventana = new frmIngresar();
            otraventana.Show();
            this.Hide();
            
        }

    }
}