using System.ComponentModel;

namespace proyectoVdufferx;

partial class frmNuevaColeccion
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
        this.txtNombre = new System.Windows.Forms.TextBox();
        this.cmbGenero = new System.Windows.Forms.ComboBox();
        this.cmbTipo = new System.Windows.Forms.ComboBox();
        this.SuspendLayout();
        // 
        // txtNombre
        // 
        this.txtNombre.Location = new System.Drawing.Point(12, 51);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(154, 20);
        this.txtNombre.TabIndex = 0;
        // 
        // cmbGenero
        // 
        this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbGenero.FormattingEnabled = true;
        this.cmbGenero.Location = new System.Drawing.Point(12, 115);
        this.cmbGenero.Name = "cmbGenero";
        this.cmbGenero.Size = new System.Drawing.Size(154, 21);
        this.cmbGenero.TabIndex = 1;
        // 
        // cmbTipo
        // 
        this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbTipo.FormattingEnabled = true;
        this.cmbTipo.Location = new System.Drawing.Point(12, 172);
        this.cmbTipo.Name = "cmbTipo";
        this.cmbTipo.Size = new System.Drawing.Size(154, 21);
        this.cmbTipo.TabIndex = 2;
        // 
        // frmNuevaColeccion
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.cmbTipo);
        this.Controls.Add(this.cmbGenero);
        this.Controls.Add(this.txtNombre);
        this.Name = "frmNuevaColeccion";
        this.Text = "frmNuevaColeccion";
        this.Load += new System.EventHandler(this.frmNuevaColeccion_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    public System.Windows.Forms.ComboBox cmbGenero;
    public System.Windows.Forms.ComboBox cmbTipo;

    public System.Windows.Forms.TextBox txtNombre;

    #endregion
}