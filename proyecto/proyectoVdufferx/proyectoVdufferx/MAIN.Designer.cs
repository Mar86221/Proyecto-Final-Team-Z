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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picTucuenta = new System.Windows.Forms.PictureBox();
            this.grpTuCuenta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PicTuCuentaDatos = new proyectoVdufferx.PictureCircularBox();
            this.txtTucuentaFotografia = new System.Windows.Forms.TextBox();
            this.txtTucuentaTelefono = new System.Windows.Forms.TextBox();
            this.txtTucuentaCorreo = new System.Windows.Forms.TextBox();
            this.txtTucuentaNombre = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grpTuPrestamo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuprestamoFechaD = new System.Windows.Forms.TextBox();
            this.txtTuprestamoFechaP = new System.Windows.Forms.TextBox();
            this.txtTuprestamoNombreE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picTucuenta)).BeginInit();
            this.grpTuCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PicTuCuentaDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
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
            this.btnEjemplares.Location = new System.Drawing.Point(64, 292);
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
            this.button1.Location = new System.Drawing.Point(481, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 80);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(559, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
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
            this.grpTuCuenta.BackColor = System.Drawing.Color.AliceBlue;
            this.grpTuCuenta.Controls.Add(this.label3);
            this.grpTuCuenta.Controls.Add(this.label2);
            this.grpTuCuenta.Controls.Add(this.label1);
            this.grpTuCuenta.Controls.Add(this.PicTuCuentaDatos);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaFotografia);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaTelefono);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaCorreo);
            this.grpTuCuenta.Controls.Add(this.txtTucuentaNombre);
            this.grpTuCuenta.ForeColor = System.Drawing.Color.Black;
            this.grpTuCuenta.Location = new System.Drawing.Point(577, 46);
            this.grpTuCuenta.Name = "grpTuCuenta";
            this.grpTuCuenta.Size = new System.Drawing.Size(211, 220);
            this.grpTuCuenta.TabIndex = 7;
            this.grpTuCuenta.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(11, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(9, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teléfono";
            // 
            // PicTuCuentaDatos
            // 
            this.PicTuCuentaDatos.Location = new System.Drawing.Point(59, 8);
            this.PicTuCuentaDatos.Name = "PicTuCuentaDatos";
            this.PicTuCuentaDatos.Size = new System.Drawing.Size(112, 90);
            this.PicTuCuentaDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTuCuentaDatos.TabIndex = 9;
            this.PicTuCuentaDatos.TabStop = false;
            // 
            // txtTucuentaFotografia
            // 
            this.txtTucuentaFotografia.Location = new System.Drawing.Point(195, 88);
            this.txtTucuentaFotografia.Name = "txtTucuentaFotografia";
            this.txtTucuentaFotografia.Size = new System.Drawing.Size(10, 20);
            this.txtTucuentaFotografia.TabIndex = 8;
            // 
            // txtTucuentaTelefono
            // 
            this.txtTucuentaTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTucuentaTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTucuentaTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTucuentaTelefono.Location = new System.Drawing.Point(9, 190);
            this.txtTucuentaTelefono.Name = "txtTucuentaTelefono";
            this.txtTucuentaTelefono.ReadOnly = true;
            this.txtTucuentaTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTucuentaTelefono.TabIndex = 8;
            // 
            // txtTucuentaCorreo
            // 
            this.txtTucuentaCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTucuentaCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTucuentaCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTucuentaCorreo.Location = new System.Drawing.Point(9, 152);
            this.txtTucuentaCorreo.Name = "txtTucuentaCorreo";
            this.txtTucuentaCorreo.ReadOnly = true;
            this.txtTucuentaCorreo.Size = new System.Drawing.Size(194, 20);
            this.txtTucuentaCorreo.TabIndex = 2;
            // 
            // txtTucuentaNombre
            // 
            this.txtTucuentaNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtTucuentaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTucuentaNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTucuentaNombre.Location = new System.Drawing.Point(11, 115);
            this.txtTucuentaNombre.Name = "txtTucuentaNombre";
            this.txtTucuentaNombre.ReadOnly = true;
            this.txtTucuentaNombre.Size = new System.Drawing.Size(194, 20);
            this.txtTucuentaNombre.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(163, 378);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(588, 378);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // grpTuPrestamo
            // 
            this.grpTuPrestamo.BackColor = System.Drawing.Color.AliceBlue;
            this.grpTuPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpTuPrestamo.Controls.Add(this.label6);
            this.grpTuPrestamo.Controls.Add(this.label5);
            this.grpTuPrestamo.Controls.Add(this.label4);
            this.grpTuPrestamo.Controls.Add(this.txtTuprestamoFechaD);
            this.grpTuPrestamo.Controls.Add(this.txtTuprestamoFechaP);
            this.grpTuPrestamo.Controls.Add(this.txtTuprestamoNombreE);
            this.grpTuPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpTuPrestamo.Location = new System.Drawing.Point(331, 46);
            this.grpTuPrestamo.Name = "grpTuPrestamo";
            this.grpTuPrestamo.Size = new System.Drawing.Size(224, 172);
            this.grpTuPrestamo.TabIndex = 10;
            this.grpTuPrestamo.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(12, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fecha devolución";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 14);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha Préstamo";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(11, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ejemplar";
            // 
            // txtTuprestamoFechaD
            // 
            this.txtTuprestamoFechaD.BackColor = System.Drawing.SystemColors.Window;
            this.txtTuprestamoFechaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuprestamoFechaD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTuprestamoFechaD.Location = new System.Drawing.Point(12, 118);
            this.txtTuprestamoFechaD.Name = "txtTuprestamoFechaD";
            this.txtTuprestamoFechaD.ReadOnly = true;
            this.txtTuprestamoFechaD.Size = new System.Drawing.Size(194, 20);
            this.txtTuprestamoFechaD.TabIndex = 10;
            // 
            // txtTuprestamoFechaP
            // 
            this.txtTuprestamoFechaP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTuprestamoFechaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuprestamoFechaP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTuprestamoFechaP.Location = new System.Drawing.Point(12, 76);
            this.txtTuprestamoFechaP.Name = "txtTuprestamoFechaP";
            this.txtTuprestamoFechaP.ReadOnly = true;
            this.txtTuprestamoFechaP.Size = new System.Drawing.Size(194, 20);
            this.txtTuprestamoFechaP.TabIndex = 10;
            // 
            // txtTuprestamoNombreE
            // 
            this.txtTuprestamoNombreE.BackColor = System.Drawing.SystemColors.Window;
            this.txtTuprestamoNombreE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTuprestamoNombreE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTuprestamoNombreE.Location = new System.Drawing.Point(12, 35);
            this.txtTuprestamoNombreE.Name = "txtTuprestamoNombreE";
            this.txtTuprestamoNombreE.ReadOnly = true;
            this.txtTuprestamoNombreE.Size = new System.Drawing.Size(194, 20);
            this.txtTuprestamoNombreE.TabIndex = 10;
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTuPrestamo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.grpTuCuenta);
            this.Controls.Add(this.picTucuenta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEjemplares);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.Click += new System.EventHandler(this.MAIN_Click);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picTucuenta)).EndInit();
            this.grpTuCuenta.ResumeLayout(false);
            this.grpTuCuenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.PicTuCuentaDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            this.grpTuPrestamo.ResumeLayout(false);
            this.grpTuPrestamo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        public System.Windows.Forms.TextBox txtTuprestamoNombreE;
        public System.Windows.Forms.TextBox txtTuprestamoFechaP;
        public System.Windows.Forms.TextBox txtTuprestamoFechaD;

        private System.Windows.Forms.GroupBox grpTuPrestamo;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.PictureBox pictureBox3;

        private proyectoVdufferx.PictureCircularBox PicTuCuentaDatos;

        public System.Windows.Forms.TextBox txtTucuentaFotografia;

        public System.Windows.Forms.TextBox txtTucuentaTelefono;

        public System.Windows.Forms.TextBox txtTucuentaCorreo;

        public System.Windows.Forms.TextBox txtTucuentaNombre;

        private System.Windows.Forms.GroupBox grpTuCuenta;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button btnEjemplares;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.PictureBox picTucuenta;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}