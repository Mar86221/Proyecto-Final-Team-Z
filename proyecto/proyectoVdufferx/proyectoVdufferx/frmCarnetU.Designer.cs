using System.ComponentModel;

namespace proyectoVdufferx
{
    partial class frmCarnetU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnetU));
            this.txtCorreoQR = new System.Windows.Forms.TextBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNombreQR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.picQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreoQR
            // 
            this.txtCorreoQR.BackColor = System.Drawing.Color.White;
            this.txtCorreoQR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreoQR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCorreoQR.Location = new System.Drawing.Point(107, 402);
            this.txtCorreoQR.Name = "txtCorreoQR";
            this.txtCorreoQR.ReadOnly = true;
            this.txtCorreoQR.Size = new System.Drawing.Size(183, 19);
            this.txtCorreoQR.TabIndex = 63;
            this.txtCorreoQR.Tag = "Cor";
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(139, 275);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(132, 121);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 70;
            this.picQR.TabStop = false;
            // 
            // picMain
            // 
            this.picMain.Image = ((System.Drawing.Image) (resources.GetObject("picMain.Image")));
            this.picMain.Location = new System.Drawing.Point(298, 424);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(42, 44);
            this.picMain.TabIndex = 72;
            this.picMain.TabStop = false;
            this.picMain.Click += new System.EventHandler(this.picMain_Click);
            // 
            // picUser
            // 
            this.picUser.Location = new System.Drawing.Point(139, 12);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(122, 122);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 75;
            this.picUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 77;
            this.pictureBox2.TabStop = false;
            // 
            // txtNombreQR
            // 
            this.txtNombreQR.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (74)))), ((int) (((byte) (173)))));
            this.txtNombreQR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreQR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNombreQR.ForeColor = System.Drawing.Color.White;
            this.txtNombreQR.Location = new System.Drawing.Point(172, 224);
            this.txtNombreQR.Name = "txtNombreQR";
            this.txtNombreQR.Size = new System.Drawing.Size(159, 19);
            this.txtNombreQR.TabIndex = 78;
            // 
            // frmCarnetU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(352, 465);
            this.Controls.Add(this.txtNombreQR);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picMain);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.txtCorreoQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "frmCarnetU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet_Usuario";
            ((System.ComponentModel.ISupportInitialize) (this.picQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.PictureBox pictureBox1;

        public System.Windows.Forms.PictureBox picUser;

        private System.Windows.Forms.PictureBox picMain;

        public System.Windows.Forms.PictureBox picQR;

        public System.Windows.Forms.TextBox txtNombreQR;

        public System.Windows.Forms.TextBox txtCorreoQR;

        #endregion
    }
}