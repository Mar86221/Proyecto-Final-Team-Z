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
            this.DgvEjemplares = new System.Windows.Forms.DataGridView();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnFiltrarAu = new System.Windows.Forms.Button();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btnFiltrarF = new System.Windows.Forms.Button();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEjemplares
            // 
            this.DgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEjemplares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Imagen});
            this.DgvEjemplares.Location = new System.Drawing.Point(12, 177);
            this.DgvEjemplares.Name = "DgvEjemplares";
            this.DgvEjemplares.Size = new System.Drawing.Size(877, 261);
            this.DgvEjemplares.TabIndex = 0;
            // 
            // Imagen
            // 
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
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
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
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
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewImageColumn Imagen;

        private System.Windows.Forms.Button btnFiltrarF;
        private System.Windows.Forms.ComboBox cmbFormato;

        private System.Windows.Forms.Button btnFiltrarAu;
        private System.Windows.Forms.ComboBox cmbAutores;

        private System.Windows.Forms.DataGridView DgvEjemplares;

        #endregion
    }
}