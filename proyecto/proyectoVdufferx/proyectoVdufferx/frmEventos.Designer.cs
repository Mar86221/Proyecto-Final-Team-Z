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
        this.dgvEventos = new System.Windows.Forms.DataGridView();
        this.picImagen = new System.Windows.Forms.PictureBox();
        this.txtImagen = new System.Windows.Forms.TextBox();
        this.btnInsertar = new System.Windows.Forms.Button();
        this.txtTituloEliminar = new System.Windows.Forms.TextBox();
        this.btnEliminar = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvEventos
        // 
        this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEventos.Location = new System.Drawing.Point(12, 105);
        this.dgvEventos.Name = "dgvEventos";
        this.dgvEventos.Size = new System.Drawing.Size(626, 363);
        this.dgvEventos.TabIndex = 0;
        this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
        // 
        // picImagen
        // 
        this.picImagen.Location = new System.Drawing.Point(660, 105);
        this.picImagen.Name = "picImagen";
        this.picImagen.Size = new System.Drawing.Size(264, 363);
        this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.picImagen.TabIndex = 1;
        this.picImagen.TabStop = false;
        // 
        // txtImagen
        // 
        this.txtImagen.Location = new System.Drawing.Point(644, 458);
        this.txtImagen.Name = "txtImagen";
        this.txtImagen.Size = new System.Drawing.Size(10, 20);
        this.txtImagen.TabIndex = 2;
        // 
        // btnInsertar
        // 
        this.btnInsertar.Location = new System.Drawing.Point(12, 45);
        this.btnInsertar.Name = "btnInsertar";
        this.btnInsertar.Size = new System.Drawing.Size(145, 20);
        this.btnInsertar.TabIndex = 4;
        this.btnInsertar.Text = "Nuevo Evento";
        this.btnInsertar.UseVisualStyleBackColor = true;
        this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
        // 
        // txtTituloEliminar
        // 
        this.txtTituloEliminar.Location = new System.Drawing.Point(644, 432);
        this.txtTituloEliminar.Name = "txtTituloEliminar";
        this.txtTituloEliminar.Size = new System.Drawing.Size(10, 20);
        this.txtTituloEliminar.TabIndex = 5;
        // 
        // btnEliminar
        // 
        this.btnEliminar.Location = new System.Drawing.Point(184, 45);
        this.btnEliminar.Name = "btnEliminar";
        this.btnEliminar.Size = new System.Drawing.Size(101, 20);
        this.btnEliminar.TabIndex = 6;
        this.btnEliminar.Text = "Eliminar";
        this.btnEliminar.UseVisualStyleBackColor = true;
        this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        // 
        // frmEventos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(936, 480);
        this.Controls.Add(this.btnEliminar);
        this.Controls.Add(this.txtTituloEliminar);
        this.Controls.Add(this.btnInsertar);
        this.Controls.Add(this.txtImagen);
        this.Controls.Add(this.picImagen);
        this.Controls.Add(this.dgvEventos);
        this.Name = "frmEventos";
        this.Text = "frmEventos";
        this.Load += new System.EventHandler(this.frmEventos_Load_1);
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnEliminar;

    public System.Windows.Forms.TextBox txtTituloEliminar;

    private System.Windows.Forms.Button btnInsertar;

    private System.Windows.Forms.TextBox txtImagen;

    public System.Windows.Forms.PictureBox picImagen;

    private System.Windows.Forms.DataGridView dgvEventos;

    #endregion
}