using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx
{
    public partial class frmEjemplares : Form
    {
        public frmEjemplares()
        {
            InitializeComponent();
        }


        private void frmEjemplares_Load(object sender, EventArgs e)
        {
            DgvEjemplares.DataSource = null;
            DgvEjemplares.DataSource = ejemplarDAO.ObtenerTodos();
        }
        }
    }
