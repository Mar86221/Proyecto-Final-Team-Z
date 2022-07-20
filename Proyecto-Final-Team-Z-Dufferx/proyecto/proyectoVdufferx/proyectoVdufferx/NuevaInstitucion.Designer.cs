using System.ComponentModel;

namespace proyectoVdufferx
{
    partial class NuevaInstitucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaInstitucion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNovoInstitucion = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.pbOK = new System.Windows.Forms.PictureBox();
            this.cmbOcupacion2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbOK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.label1.Location = new System.Drawing.Point(84, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva Institución";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(102, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa una nueva institución";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNovoInstitucion
            // 
            this.txtNovoInstitucion.BackColor = System.Drawing.Color.White;
            this.txtNovoInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNovoInstitucion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNovoInstitucion.Location = new System.Drawing.Point(42, 108);
            this.txtNovoInstitucion.Name = "txtNovoInstitucion";
            this.txtNovoInstitucion.Size = new System.Drawing.Size(262, 19);
            this.txtNovoInstitucion.TabIndex = 35;
            this.txtNovoInstitucion.Tag = "Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(35, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 30);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbName.Location = new System.Drawing.Point(33, 100);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(283, 34);
            this.pbName.TabIndex = 34;
            this.pbName.TabStop = false;
            // 
            // pbOK
            // 
            this.pbOK.Image = ((System.Drawing.Image) (resources.GetObject("pbOK.Image")));
            this.pbOK.Location = new System.Drawing.Point(122, 186);
            this.pbOK.Name = "pbOK";
            this.pbOK.Size = new System.Drawing.Size(80, 35);
            this.pbOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOK.TabIndex = 36;
            this.pbOK.TabStop = false;
            this.pbOK.Click += new System.EventHandler(this.pbOK_Click);
            // 
            // cmbOcupacion2
            // 
            this.cmbOcupacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcupacion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOcupacion2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbOcupacion2.FormattingEnabled = true;
            this.cmbOcupacion2.Items.AddRange(new object[] {"Estudiante", "Trabajador", "Desempleado"});
            this.cmbOcupacion2.Location = new System.Drawing.Point(106, 145);
            this.cmbOcupacion2.Name = "cmbOcupacion2";
            this.cmbOcupacion2.Size = new System.Drawing.Size(111, 26);
            this.cmbOcupacion2.TabIndex = 37;
            // 
            // NuevaInstitucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 233);
            this.Controls.Add(this.cmbOcupacion2);
            this.Controls.Add(this.pbOK);
            this.Controls.Add(this.txtNovoInstitucion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NuevaInstitucion";
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbOcupacion2;

        private System.Windows.Forms.PictureBox pbOK;

        public System.Windows.Forms.TextBox txtNovoInstitucion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbName;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}