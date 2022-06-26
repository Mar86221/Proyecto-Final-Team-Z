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
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picImagen)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvEventos
        // 
        this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEventos.Location = new System.Drawing.Point(12, 20);
        this.dgvEventos.Name = "dgvEventos";
        this.dgvEventos.Size = new System.Drawing.Size(526, 373);
        this.dgvEventos.TabIndex = 0;
        this.dgvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEventos_CellClick);
        // 
        // picImagen
        // 
        this.picImagen.Location = new System.Drawing.Point(574, 20);
        this.picImagen.Name = "picImagen";
        this.picImagen.Size = new System.Drawing.Size(259, 373);
        this.picImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.picImagen.TabIndex = 1;
        this.picImagen.TabStop = false;
        // 
        // txtImagen
        // 
        this.txtImagen.Location = new System.Drawing.Point(544, 273);
        this.txtImagen.Name = "txtImagen";
        this.txtImagen.Size = new System.Drawing.Size(10, 20);
        this.txtImagen.TabIndex = 2;
        // 
        // frmEventos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(836, 480);
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

    private System.Windows.Forms.TextBox txtImagen;

    public System.Windows.Forms.PictureBox picImagen;

    private System.Windows.Forms.DataGridView dgvEventos;

    #endregion
}