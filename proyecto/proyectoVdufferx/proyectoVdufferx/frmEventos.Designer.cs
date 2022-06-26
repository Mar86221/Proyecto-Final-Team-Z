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
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvEventos
        // 
        this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEventos.Location = new System.Drawing.Point(12, 65);
        this.dgvEventos.Name = "dgvEventos";
        this.dgvEventos.Size = new System.Drawing.Size(595, 373);
        this.dgvEventos.TabIndex = 0;
        // 
        // frmEventos
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(836, 450);
        this.Controls.Add(this.dgvEventos);
        this.Name = "frmEventos";
        this.Text = "frmEventos";
        this.Load += new System.EventHandler(this.frmEventos_Load_1);
        ((System.ComponentModel.ISupportInitialize) (this.dgvEventos)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dgvEventos;

    #endregion
}