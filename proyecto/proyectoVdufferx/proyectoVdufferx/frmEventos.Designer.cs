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
        // frmEventos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(936, 480);
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

    private System.Windows.Forms.Button btnInsertar;

    private System.Windows.Forms.TextBox txtImagen;

    public System.Windows.Forms.PictureBox picImagen;

    private System.Windows.Forms.DataGridView dgvEventos;

    #endregion
}