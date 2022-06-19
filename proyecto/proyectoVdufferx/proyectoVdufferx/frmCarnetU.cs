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


        private void picMain_Click(object sender, EventArgs e)
        {
            this.Close();
            MAIN main = new MAIN();
            main.ShowDialog();
        }
    }
}