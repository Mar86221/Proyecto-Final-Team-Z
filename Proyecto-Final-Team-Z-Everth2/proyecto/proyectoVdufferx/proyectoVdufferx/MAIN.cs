using System;
using System.Windows.Forms;

namespace proyectoVdufferx
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        public void picTucuenta_Click(object sender, EventArgs e)
        {
            grpTuCuenta.Show();
        }
        

        public void MAIN_Load(object sender, EventArgs e)
        {
           grpTuCuenta.Hide();
        }
        
    }
}