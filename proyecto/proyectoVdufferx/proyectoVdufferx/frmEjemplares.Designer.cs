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
            this.button1 = new System.Windows.Forms.Button();
            this.Autores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvEjemplares
            // 
            this.DgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEjemplares.Location = new System.Drawing.Point(12, 177);
            this.DgvEjemplares.Name = "DgvEjemplares";
            this.DgvEjemplares.Size = new System.Drawing.Size(877, 261);
            this.DgvEjemplares.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Filtrar por autor";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Autores
            // 
            this.Autores.FormattingEnabled = true;
            this.Autores.Location = new System.Drawing.Point(138, 124);
            this.Autores.Name = "Autores";
            this.Autores.Size = new System.Drawing.Size(115, 21);
            this.Autores.TabIndex = 2;
            // 
            // frmEjemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.Autores);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvEjemplares);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEjemplares";
            this.Text = "frmEjemplares";
            this.Load += new System.EventHandler(this.frmEjemplares_Load);
            ((System.ComponentModel.ISupportInitialize) (this.DgvEjemplares)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Autores;

        private System.Windows.Forms.DataGridView DgvEjemplares;

        #endregion
    }
}