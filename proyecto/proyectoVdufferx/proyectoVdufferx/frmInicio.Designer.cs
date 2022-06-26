namespace proyectoVdufferx
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picRegistrarme = new System.Windows.Forms.PictureBox();
            this.picIngresar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picRegistrarme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picIngresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picRegistrarme
            // 
            this.picRegistrarme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRegistrarme.Image = ((System.Drawing.Image) (resources.GetObject("picRegistrarme.Image")));
            this.picRegistrarme.Location = new System.Drawing.Point(225, 312);
            this.picRegistrarme.Name = "picRegistrarme";
            this.picRegistrarme.Size = new System.Drawing.Size(330, 44);
            this.picRegistrarme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRegistrarme.TabIndex = 1;
            this.picRegistrarme.TabStop = false;
            this.picRegistrarme.Click += new System.EventHandler(this.picRegistrarme_Click);
            // 
            // picIngresar
            // 
            this.picIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIngresar.Image = ((System.Drawing.Image) (resources.GetObject("picIngresar.Image")));
            this.picIngresar.Location = new System.Drawing.Point(225, 372);
            this.picIngresar.Name = "picIngresar";
            this.picIngresar.Size = new System.Drawing.Size(329, 41);
            this.picIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picIngresar.TabIndex = 2;
            this.picIngresar.TabStop = false;
            this.picIngresar.Click += new System.EventHandler(this.picIngresar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picIngresar);
            this.Controls.Add(this.picRegistrarme);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picRegistrarme)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picIngresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox picIngresar;

        public System.Windows.Forms.PictureBox picRegistrarme;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}