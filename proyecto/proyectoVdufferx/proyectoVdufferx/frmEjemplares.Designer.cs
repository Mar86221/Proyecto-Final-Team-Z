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
            this.btnFiltrarAu = new System.Windows.Forms.Button();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btnFiltrarF = new System.Windows.Forms.Button();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.DgvEjemplares = new System.Windows.Forms.DataGridView();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.txtBuscarNombreCompleto = new System.Windows.Forms.TextBox();
            this.btnBuscarNombreCompleto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrarAu
            // 
            this.btnFiltrarAu.Location = new System.Drawing.Point(12, 124);
            this.btnFiltrarAu.Name = "btnFiltrarAu";
            this.btnFiltrarAu.Size = new System.Drawing.Size(120, 37);
            this.btnFiltrarAu.TabIndex = 1;
            this.btnFiltrarAu.Text = "Filtrar por autor";
            this.btnFiltrarAu.UseVisualStyleBackColor = true;
            this.btnFiltrarAu.Click += new System.EventHandler(this.btnFiltrarAu_Click);
            // 
            // cmbAutores
            // 
            this.cmbAutores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.Location = new System.Drawing.Point(138, 133);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(126, 21);
            this.cmbAutores.TabIndex = 2;
            // 
            // btnFiltrarF
            // 
            this.btnFiltrarF.Location = new System.Drawing.Point(12, 81);
            this.btnFiltrarF.Name = "btnFiltrarF";
            this.btnFiltrarF.Size = new System.Drawing.Size(120, 37);
            this.btnFiltrarF.TabIndex = 3;
            this.btnFiltrarF.Text = "Filtrar por formato";
            this.btnFiltrarF.UseVisualStyleBackColor = true;
            this.btnFiltrarF.Click += new System.EventHandler(this.btnFiltrarF_Click);
            // 
            // cmbFormato
            // 
            this.cmbFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(138, 90);
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
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(685, 12);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(17, 20);
            this.txtImagen.TabIndex = 9;
            // 
            // txtBuscarNombreCompleto
            // 
            this.txtBuscarNombreCompleto.Location = new System.Drawing.Point(12, 30);
            this.txtBuscarNombreCompleto.Name = "txtBuscarNombreCompleto";
            this.txtBuscarNombreCompleto.Size = new System.Drawing.Size(243, 20);
            this.txtBuscarNombreCompleto.TabIndex = 10;
            // 
            // btnBuscarNombreCompleto
            // 
            this.btnBuscarNombreCompleto.Location = new System.Drawing.Point(270, 28);
            this.btnBuscarNombreCompleto.Name = "btnBuscarNombreCompleto";
            this.btnBuscarNombreCompleto.Size = new System.Drawing.Size(121, 21);
            this.btnBuscarNombreCompleto.TabIndex = 11;
            this.btnBuscarNombreCompleto.Text = "button1";
            this.btnBuscarNombreCompleto.UseVisualStyleBackColor = true;
            // 
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 759);
            this.Controls.Add(this.btnBuscarNombreCompleto);
            this.Controls.Add(this.txtBuscarNombreCompleto);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.picImagen);
            this.Controls.Add(this.cmbFormato);
            this.Controls.Add(this.btnFiltrarF);
            this.Controls.Add(this.cmbAutores);
            this.Controls.Add(this.btnFiltrarAu);
            this.Controls.Add(this.DgvEjemplares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEjemplares";
            this.Text = "frmEjemplares";
            this.Load += new System.EventHandler(this.frmEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnBuscarNombreCompleto;

        public System.Windows.Forms.TextBox txtBuscarNombreCompleto;

        private System.Windows.Forms.TextBox txtImagen;

        private System.Windows.Forms.PictureBox picImagen;

        public System.Windows.Forms.Button btnFiltrarF;
        public System.Windows.Forms.ComboBox cmbFormato;

        public System.Windows.Forms.Button btnFiltrarAu;
        public System.Windows.Forms.ComboBox cmbAutores;

        public System.Windows.Forms.DataGridView DgvEjemplares;

        #endregion
    }
}