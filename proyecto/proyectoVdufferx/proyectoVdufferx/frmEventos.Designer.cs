using System.ComponentModel;

namespace proyectoVdufferx;

partial class frmEventos
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
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
        System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventos));
        this.dgvEventos = new System.Windows.Forms.DataGridView();
        this.picImagen = new System.Windows.Forms.PictureBox();
        this.txtImagen = new System.Windows.Forms.TextBox();
        this.btnInsertar = new System.Windows.Forms.PictureBox();
        this.btnEliminar = new System.Windows.Forms.PictureBox();
        this.txtTituloEliminar = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.pictureBox10 = new System.Windows.Forms.PictureBox();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label5 = new System.Windows.Forms.Label();
        this.txtCuentaU = new System.Windows.Forms.TextBox();
        this.picEditar = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.btnInsertar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.btnEliminar)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picEditar)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvEventos
        // 
        this.dgvEventos.BackgroundColor = System.Drawing.Color.White;
        this.dgvEventos.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dgvEventos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvEventos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEventos.Cursor = System.Windows.Forms.Cursors.Hand;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.dgvEventos.DefaultCellStyle = dataGridViewCellStyle2;
        this.dgvEventos.Location = new System.Drawing.Point(12, 26);
        this.dgvEventos.Name = "dgvEventos";
        this.dgvEventos.Size = new System.Drawing.Size(525, 373);
        this.dgvEventos.TabIndex = 0;
        this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
        // 
        // picImagen
        // 
        this.picImagen.Location = new System.Drawing.Point(559, 26);
        this.picImagen.Name = "picImagen";
        this.picImagen.Size = new System.Drawing.Size(259, 373);
        this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.picImagen.TabIndex = 1;
        this.picImagen.TabStop = false;
        // 
        // txtImagen
        // 
        this.txtImagen.Location = new System.Drawing.Point(543, 268);
        this.txtImagen.Name = "txtImagen";
        this.txtImagen.Size = new System.Drawing.Size(10, 20);
        this.txtImagen.TabIndex = 2;
        // 
        // btnInsertar
        // 
        this.btnInsertar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnInsertar.Image = ((System.Drawing.Image) (resources.GetObject("btnInsertar.Image")));
        this.btnInsertar.Location = new System.Drawing.Point(26, 418);
        this.btnInsertar.Name = "btnInsertar";
        this.btnInsertar.Size = new System.Drawing.Size(154, 36);
        this.btnInsertar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.btnInsertar.TabIndex = 3;
        this.btnInsertar.TabStop = false;
        this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
        // 
        // btnEliminar
        // 
        this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.btnEliminar.Image = ((System.Drawing.Image) (resources.GetObject("btnEliminar.Image")));
        this.btnEliminar.Location = new System.Drawing.Point(242, 418);
        this.btnEliminar.Name = "btnEliminar";
        this.btnEliminar.Size = new System.Drawing.Size(113, 35);
        this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.btnEliminar.TabIndex = 4;
        this.btnEliminar.TabStop = false;
        this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
        // 
        // txtTituloEliminar
        // 
        this.txtTituloEliminar.Location = new System.Drawing.Point(586, 417);
        this.txtTituloEliminar.Name = "txtTituloEliminar";
        this.txtTituloEliminar.Size = new System.Drawing.Size(114, 20);
        this.txtTituloEliminar.TabIndex = 5;
        // 
        // label2
        // 
        this.label2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label2.ForeColor = System.Drawing.Color.White;
        this.label2.Location = new System.Drawing.Point(150, 26);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(92, 19);
        this.label2.TabIndex = 90;
        this.label2.Text = "ASISTENTES";
        this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        this.label1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label1.ForeColor = System.Drawing.Color.White;
        this.label1.Location = new System.Drawing.Point(50, 26);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(104, 19);
        this.label1.TabIndex = 89;
        this.label1.Text = "TÍTULO";
        this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // pictureBox10
        // 
        this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.pictureBox10.Location = new System.Drawing.Point(12, 26);
        this.pictureBox10.Name = "pictureBox10";
        this.pictureBox10.Size = new System.Drawing.Size(38, 19);
        this.pictureBox10.TabIndex = 88;
        this.pictureBox10.TabStop = false;
        // 
        // label3
        // 
        this.label3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label3.ForeColor = System.Drawing.Color.White;
        this.label3.Location = new System.Drawing.Point(242, 26);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(89, 19);
        this.label3.TabIndex = 91;
        this.label3.Text = "INICIO";
        this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        this.label4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label4.ForeColor = System.Drawing.Color.White;
        this.label4.Location = new System.Drawing.Point(331, 26);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(89, 19);
        this.label4.TabIndex = 92;
        this.label4.Text = "FINAL";
        this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label5
        // 
        this.label5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label5.ForeColor = System.Drawing.Color.White;
        this.label5.Location = new System.Drawing.Point(420, 26);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(117, 19);
        this.label5.TabIndex = 93;
        this.label5.Text = "AREA";
        this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // txtCuentaU
        // 
        this.txtCuentaU.Location = new System.Drawing.Point(527, 366);
        this.txtCuentaU.Name = "txtCuentaU";
        this.txtCuentaU.Size = new System.Drawing.Size(26, 20);
        this.txtCuentaU.TabIndex = 94;
        // 
        // picEditar
        // 
        this.picEditar.Cursor = System.Windows.Forms.Cursors.Hand;
        this.picEditar.Image = ((System.Drawing.Image) (resources.GetObject("picEditar.Image")));
        this.picEditar.Location = new System.Drawing.Point(424, 417);
        this.picEditar.Name = "picEditar";
        this.picEditar.Size = new System.Drawing.Size(113, 35);
        this.picEditar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.picEditar.TabIndex = 95;
        this.picEditar.TabStop = false;
        this.picEditar.Click += new System.EventHandler(this.pictureBox1_Click);
        // 
        // frmEventos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Window;
        this.ClientSize = new System.Drawing.Size(828, 480);
        this.Controls.Add(this.picEditar);
        this.Controls.Add(this.txtCuentaU);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.pictureBox10);
        this.Controls.Add(this.txtTituloEliminar);
        this.Controls.Add(this.btnEliminar);
        this.Controls.Add(this.btnInsertar);
        this.Controls.Add(this.txtImagen);
        this.Controls.Add(this.picImagen);
        this.Controls.Add(this.dgvEventos);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.Name = "frmEventos";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Load += new System.EventHandler(this.frmEventos_Load_1);
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.btnInsertar)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.btnEliminar)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox10)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.picEditar)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.PictureBox picEditar;

    public System.Windows.Forms.TextBox txtCuentaU;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox10;

    public System.Windows.Forms.TextBox txtTituloEliminar;

    private System.Windows.Forms.PictureBox btnEliminar;

    private System.Windows.Forms.PictureBox btnInsertar;

    private System.Windows.Forms.TextBox txtImagen;

    public System.Windows.Forms.PictureBox picImagen;

    private System.Windows.Forms.DataGridView dgvEventos;

    #endregion
}