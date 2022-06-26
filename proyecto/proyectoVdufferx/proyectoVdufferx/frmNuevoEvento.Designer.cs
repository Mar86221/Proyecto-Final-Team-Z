using System.ComponentModel;

namespace proyectoVdufferx;

partial class frmNuevoEvento
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoEvento));
        this.cmbArea = new System.Windows.Forms.ComboBox();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.txtImagen = new System.Windows.Forms.TextBox();
        this.txtNombreE = new System.Windows.Forms.TextBox();
        this.opfImagen = new System.Windows.Forms.OpenFileDialog();
        this.picImagen = new System.Windows.Forms.PictureBox();
        this.txtAsistentes = new System.Windows.Forms.TextBox();
        this.panel1 = new System.Windows.Forms.Panel();
        this.cmbMinFinal = new System.Windows.Forms.ComboBox();
        this.cmbHoraFinal = new System.Windows.Forms.ComboBox();
        this.dtpFinal = new System.Windows.Forms.DateTimePicker();
        this.cmbMinInicio = new System.Windows.Forms.ComboBox();
        this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
        this.dtpInicio = new System.Windows.Forms.DateTimePicker();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBox4 = new System.Windows.Forms.PictureBox();
        this.pictureBox3 = new System.Windows.Forms.PictureBox();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.picOkPrestar = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
        this.panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picOkPrestar)).BeginInit();
        this.SuspendLayout();
        // 
        // cmbArea
        // 
        this.cmbArea.FormattingEnabled = true;
        this.cmbArea.Location = new System.Drawing.Point(12, 56);
        this.cmbArea.Name = "cmbArea";
        this.cmbArea.Size = new System.Drawing.Size(200, 21);
        this.cmbArea.TabIndex = 0;
        // 
        // txtNombre
        // 
        this.txtNombre.Location = new System.Drawing.Point(480, 194);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(10, 20);
        this.txtNombre.TabIndex = 1;
        // 
        // txtImagen
        // 
        this.txtImagen.Location = new System.Drawing.Point(12, 135);
        this.txtImagen.Name = "txtImagen";
        this.txtImagen.Size = new System.Drawing.Size(200, 20);
        this.txtImagen.TabIndex = 3;
        // 
        // txtNombreE
        // 
        this.txtNombreE.Location = new System.Drawing.Point(12, 83);
        this.txtNombreE.Name = "txtNombreE";
        this.txtNombreE.Size = new System.Drawing.Size(200, 20);
        this.txtNombreE.TabIndex = 4;
        // 
        // picImagen
        // 
        this.picImagen.Image = ((System.Drawing.Image) (resources.GetObject("picImagen.Image")));
        this.picImagen.Location = new System.Drawing.Point(218, 135);
        this.picImagen.Name = "picImagen";
        this.picImagen.Size = new System.Drawing.Size(23, 20);
        this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.picImagen.TabIndex = 5;
        this.picImagen.TabStop = false;
        this.picImagen.Click += new System.EventHandler(this.picImagen_Click);
        // 
        // txtAsistentes
        // 
        this.txtAsistentes.Location = new System.Drawing.Point(12, 109);
        this.txtAsistentes.Name = "txtAsistentes";
        this.txtAsistentes.Size = new System.Drawing.Size(200, 20);
        this.txtAsistentes.TabIndex = 6;
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.cmbMinFinal);
        this.panel1.Controls.Add(this.cmbHoraFinal);
        this.panel1.Controls.Add(this.dtpFinal);
        this.panel1.Controls.Add(this.cmbMinInicio);
        this.panel1.Controls.Add(this.cmbHoraInicio);
        this.panel1.Controls.Add(this.dtpInicio);
        this.panel1.Controls.Add(this.label2);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.pictureBox4);
        this.panel1.Controls.Add(this.pictureBox3);
        this.panel1.Controls.Add(this.pictureBox2);
        this.panel1.Controls.Add(this.pictureBox1);
        this.panel1.Location = new System.Drawing.Point(12, 194);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(465, 69);
        this.panel1.TabIndex = 7;
        // 
        // cmbMinFinal
        // 
        this.cmbMinFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMinFinal.FormattingEnabled = true;
        this.cmbMinFinal.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"});
        this.cmbMinFinal.Location = new System.Drawing.Point(405, 20);
        this.cmbMinFinal.Name = "cmbMinFinal";
        this.cmbMinFinal.Size = new System.Drawing.Size(55, 21);
        this.cmbMinFinal.TabIndex = 13;
        // 
        // cmbHoraFinal
        // 
        this.cmbHoraFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbHoraFinal.FormattingEnabled = true;
        this.cmbHoraFinal.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"});
        this.cmbHoraFinal.Location = new System.Drawing.Point(344, 20);
        this.cmbHoraFinal.Name = "cmbHoraFinal";
        this.cmbHoraFinal.Size = new System.Drawing.Size(55, 21);
        this.cmbHoraFinal.TabIndex = 12;
        // 
        // dtpFinal
        // 
        this.dtpFinal.CustomFormat = "";
        this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFinal.Location = new System.Drawing.Point(246, 21);
        this.dtpFinal.Name = "dtpFinal";
        this.dtpFinal.Size = new System.Drawing.Size(73, 20);
        this.dtpFinal.TabIndex = 11;
        this.dtpFinal.Value = new System.DateTime(2022, 6, 25, 16, 4, 42, 0);
        // 
        // cmbMinInicio
        // 
        this.cmbMinInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMinInicio.FormattingEnabled = true;
        this.cmbMinInicio.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"});
        this.cmbMinInicio.Location = new System.Drawing.Point(175, 21);
        this.cmbMinInicio.Name = "cmbMinInicio";
        this.cmbMinInicio.Size = new System.Drawing.Size(55, 21);
        this.cmbMinInicio.TabIndex = 10;
        // 
        // cmbHoraInicio
        // 
        this.cmbHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbHoraInicio.FormattingEnabled = true;
        this.cmbHoraInicio.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"});
        this.cmbHoraInicio.Location = new System.Drawing.Point(116, 21);
        this.cmbHoraInicio.Name = "cmbHoraInicio";
        this.cmbHoraInicio.Size = new System.Drawing.Size(55, 21);
        this.cmbHoraInicio.TabIndex = 9;
        // 
        // dtpInicio
        // 
        this.dtpInicio.CustomFormat = "";
        this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpInicio.Location = new System.Drawing.Point(23, 21);
        this.dtpInicio.Name = "dtpInicio";
        this.dtpInicio.Size = new System.Drawing.Size(73, 20);
        this.dtpInicio.TabIndex = 7;
        this.dtpInicio.Value = new System.DateTime(2022, 6, 25, 16, 4, 42, 0);
        // 
        // label2
        // 
        this.label2.BackColor = System.Drawing.Color.White;
        this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label2.Location = new System.Drawing.Point(253, 5);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(113, 16);
        this.label2.TabIndex = 6;
        this.label2.Text = "Fecha Finalizacion";
        // 
        // label1
        // 
        this.label1.BackColor = System.Drawing.Color.White;
        this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label1.Location = new System.Drawing.Point(14, 6);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(101, 16);
        this.label1.TabIndex = 5;
        this.label1.Text = "Fecha Inicio";
        // 
        // pictureBox4
        // 
        this.pictureBox4.BackColor = System.Drawing.Color.White;
        this.pictureBox4.Location = new System.Drawing.Point(240, 12);
        this.pictureBox4.Name = "pictureBox4";
        this.pictureBox4.Size = new System.Drawing.Size(222, 38);
        this.pictureBox4.TabIndex = 3;
        this.pictureBox4.TabStop = false;
        // 
        // pictureBox3
        // 
        this.pictureBox3.BackColor = System.Drawing.Color.White;
        this.pictureBox3.Location = new System.Drawing.Point(11, 13);
        this.pictureBox3.Name = "pictureBox3";
        this.pictureBox3.Size = new System.Drawing.Size(222, 38);
        this.pictureBox3.TabIndex = 2;
        this.pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox2.Location = new System.Drawing.Point(239, 11);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new System.Drawing.Size(224, 40);
        this.pictureBox2.TabIndex = 1;
        this.pictureBox2.TabStop = false;
        // 
        // pictureBox1
        // 
        this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox1.Location = new System.Drawing.Point(10, 12);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(224, 40);
        this.pictureBox1.TabIndex = 0;
        this.pictureBox1.TabStop = false;
        // 
        // picOkPrestar
        // 
        this.picOkPrestar.Image = ((System.Drawing.Image) (resources.GetObject("picOkPrestar.Image")));
        this.picOkPrestar.Location = new System.Drawing.Point(397, 403);
        this.picOkPrestar.Name = "picOkPrestar";
        this.picOkPrestar.Size = new System.Drawing.Size(80, 35);
        this.picOkPrestar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.picOkPrestar.TabIndex = 14;
        this.picOkPrestar.TabStop = false;
        this.picOkPrestar.Click += new System.EventHandler(this.picOkPrestar_Click);
        // 
        // frmNuevoEvento
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(514, 450);
        this.Controls.Add(this.picOkPrestar);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.txtAsistentes);
        this.Controls.Add(this.picImagen);
        this.Controls.Add(this.txtNombreE);
        this.Controls.Add(this.txtImagen);
        this.Controls.Add(this.txtNombre);
        this.Controls.Add(this.cmbArea);
        this.Name = "frmNuevoEvento";
        this.Text = "frmNuevoEvento";
        this.Load += new System.EventHandler(this.frmNuevoEvento_Load);
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).EndInit();
        this.panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.picOkPrestar)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox picOkPrestar;
    private System.Windows.Forms.ComboBox cmbMinFinal;
    private System.Windows.Forms.ComboBox cmbHoraFinal;
    private System.Windows.Forms.DateTimePicker dtpFinal;
    private System.Windows.Forms.ComboBox cmbMinInicio;
    private System.Windows.Forms.ComboBox cmbHoraInicio;
    private System.Windows.Forms.DateTimePicker dtpInicio;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.TextBox txtAsistentes;

    private System.Windows.Forms.PictureBox picImagen;

    private System.Windows.Forms.OpenFileDialog opfImagen;

    private System.Windows.Forms.TextBox txtImagen;
    private System.Windows.Forms.TextBox txtNombreE;

    private System.Windows.Forms.TextBox txtNombre;

    private System.Windows.Forms.ComboBox cmbArea;

    #endregion
}