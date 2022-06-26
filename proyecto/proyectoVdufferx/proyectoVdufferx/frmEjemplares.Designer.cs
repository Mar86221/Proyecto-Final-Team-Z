using System.ComponentModel;

namespace proyectoVdufferx
{
    partial class frmEjemplares
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjemplares));
            this.DgvEjemplares = new System.Windows.Forms.DataGridView();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.btnBuscarTo = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBuscarTo = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbInsti = new System.Windows.Forms.PictureBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picBuscarTo = new System.Windows.Forms.PictureBox();
            this.picFiltrar = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrestar = new System.Windows.Forms.TextBox();
            this.picEditarEjemplar = new System.Windows.Forms.PictureBox();
            this.picEliminarEjemplar = new System.Windows.Forms.PictureBox();
            this.txtCorreoEj = new System.Windows.Forms.TextBox();
            this.txtEliminarEJemplar = new System.Windows.Forms.TextBox();
            this.txtIdEjemplarEliminar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbInsti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBuscarTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFiltrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picEditarEjemplar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picEliminarEjemplar)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEjemplares
            // 
            this.DgvEjemplares.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DgvEjemplares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvEjemplares.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEjemplares.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvEjemplares.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvEjemplares.Location = new System.Drawing.Point(17, 136);
            this.DgvEjemplares.Name = "DgvEjemplares";
            this.DgvEjemplares.ReadOnly = true;
            this.DgvEjemplares.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvEjemplares.Size = new System.Drawing.Size(460, 471);
            this.DgvEjemplares.TabIndex = 0;
            this.DgvEjemplares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEjemplares_CellClick);
            this.DgvEjemplares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEjemplares_CellDoubleClick);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(499, 119);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(415, 488);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 8;
            this.picImagen.TabStop = false;
            // 
            // btnBuscarTo
            // 
            this.btnBuscarTo.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarTo.Name = "btnBuscarTo";
            this.btnBuscarTo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTo.TabIndex = 88;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(483, 587);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(10, 20);
            this.txtImagen.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(947, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // txtBuscarTo
            // 
            this.txtBuscarTo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarTo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtBuscarTo.Location = new System.Drawing.Point(22, 71);
            this.txtBuscarTo.Name = "txtBuscarTo";
            this.txtBuscarTo.Size = new System.Drawing.Size(319, 19);
            this.txtBuscarTo.TabIndex = 58;
            this.txtBuscarTo.Tag = "Cor";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(16, 66);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(327, 29);
            this.pictureBox7.TabIndex = 56;
            this.pictureBox7.TabStop = false;
            // 
            // pbCor
            // 
            this.pbCor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbCor.Location = new System.Drawing.Point(14, 64);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(331, 33);
            this.pbCor.TabIndex = 57;
            this.pbCor.TabStop = false;
            // 
            // cmbAutores
            // 
            this.cmbAutores.BackColor = System.Drawing.Color.White;
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Items.AddRange(new object[] {"Instituto", "Empresa", "Otros"});
            this.cmbAutores.Location = new System.Drawing.Point(511, 71);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(140, 20);
            this.cmbAutores.TabIndex = 77;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(508, 67);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(146, 28);
            this.pictureBox5.TabIndex = 74;
            this.pictureBox5.TabStop = false;
            // 
            // pbInsti
            // 
            this.pbInsti.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbInsti.Location = new System.Drawing.Point(506, 65);
            this.pbInsti.Name = "pbInsti";
            this.pbInsti.Size = new System.Drawing.Size(150, 32);
            this.pbInsti.TabIndex = 75;
            this.pbInsti.TabStop = false;
            // 
            // cmbFormato
            // 
            this.cmbFormato.BackColor = System.Drawing.Color.White;
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Items.AddRange(new object[] {"Instituto", "Empresa", "Otros"});
            this.cmbFormato.Location = new System.Drawing.Point(671, 71);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(140, 20);
            this.cmbFormato.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(668, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 28);
            this.pictureBox1.TabIndex = 78;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pictureBox3.Location = new System.Drawing.Point(666, 65);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 32);
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // picBuscarTo
            // 
            this.picBuscarTo.Image = ((System.Drawing.Image) (resources.GetObject("picBuscarTo.Image")));
            this.picBuscarTo.Location = new System.Drawing.Point(351, 59);
            this.picBuscarTo.Name = "picBuscarTo";
            this.picBuscarTo.Size = new System.Drawing.Size(87, 36);
            this.picBuscarTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBuscarTo.TabIndex = 81;
            this.picBuscarTo.TabStop = false;
            this.picBuscarTo.Click += new System.EventHandler(this.picBuscarTo_Click);
            // 
            // picFiltrar
            // 
            this.picFiltrar.Image = ((System.Drawing.Image) (resources.GetObject("picFiltrar.Image")));
            this.picFiltrar.Location = new System.Drawing.Point(835, 63);
            this.picFiltrar.Name = "picFiltrar";
            this.picFiltrar.Size = new System.Drawing.Size(86, 34);
            this.picFiltrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picFiltrar.TabIndex = 82;
            this.picFiltrar.TabStop = false;
            this.picFiltrar.Click += new System.EventHandler(this.picFiltrar_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pictureBox10.Location = new System.Drawing.Point(17, 119);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(44, 19);
            this.pictureBox10.TabIndex = 85;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 19);
            this.label1.TabIndex = 86;
            this.label1.Text = "LIBROS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(316, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "AUTORES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrestar
            // 
            this.txtPrestar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrestar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPrestar.Location = new System.Drawing.Point(483, 562);
            this.txtPrestar.Name = "txtPrestar";
            this.txtPrestar.Size = new System.Drawing.Size(10, 19);
            this.txtPrestar.TabIndex = 89;
            this.txtPrestar.Tag = "Cor";
            // 
            // picEditarEjemplar
            // 
            this.picEditarEjemplar.Image = ((System.Drawing.Image) (resources.GetObject("picEditarEjemplar.Image")));
            this.picEditarEjemplar.Location = new System.Drawing.Point(101, 622);
            this.picEditarEjemplar.Name = "picEditarEjemplar";
            this.picEditarEjemplar.Size = new System.Drawing.Size(113, 35);
            this.picEditarEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEditarEjemplar.TabIndex = 90;
            this.picEditarEjemplar.TabStop = false;
            this.picEditarEjemplar.Click += new System.EventHandler(this.picEditarEjemplar_Click);
            // 
            // picEliminarEjemplar
            // 
            this.picEliminarEjemplar.Image = ((System.Drawing.Image) (resources.GetObject("picEliminarEjemplar.Image")));
            this.picEliminarEjemplar.Location = new System.Drawing.Point(276, 622);
            this.picEliminarEjemplar.Name = "picEliminarEjemplar";
            this.picEliminarEjemplar.Size = new System.Drawing.Size(113, 35);
            this.picEliminarEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picEliminarEjemplar.TabIndex = 91;
            this.picEliminarEjemplar.TabStop = false;
            this.picEliminarEjemplar.Click += new System.EventHandler(this.picEliminarEjemplar_Click);
            this.picEliminarEjemplar.DoubleClick += new System.EventHandler(this.picEliminarEjemplar_DoubleClick);
            // 
            // txtCorreoEj
            // 
            this.txtCorreoEj.Location = new System.Drawing.Point(335, 12);
            this.txtCorreoEj.Name = "txtCorreoEj";
            this.txtCorreoEj.Size = new System.Drawing.Size(177, 20);
            this.txtCorreoEj.TabIndex = 92;
            // 
            // txtEliminarEJemplar
            // 
            this.txtEliminarEJemplar.Location = new System.Drawing.Point(442, 637);
            this.txtEliminarEJemplar.Name = "txtEliminarEJemplar";
            this.txtEliminarEJemplar.Size = new System.Drawing.Size(83, 20);
            this.txtEliminarEJemplar.TabIndex = 93;
            // 
            // txtIdEjemplarEliminar
            // 
            this.txtIdEjemplarEliminar.Location = new System.Drawing.Point(442, 664);
            this.txtIdEjemplarEliminar.Name = "txtIdEjemplarEliminar";
            this.txtIdEjemplarEliminar.Size = new System.Drawing.Size(83, 20);
            this.txtIdEjemplarEliminar.TabIndex = 94;
            // 
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 696);
            this.Controls.Add(this.txtIdEjemplarEliminar);
            this.Controls.Add(this.txtEliminarEJemplar);
            this.Controls.Add(this.txtCorreoEj);
            this.Controls.Add(this.picEliminarEjemplar);
            this.Controls.Add(this.picEditarEjemplar);
            this.Controls.Add(this.txtPrestar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.picFiltrar);
            this.Controls.Add(this.picBuscarTo);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cmbAutores);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pbInsti);
            this.Controls.Add(this.txtBuscarTo);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnBuscarTo);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.DgvEjemplares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "frmEjemplares";
            this.Load += new System.EventHandler(this.frmEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbInsti)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picBuscarTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFiltrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picEditarEjemplar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picEliminarEjemplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TextBox txtIdEjemplarEliminar;

        public System.Windows.Forms.TextBox txtEliminarEJemplar;

        public System.Windows.Forms.TextBox txtCorreoEj;

        private System.Windows.Forms.PictureBox picEliminarEjemplar;

        private System.Windows.Forms.PictureBox picEditarEjemplar;

        public System.Windows.Forms.TextBox txtPrestar;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox10;

        public System.Windows.Forms.PictureBox picFiltrar;

        public System.Windows.Forms.PictureBox picBuscarTo;

        public System.Windows.Forms.TextBox txtBuscarTo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbCor;
        public System.Windows.Forms.ComboBox cmbInstitucion;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbInsti;
        public System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.PictureBox pictureBox2;

        public System.Windows.Forms.TextBox txtImagen;

        private System.Windows.Forms.Button btnBuscarTo;

        private System.Windows.Forms.PictureBox picImagen;

        public System.Windows.Forms.ComboBox cmbAutores;

        public System.Windows.Forms.DataGridView DgvEjemplares;

        #endregion
    }
}