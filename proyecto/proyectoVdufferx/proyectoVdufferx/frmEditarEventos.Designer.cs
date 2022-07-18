using System.ComponentModel;

namespace proyectoVdufferx;

partial class frmEditarEventos
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarEventos));
        this.picOked = new System.Windows.Forms.PictureBox();
        this.label4 = new System.Windows.Forms.Label();
        this.cmbMinFinaled = new System.Windows.Forms.ComboBox();
        this.cmbHoraFinaled = new System.Windows.Forms.ComboBox();
        this.dtpFinaled = new System.Windows.Forms.DateTimePicker();
        this.pictureBox10 = new System.Windows.Forms.PictureBox();
        this.pictureBox11 = new System.Windows.Forms.PictureBox();
        this.label3 = new System.Windows.Forms.Label();
        this.cmbMinInicioed = new System.Windows.Forms.ComboBox();
        this.cmbHoraInicioed = new System.Windows.Forms.ComboBox();
        this.dtpInicioed = new System.Windows.Forms.DateTimePicker();
        this.pictureBox6 = new System.Windows.Forms.PictureBox();
        this.pictureBox7 = new System.Windows.Forms.PictureBox();
        this.txtAsistentesrdit = new System.Windows.Forms.TextBox();
        this.picBuscaredit = new System.Windows.Forms.PictureBox();
        this.lblFotografia = new System.Windows.Forms.Label();
        this.txtImagenedit = new System.Windows.Forms.TextBox();
        this.pictureBox8 = new System.Windows.Forms.PictureBox();
        this.pictureBox9 = new System.Windows.Forms.PictureBox();
        this.label2 = new System.Windows.Forms.Label();
        this.pictureBox3 = new System.Windows.Forms.PictureBox();
        this.pictureBox4 = new System.Windows.Forms.PictureBox();
        this.txtNombreEdit = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        ((System.ComponentModel.ISupportInitialize) (this.picOked)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picBuscaredit)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
        this.SuspendLayout();
        // 
        // picOked
        // 
        this.picOked.Cursor = System.Windows.Forms.Cursors.Hand;
        this.picOked.Image = ((System.Drawing.Image) (resources.GetObject("picOked.Image")));
        this.picOked.Location = new System.Drawing.Point(220, 242);
        this.picOked.Name = "picOked";
        this.picOked.Size = new System.Drawing.Size(80, 35);
        this.picOked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.picOked.TabIndex = 136;
        this.picOked.TabStop = false;
        this.picOked.Click += new System.EventHandler(this.picOked_Click);
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label4.Location = new System.Drawing.Point(17, 187);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(111, 20);
        this.label4.TabIndex = 135;
        this.label4.Text = "Fecha final:";
        // 
        // cmbMinFinaled
        // 
        this.cmbMinFinaled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMinFinaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbMinFinaled.FormattingEnabled = true;
        this.cmbMinFinaled.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"});
        this.cmbMinFinaled.Location = new System.Drawing.Point(218, 205);
        this.cmbMinFinaled.Name = "cmbMinFinaled";
        this.cmbMinFinaled.Size = new System.Drawing.Size(68, 21);
        this.cmbMinFinaled.TabIndex = 134;
        // 
        // cmbHoraFinaled
        // 
        this.cmbHoraFinaled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbHoraFinaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbHoraFinaled.FormattingEnabled = true;
        this.cmbHoraFinaled.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"});
        this.cmbHoraFinaled.Location = new System.Drawing.Point(145, 205);
        this.cmbHoraFinaled.Name = "cmbHoraFinaled";
        this.cmbHoraFinaled.Size = new System.Drawing.Size(70, 21);
        this.cmbHoraFinaled.TabIndex = 133;
        // 
        // dtpFinaled
        // 
        this.dtpFinaled.CustomFormat = "";
        this.dtpFinaled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpFinaled.Location = new System.Drawing.Point(22, 207);
        this.dtpFinaled.Name = "dtpFinaled";
        this.dtpFinaled.Size = new System.Drawing.Size(103, 20);
        this.dtpFinaled.TabIndex = 132;
        this.dtpFinaled.Value = new System.DateTime(2022, 6, 25, 16, 4, 42, 0);
        // 
        // pictureBox10
        // 
        this.pictureBox10.BackColor = System.Drawing.Color.White;
        this.pictureBox10.Location = new System.Drawing.Point(13, 198);
        this.pictureBox10.Name = "pictureBox10";
        this.pictureBox10.Size = new System.Drawing.Size(283, 36);
        this.pictureBox10.TabIndex = 131;
        this.pictureBox10.TabStop = false;
        // 
        // pictureBox11
        // 
        this.pictureBox11.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox11.Location = new System.Drawing.Point(11, 196);
        this.pictureBox11.Name = "pictureBox11";
        this.pictureBox11.Size = new System.Drawing.Size(287, 40);
        this.pictureBox11.TabIndex = 130;
        this.pictureBox11.TabStop = false;
        // 
        // label3
        // 
        this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label3.Location = new System.Drawing.Point(17, 128);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(111, 20);
        this.label3.TabIndex = 129;
        this.label3.Text = "Fecha Inicio:";
        // 
        // cmbMinInicioed
        // 
        this.cmbMinInicioed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbMinInicioed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbMinInicioed.FormattingEnabled = true;
        this.cmbMinInicioed.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"});
        this.cmbMinInicioed.Location = new System.Drawing.Point(218, 146);
        this.cmbMinInicioed.Name = "cmbMinInicioed";
        this.cmbMinInicioed.Size = new System.Drawing.Size(68, 21);
        this.cmbMinInicioed.TabIndex = 128;
        // 
        // cmbHoraInicioed
        // 
        this.cmbHoraInicioed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbHoraInicioed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.cmbHoraInicioed.FormattingEnabled = true;
        this.cmbHoraInicioed.Items.AddRange(new object[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"});
        this.cmbHoraInicioed.Location = new System.Drawing.Point(145, 146);
        this.cmbHoraInicioed.Name = "cmbHoraInicioed";
        this.cmbHoraInicioed.Size = new System.Drawing.Size(70, 21);
        this.cmbHoraInicioed.TabIndex = 127;
        // 
        // dtpInicioed
        // 
        this.dtpInicioed.CustomFormat = "";
        this.dtpInicioed.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        this.dtpInicioed.Location = new System.Drawing.Point(22, 148);
        this.dtpInicioed.Name = "dtpInicioed";
        this.dtpInicioed.Size = new System.Drawing.Size(103, 20);
        this.dtpInicioed.TabIndex = 126;
        this.dtpInicioed.Value = new System.DateTime(2022, 6, 25, 16, 4, 42, 0);
        // 
        // pictureBox6
        // 
        this.pictureBox6.BackColor = System.Drawing.Color.White;
        this.pictureBox6.Location = new System.Drawing.Point(13, 139);
        this.pictureBox6.Name = "pictureBox6";
        this.pictureBox6.Size = new System.Drawing.Size(283, 36);
        this.pictureBox6.TabIndex = 125;
        this.pictureBox6.TabStop = false;
        // 
        // pictureBox7
        // 
        this.pictureBox7.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox7.Location = new System.Drawing.Point(11, 137);
        this.pictureBox7.Name = "pictureBox7";
        this.pictureBox7.Size = new System.Drawing.Size(287, 40);
        this.pictureBox7.TabIndex = 124;
        this.pictureBox7.TabStop = false;
        // 
        // txtAsistentesrdit
        // 
        this.txtAsistentesrdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.txtAsistentesrdit.Location = new System.Drawing.Point(13, 90);
        this.txtAsistentesrdit.Name = "txtAsistentesrdit";
        this.txtAsistentesrdit.Size = new System.Drawing.Size(94, 26);
        this.txtAsistentesrdit.TabIndex = 123;
        // 
        // picBuscaredit
        // 
        this.picBuscaredit.Cursor = System.Windows.Forms.Cursors.Hand;
        this.picBuscaredit.Image = ((System.Drawing.Image) (resources.GetObject("picBuscaredit.Image")));
        this.picBuscaredit.Location = new System.Drawing.Point(267, 84);
        this.picBuscaredit.Name = "picBuscaredit";
        this.picBuscaredit.Size = new System.Drawing.Size(30, 29);
        this.picBuscaredit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        this.picBuscaredit.TabIndex = 122;
        this.picBuscaredit.TabStop = false;
        this.picBuscaredit.Click += new System.EventHandler(this.picBuscaredit_Click);
        // 
        // lblFotografia
        // 
        this.lblFotografia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.lblFotografia.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.lblFotografia.Location = new System.Drawing.Point(130, 73);
        this.lblFotografia.Name = "lblFotografia";
        this.lblFotografia.Size = new System.Drawing.Size(100, 20);
        this.lblFotografia.TabIndex = 121;
        this.lblFotografia.Text = "Fotografía:";
        // 
        // txtImagenedit
        // 
        this.txtImagenedit.BackColor = System.Drawing.Color.White;
        this.txtImagenedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.txtImagenedit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.txtImagenedit.Location = new System.Drawing.Point(136, 90);
        this.txtImagenedit.Name = "txtImagenedit";
        this.txtImagenedit.ReadOnly = true;
        this.txtImagenedit.Size = new System.Drawing.Size(125, 19);
        this.txtImagenedit.TabIndex = 120;
        this.txtImagenedit.Tag = "Fot";
        // 
        // pictureBox8
        // 
        this.pictureBox8.Location = new System.Drawing.Point(128, 85);
        this.pictureBox8.Name = "pictureBox8";
        this.pictureBox8.Size = new System.Drawing.Size(171, 29);
        this.pictureBox8.TabIndex = 118;
        this.pictureBox8.TabStop = false;
        // 
        // pictureBox9
        // 
        this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox9.Location = new System.Drawing.Point(126, 83);
        this.pictureBox9.Name = "pictureBox9";
        this.pictureBox9.Size = new System.Drawing.Size(176, 33);
        this.pictureBox9.TabIndex = 119;
        this.pictureBox9.TabStop = false;
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label2.Location = new System.Drawing.Point(10, 69);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(96, 16);
        this.label2.TabIndex = 117;
        this.label2.Text = "Asistentes";
        // 
        // pictureBox3
        // 
        this.pictureBox3.BackColor = System.Drawing.Color.White;
        this.pictureBox3.Location = new System.Drawing.Point(10, 80);
        this.pictureBox3.Name = "pictureBox3";
        this.pictureBox3.Size = new System.Drawing.Size(101, 40);
        this.pictureBox3.TabIndex = 115;
        this.pictureBox3.TabStop = false;
        // 
        // pictureBox4
        // 
        this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox4.Location = new System.Drawing.Point(8, 78);
        this.pictureBox4.Name = "pictureBox4";
        this.pictureBox4.Size = new System.Drawing.Size(105, 44);
        this.pictureBox4.TabIndex = 116;
        this.pictureBox4.TabStop = false;
        // 
        // txtNombreEdit
        // 
        this.txtNombreEdit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.txtNombreEdit.Location = new System.Drawing.Point(16, 31);
        this.txtNombreEdit.Name = "txtNombreEdit";
        this.txtNombreEdit.Size = new System.Drawing.Size(278, 26);
        this.txtNombreEdit.TabIndex = 114;
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label1.Location = new System.Drawing.Point(16, 10);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(141, 16);
        this.label1.TabIndex = 113;
        this.label1.Text = "Nombre Evento:";
        // 
        // pictureBox1
        // 
        this.pictureBox1.BackColor = System.Drawing.Color.White;
        this.pictureBox1.Location = new System.Drawing.Point(11, 20);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(288, 40);
        this.pictureBox1.TabIndex = 111;
        this.pictureBox1.TabStop = false;
        // 
        // pictureBox2
        // 
        this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox2.Location = new System.Drawing.Point(9, 18);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new System.Drawing.Size(292, 44);
        this.pictureBox2.TabIndex = 112;
        this.pictureBox2.TabStop = false;
        // 
        // txtNombre
        // 
        this.txtNombre.Location = new System.Drawing.Point(56, 240);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(158, 20);
        this.txtNombre.TabIndex = 137;
        // 
        // openFileDialog1
        // 
        this.openFileDialog1.FileName = "openFileDialog1";
        // 
        // frmEditarEventos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(320, 284);
        this.Controls.Add(this.txtNombre);
        this.Controls.Add(this.picOked);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.cmbMinFinaled);
        this.Controls.Add(this.cmbHoraFinaled);
        this.Controls.Add(this.dtpFinaled);
        this.Controls.Add(this.pictureBox10);
        this.Controls.Add(this.pictureBox11);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.cmbMinInicioed);
        this.Controls.Add(this.cmbHoraInicioed);
        this.Controls.Add(this.dtpInicioed);
        this.Controls.Add(this.pictureBox6);
        this.Controls.Add(this.pictureBox7);
        this.Controls.Add(this.txtAsistentesrdit);
        this.Controls.Add(this.picBuscaredit);
        this.Controls.Add(this.lblFotografia);
        this.Controls.Add(this.txtImagenedit);
        this.Controls.Add(this.pictureBox8);
        this.Controls.Add(this.pictureBox9);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.pictureBox3);
        this.Controls.Add(this.pictureBox4);
        this.Controls.Add(this.txtNombreEdit);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.pictureBox1);
        this.Controls.Add(this.pictureBox2);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "frmEditarEventos";
        this.Load += new System.EventHandler(this.frmEditarEventos_Load_1);
        ((System.ComponentModel.ISupportInitialize) (this.picOked)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox11)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.picBuscaredit)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.PictureBox picOked;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbMinFinaled;
    private System.Windows.Forms.ComboBox cmbHoraFinaled;
    private System.Windows.Forms.DateTimePicker dtpFinaled;
    private System.Windows.Forms.PictureBox pictureBox10;
    private System.Windows.Forms.PictureBox pictureBox11;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbMinInicioed;
    private System.Windows.Forms.ComboBox cmbHoraInicioed;
    private System.Windows.Forms.DateTimePicker dtpInicioed;
    private System.Windows.Forms.PictureBox pictureBox6;
    private System.Windows.Forms.PictureBox pictureBox7;
    private System.Windows.Forms.TextBox txtAsistentesrdit;
    public System.Windows.Forms.PictureBox picBuscaredit;
    private System.Windows.Forms.Label lblFotografia;
    private System.Windows.Forms.TextBox txtImagenedit;
    private System.Windows.Forms.PictureBox pictureBox8;
    private System.Windows.Forms.PictureBox pictureBox9;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox4;
    private System.Windows.Forms.TextBox txtNombreEdit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    public System.Windows.Forms.TextBox txtNombre;

    #endregion
}