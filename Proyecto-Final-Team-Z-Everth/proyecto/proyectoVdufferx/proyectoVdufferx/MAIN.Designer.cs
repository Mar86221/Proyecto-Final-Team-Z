using System.ComponentModel;

namespace proyectoVdufferx
{
    partial class MAIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEjemplares = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picTuPrestamo = new System.Windows.Forms.PictureBox();
            this.picTucuenta = new System.Windows.Forms.PictureBox();
            this.grpTuCuenta = new System.Windows.Forms.GroupBox();
            this.PicTuCuentaDatos = new proyectoVdufferx.PictureCircularBox();
            this.txtTucuentaFotografia = new System.Windows.Forms.TextBox();
            this.txtTucuentaTelefono = new System.Windows.Forms.TextBox();
            this.txtTucuentaCorreo = new System.Windows.Forms.TextBox();
            this.txtTucuentaNombre = new System.Windows.Forms.TextBox();
            this.grpTuPrestamo = new System.Windows.Forms.GroupBox();
            this.txtTuprestamoFechaD = new System.Windows.Forms.TextBox();
            this.txtTuprestamoFechaP = new System.Windows.Forms.TextBox();
            this.txtTuprestamoNombreE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picTuPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picTucuenta)).BeginInit();
            this.grpTuCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PicTuCuentaDatos)).BeginInit();
            this.grpTuPrestamo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnEjemplares
            // 
            this.btnEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjemplares.Image = ((System.Drawing.Image) (resources.GetObject("btnEjemplares.Image")));
            this.btnEjemplares.Location = new System.Drawing.Point(64, 274);
            this.btnEjemplares.Name = "btnEjemplares";
            this.btnEjemplares.Size = new System.Drawing.Size(250, 80);
            this.btnEjemplares.TabIndex = 3;
            this.btnEjemplares.UseVisualStyleBackColor = true;
            this.btnEjemplares.Click += new System.EventHandler(this.btnEjemplares_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image) (resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(497, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 80);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // picTuPrestamo
            // 
            this.picTuPrestamo.Image = ((System.Drawing.Image) (resources.GetObject("picTuPrestamo.Image")));
            this.picTuPrestamo.Location = new System.Drawing.Point(544, 0);
            this.picTuPrestamo.Name = "picTuPrestamo";
            this.picTuPrestamo.Size = new System.Drawing.Size(127, 40);
            this.picTuPrestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTuPrestamo.TabIndex = 5;
            this.picTuPrestamo.TabStop = false;
            this.picTuPrestamo.Click += new System.EventHandler(this.picTuPrestamo_Click);
            // 
            // picTucuenta
            // 
            this.picTucuenta.Image = ((System.Drawing.Image) (resources.GetObject("picTucuenta.Image")));
            this.picTucuenta.Location = new System.Drawing.Point(692, 0);
            this.picTucuenta.Name = "picTucuenta";
            this.picTucuenta.Size = new System.Drawing.Size(96, 40);
            this.picTucuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTucuenta.TabIndex = 6;
            this.picTucuenta.TabStop = false;
            this.picTucuenta.Click += new System.EventHandler(this.picTucuenta_Click);
            this.picTucuenta.DoubleClick += new System.EventHandler(this.picTucuenta_DoubleClick);
            // 
            // grpTuCuenta
            // 
            this.grpTuCuenta.Controls.Add(this.PicTuCuentaDatos);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaFotografia);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaTelefono);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaCorreo);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaNombre);
            this.grpTuCuenta.Location = new System.Drawing.Point(577, 46);
            this.grpTuCuenta.Name = "grpTuCuenta";
            this.grpTuCuenta.Size = new System.Drawing.Size(211, 214);
            this.grpTuCuenta.TabIndex = 7;
            this.grpTuCuenta.TabStop = false;
            // 
            // PicTuCuentaDatos
            // 
            this.PicTuCuentaDatos.Location = new System.Drawing.Point(58, 19);
            this.PicTuCuentaDatos.Name = "PicTuCuentaDatos";
            this.PicTuCuentaDatos.Size = new System.Drawing.Size(112, 90);
            this.PicTuCuentaDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTuCuentaDatos.TabIndex = 9;
            this.PicTuCuentaDatos.TabStop = false;
            // 
            // txtTucuentaFotografia
            // 
            this.txtTucuentaFotografia.Location = new System.Drawing.Point(195, 188);
            this.txtTucuentaFotografia.Name = "txtTucuentaFotografia";
            this.txtTucuentaFotografia.Size = new System.Drawing.Size(10, 20);
            this.txtTucuentaFotografia.TabIndex = 8;
            // 
            // txtTucuentaTelefono
            // 
            this.txtTucuentaTelefono.Location = new System.Drawing.Point(11, 167);
            this.txtTucuentaTelefono.Name = "txtTucuentaTelefono";
            this.txtTucuentaTelefono.ReadOnly = true;
            this.txtTucuentaTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTucuentaTelefono.TabIndex = 8;
            // 
            // txtTucuentaCorreo
            // 
            this.txtTucuentaCorreo.Location = new System.Drawing.Point(11, 141);
            this.txtTucuentaCorreo.Name = "txtTucuentaCorreo";
            this.txtTucuentaCorreo.ReadOnly = true;
            this.txtTucuentaCorreo.Size = new System.Drawing.Size(194, 20);
            this.txtTucuentaCorreo.TabIndex = 2;
            // 
            // txtTucuentaNombre
            // 
            this.txtTucuentaNombre.Location = new System.Drawing.Point(11, 115);
            this.txtTucuentaNombre.Name = "txtTucuentaNombre";
            this.txtTucuentaNombre.ReadOnly = true;
            this.txtTucuentaNombre.Size = new System.Drawing.Size(194, 20);
            this.txtTucuentaNombre.TabIndex = 1;
            // 
            // grpTuPrestamo
            // 
            this.grpTuPrestamo.Controls.Add(this.txtTuprestamoFechaD);
            this.grpTuPrestamo.Controls.Add(this.txtTuprestamoFechaP);
            this.grpTuPrestamo.Controls.Add(this.txtTuprestamoNombreE);
            this.grpTuPrestamo.Location = new System.Drawing.Point(310, 57);
            this.grpTuPrestamo.Name = "grpTuPrestamo";
            this.grpTuPrestamo.Size = new System.Drawing.Size(223, 110);
            this.grpTuPrestamo.TabIndex = 8;
            this.grpTuPrestamo.TabStop = false;
            // 
            // txtTuprestamoFechaD
            // 
            this.txtTuprestamoFechaD.Location = new System.Drawing.Point(6, 71);
            this.txtTuprestamoFechaD.Name = "txtTuprestamoFechaD";
            this.txtTuprestamoFechaD.ReadOnly = true;
            this.txtTuprestamoFechaD.Size = new System.Drawing.Size(206, 20);
            this.txtTuprestamoFechaD.TabIndex = 11;
            // 
            // txtTuprestamoFechaP
            // 
            this.txtTuprestamoFechaP.Location = new System.Drawing.Point(6, 45);
            this.txtTuprestamoFechaP.Name = "txtTuprestamoFechaP";
            this.txtTuprestamoFechaP.ReadOnly = true;
            this.txtTuprestamoFechaP.Size = new System.Drawing.Size(206, 20);
            this.txtTuprestamoFechaP.TabIndex = 10;
            // 
            // txtTuprestamoNombreE
            // 
            this.txtTuprestamoNombreE.Location = new System.Drawing.Point(6, 19);
            this.txtTuprestamoNombreE.Name = "txtTuprestamoNombreE";
            this.txtTuprestamoNombreE.ReadOnly = true;
            this.txtTuprestamoNombreE.Size = new System.Drawing.Size(206, 20);
            this.txtTuprestamoNombreE.TabIndex = 9;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTuPrestamo);
            this.Controls.Add(this.grpTuCuenta);
            this.Controls.Add(this.picTucuenta);
            this.Controls.Add(this.picTuPrestamo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEjemplares);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.Click += new System.EventHandler(this.MAIN_Click);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picTuPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picTucuenta)).EndInit();
            this.grpTuCuenta.ResumeLayout(false);
            this.grpTuCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PicTuCuentaDatos)).EndInit();
            this.grpTuPrestamo.ResumeLayout(false);
            this.grpTuPrestamo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public System.Windows.Forms.TextBox txtTuprestamoFechaP;
        public System.Windows.Forms.TextBox txtTuprestamoFechaD;

        public System.Windows.Forms.TextBox txtTuprestamoNombreE;

        private System.Windows.Forms.GroupBox grpTuPrestamo;

        private proyectoVdufferx.PictureCircularBox PicTuCuentaDatos;

        public System.Windows.Forms.TextBox txtTucuentaFotografia;

        public System.Windows.Forms.TextBox txtTucuentaTelefono;

        public System.Windows.Forms.TextBox txtTucuentaCorreo;

        public System.Windows.Forms.TextBox txtTucuentaNombre;

        private System.Windows.Forms.GroupBox grpTuCuenta;

        private System.Windows.Forms.PictureBox picTuPrestamo;

        private System.Windows.Forms.Button btnEjemplares;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox picTucuenta;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}