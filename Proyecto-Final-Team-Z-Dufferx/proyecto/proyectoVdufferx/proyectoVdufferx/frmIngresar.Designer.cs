using System.ComponentModel;

namespace proyectoVdufferx
{
    partial class frmIngresar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttIngresar = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbIngresar2 = new System.Windows.Forms.PictureBox();
            this.pbRegistrarUsuario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.bttIngresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbIngresar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbRegistrarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblCor
            // 
            this.lblCor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCor.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblCor.Location = new System.Drawing.Point(61, 266);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(164, 16);
            this.lblCor.TabIndex = 60;
            this.lblCor.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCorreo.Location = new System.Drawing.Point(50, 287);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(259, 19);
            this.txtCorreo.TabIndex = 59;
            this.txtCorreo.Tag = "Cor";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(41, 275);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(279, 40);
            this.pictureBox7.TabIndex = 57;
            this.pictureBox7.TabStop = false;
            // 
            // pbCor
            // 
            this.pbCor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbCor.Location = new System.Drawing.Point(39, 273);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(283, 44);
            this.pbCor.TabIndex = 58;
            this.pbCor.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.label1.Location = new System.Drawing.Point(121, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 61;
            this.label1.Text = "Ingreso";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(86, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ingresa tu correo electrónico relacionado con tu cuenta.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttIngresar
            // 
            this.bttIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttIngresar.Image = ((System.Drawing.Image) (resources.GetObject("bttIngresar.Image")));
            this.bttIngresar.Location = new System.Drawing.Point(133, 340);
            this.bttIngresar.Name = "bttIngresar";
            this.bttIngresar.Size = new System.Drawing.Size(87, 36);
            this.bttIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bttIngresar.TabIndex = 63;
            this.bttIngresar.TabStop = false;
            this.bttIngresar.Click += new System.EventHandler(this.bttIngresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            // 
            // pbIngresar2
            // 
            this.pbIngresar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIngresar2.Image = ((System.Drawing.Image) (resources.GetObject("pbIngresar2.Image")));
            this.pbIngresar2.Location = new System.Drawing.Point(198, 404);
            this.pbIngresar2.Name = "pbIngresar2";
            this.pbIngresar2.Size = new System.Drawing.Size(137, 34);
            this.pbIngresar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIngresar2.TabIndex = 65;
            this.pbIngresar2.TabStop = false;
            this.pbIngresar2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbRegistrarUsuario
            // 
            this.pbRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRegistrarUsuario.Image = ((System.Drawing.Image) (resources.GetObject("pbRegistrarUsuario.Image")));
            this.pbRegistrarUsuario.Location = new System.Drawing.Point(3, 404);
            this.pbRegistrarUsuario.Name = "pbRegistrarUsuario";
            this.pbRegistrarUsuario.Size = new System.Drawing.Size(175, 34);
            this.pbRegistrarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRegistrarUsuario.TabIndex = 66;
            this.pbRegistrarUsuario.TabStop = false;
            this.pbRegistrarUsuario.Click += new System.EventHandler(this.pbRegistrarUsuario_Click);
            // 
            // frmIngresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.pbRegistrarUsuario);
            this.Controls.Add(this.pbIngresar2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttIngresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pbCor);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmIngresar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmIngresar_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.bttIngresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbIngresar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbRegistrarUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pbRegistrarUsuario;

        private System.Windows.Forms.PictureBox pbIngresar2;

        private System.Windows.Forms.ErrorProvider errorCorreo;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox bttIngresar;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblCor;
        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbCor;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}