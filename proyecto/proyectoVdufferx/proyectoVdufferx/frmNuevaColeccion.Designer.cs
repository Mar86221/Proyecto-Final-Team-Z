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
        this.button1 = new System.Windows.Forms.Button();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.lblN = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // txtNombre
        // 
        this.txtNombre.Location = new System.Drawing.Point(40, 102);
        this.txtNombre.Name = "txtNombre";
        this.txtNombre.Size = new System.Drawing.Size(154, 20);
        this.txtNombre.TabIndex = 0;
        // 
        // cmbGenero
        // 
        this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbGenero.FormattingEnabled = true;
        this.cmbGenero.Location = new System.Drawing.Point(40, 166);
        this.cmbGenero.Name = "cmbGenero";
        this.cmbGenero.Size = new System.Drawing.Size(154, 21);
        this.cmbGenero.TabIndex = 1;
        // 
        // cmbTipo
        // 
        this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbTipo.FormattingEnabled = true;
        this.cmbTipo.Location = new System.Drawing.Point(40, 223);
        this.cmbTipo.Name = "cmbTipo";
        this.cmbTipo.Size = new System.Drawing.Size(154, 21);
        this.cmbTipo.TabIndex = 2;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(504, 403);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(191, 35);
        this.button1.TabIndex = 3;
        this.button1.Text = "button1";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(552, 19);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(17, 20);
        this.textBox1.TabIndex = 4;
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(575, 19);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(18, 20);
        this.textBox2.TabIndex = 5;
        // 
        // lblN
        // 
        this.lblN.Location = new System.Drawing.Point(232, 99);
        this.lblN.Name = "lblN";
        this.lblN.Size = new System.Drawing.Size(100, 23);
        this.lblN.TabIndex = 7;
        this.lblN.Text = "Nombre";
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(232, 164);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(100, 23);
        this.label1.TabIndex = 8;
        this.label1.Text = "Genero";
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(232, 223);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(100, 23);
        this.label2.TabIndex = 9;
        this.label2.Text = "Tipo";
        // 
        // frmNuevaColeccion
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.lblN);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.textBox1);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.cmbTipo);
        this.Controls.Add(this.cmbGenero);
        this.Controls.Add(this.txtNombre);
        this.Name = "frmNuevaColeccion";
        this.Text = "frmNuevaColeccion";
        this.Load += new System.EventHandler(this.frmNuevaColeccion_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label lblN;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    public System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Button button1;

    public System.Windows.Forms.ComboBox cmbGenero;
    public System.Windows.Forms.ComboBox cmbTipo;

    public System.Windows.Forms.TextBox txtNombre;

    #endregion
}