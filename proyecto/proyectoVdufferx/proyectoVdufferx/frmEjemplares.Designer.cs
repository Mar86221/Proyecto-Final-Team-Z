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
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.DgvEjemplares = new System.Windows.Forms.DataGridView();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.txtBuscarTo = new System.Windows.Forms.TextBox();
            this.btnBuscarTo = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.grbFiltros = new System.Windows.Forms.GroupBox();
            this.chbFormato = new System.Windows.Forms.CheckBox();
            this.chbAutores = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
            this.grbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(110, 19);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(126, 21);
            this.cmbAutores.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(373, 19);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(120, 21);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrarF_Click);
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(242, 19);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(126, 21);
            this.cmbFormato.TabIndex = 7;
            // 
            // DgvEjemplares
            // 
            this.DgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEjemplares.Location = new System.Drawing.Point(12, 177);
            this.DgvEjemplares.Name = "DgvEjemplares";
            this.DgvEjemplares.ReadOnly = true;
            this.DgvEjemplares.Size = new System.Drawing.Size(487, 491);
            this.DgvEjemplares.TabIndex = 0;
            this.DgvEjemplares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEjemplares_CellClick);
            this.DgvEjemplares.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEjemplares_CellDoubleClick);
            // 
            // picImagen
            // 
            this.picImagen.Location = new System.Drawing.Point(505, 177);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(384, 491);
            this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagen.TabIndex = 8;
            this.picImagen.TabStop = false;
            // 
            // txtBuscarTo
            // 
            this.txtBuscarTo.Location = new System.Drawing.Point(12, 39);
            this.txtBuscarTo.Name = "txtBuscarTo";
            this.txtBuscarTo.Size = new System.Drawing.Size(252, 20);
            this.txtBuscarTo.TabIndex = 10;
            // 
            // btnBuscarTo
            // 
            this.btnBuscarTo.Location = new System.Drawing.Point(270, 38);
            this.btnBuscarTo.Name = "btnBuscarTo";
            this.btnBuscarTo.Size = new System.Drawing.Size(121, 21);
            this.btnBuscarTo.TabIndex = 11;
            this.btnBuscarTo.Text = "Buscar";
            this.btnBuscarTo.UseVisualStyleBackColor = true;
            this.btnBuscarTo.Click += new System.EventHandler(this.btnBuscarNombreCompleto_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(876, 122);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(10, 20);
            this.txtImagen.TabIndex = 12;
            // 
            // grbFiltros
            // 
            this.grbFiltros.Controls.Add(this.chbFormato);
            this.grbFiltros.Controls.Add(this.chbAutores);
            this.grbFiltros.Controls.Add(this.cmbAutores);
            this.grbFiltros.Controls.Add(this.cmbFormato);
            this.grbFiltros.Controls.Add(this.btnFiltrar);
            this.grbFiltros.Location = new System.Drawing.Point(6, 65);
            this.grbFiltros.Name = "grbFiltros";
            this.grbFiltros.Size = new System.Drawing.Size(502, 77);
            this.grbFiltros.TabIndex = 13;
            this.grbFiltros.TabStop = false;
            // 
            // chbFormato
            // 
            this.chbFormato.Location = new System.Drawing.Point(6, 46);
            this.chbFormato.Name = "chbFormato";
            this.chbFormato.Size = new System.Drawing.Size(104, 24);
            this.chbFormato.TabIndex = 1;
            this.chbFormato.Text = "Formato";
            this.chbFormato.UseVisualStyleBackColor = true;
            // 
            // chbAutores
            // 
            this.chbAutores.Location = new System.Drawing.Point(6, 16);
            this.chbAutores.Name = "chbAutores";
            this.chbAutores.Size = new System.Drawing.Size(104, 24);
            this.chbAutores.TabIndex = 0;
            this.chbAutores.Text = "Autores";
            this.chbAutores.UseVisualStyleBackColor = true;
            // 
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(901, 759);
            this.Controls.Add(this.grbFiltros);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnBuscarTo);
            this.Controls.Add(this.txtBuscarTo);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.DgvEjemplares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "frmEjemplares";
            this.Load += new System.EventHandler(this.frmEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picImagen)).EndInit();
            this.grbFiltros.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.CheckBox chbAutores;
        private System.Windows.Forms.CheckBox chbFormato;

        private System.Windows.Forms.GroupBox grbFiltros;

        private System.Windows.Forms.TextBox txtImagen;

        private System.Windows.Forms.Button btnBuscarTo;

        public System.Windows.Forms.TextBox txtBuscarTo;

        private System.Windows.Forms.PictureBox picImagen;

        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.ComboBox cmbFormato;

        public System.Windows.Forms.ComboBox cmbAutores;

        public System.Windows.Forms.DataGridView DgvEjemplares;

        #endregion
    }
}