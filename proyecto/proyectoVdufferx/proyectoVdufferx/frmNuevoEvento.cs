using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using proyectoVdufferx.Properties;

namespace proyectoVdufferx;

public partial class frmNuevoEvento : Form
{
    public eventos evento { get; set; }
    
    private OpenFileDialog ofdi = new OpenFileDialog();

    private SqlConnection connection =
        new SqlConnection(@"Server=localhost;Database=BINAES_BDD;Trusted_Connection=True;");

    public frmNuevoEvento()
    {
        InitializeComponent();
    }
    

    private void pictureBox12_Click(object sender, EventArgs e)
    {
        if (txtNombre.Text.Length > 0)
                {
        
                }
                else
                {
                    string cadena = Resources.cadena_conexion;
                    using (SqlConnection connection = new SqlConnection(cadena))
                    {
                        string query = "SELECT id FROM AREA WHERE AREA.nombre = @nombre";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nombre", cmbArea.Text);
        
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int a = Convert.ToInt32(reader["id"].ToString());
                                txtNombre.AppendText(a.ToString());
                            }
        
                            connection.Close();
                        }
                    }
                }
                eventos r = new eventos();
                string ruta =System.AppDomain.CurrentDomain.BaseDirectory + @"Eventos\" + txtImagen.Text;
                if (txtNombreE.Text.Length>0 &&
                    txtAsistentes.Text.Length >0 &&
                    cmbHoraFinal.Text.Length > 0 &&
                    cmbHoraInicio.Text.Length >0 &&
                    cmbMinFinal.Text.Length >0 &&
                    cmbMinInicio.Text.Length >0)
                {
                    r.imagen = ruta;
                    r.titulo = txtNombreE.Text;
                    r.cant_asistentes = Convert.ToInt32(txtAsistentes.Text);
                    r.fecha_inicio = Convert.ToDateTime(dtpInicio.Text + " " + cmbHoraInicio.Text + ":" + cmbMinInicio.Text);
                    r.fecha_final = Convert.ToDateTime(dtpFinal.Text + " " + cmbHoraFinal.Text + ":" + cmbMinFinal.Text);
                    r.id_area = Convert.ToInt32(txtNombre.Text);
                    if (eventosDAO.CrearNuevo(r))
                    {
                        MessageBox.Show("Evento creado existosamente!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        this.Close();  
                    }else
                    {
                        MessageBox.Show("Error en la base de Datos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Datos invalidos!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
    }

    private void frmNuevoEvento_Load_1(object sender, EventArgs e)
    {
        cmbArea.DataSource = null;
        cmbArea.ValueMember = "id";
        cmbArea.DisplayMember = "nombre";
        cmbArea.DataSource = areaDAO.ObtenerTodos();
        txtNombre.Hide();
    }

    private void picBuscar_Click(object sender, EventArgs e)
    {
        ofdi.InitialDirectory = "Eventos";
        ofdi.Filter = "Archivos png (*.png)|*.png|Archivos jpg (*.jpg)|*.jpg";
        if (ofdi.ShowDialog() == DialogResult.OK)
        {
            txtImagen.Text = ofdi.SafeFileName;
        }

        ofdi.Dispose();
    }
}
    