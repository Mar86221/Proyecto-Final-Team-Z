using System.ComponentModel;

namespace proyectoVdufferx;

partial class frmEjemplarEditar
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjemplarEditar));
        this.txtNombreE = new System.Windows.Forms.TextBox();
        this.TxtPalabrasClavesE = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.picEditarEjemplar = new System.Windows.Forms.PictureBox();
        this.txtIdEjemplarEditar = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize) (this.picEditarEjemplar)).BeginInit();
        this.SuspendLayout();
        // 
        // txtNombreE
        // 
        this.txtNombreE.Location = new System.Drawing.Point(165, 44);
        this.txtNombreE.Name = "txtNombreE";
        this.txtNombreE.Size = new System.Drawing.Size(160, 20);
        this.txtNombreE.TabIndex = 0;
        // 
        // TxtPalabrasClavesE
        // 
        this.TxtPalabrasClavesE.Location = new System.Drawing.Point(165, 94);
        this.TxtPalabrasClavesE.Name = "TxtPalabrasClavesE";
        this.TxtPalabrasClavesE.Size = new System.Drawing.Size(160, 20);
        this.TxtPalabrasClavesE.TabIndex = 1;
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label4.ForeColor = System.Drawing.Color.DarkBlue;
        this.label4.Location = new System.Drawing.Point(166, 27);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(115, 14);
        this.label4.TabIndex = 14;
        this.label4.Text = "Nombre ejemplar:";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label1.ForeColor = System.Drawing.Color.DarkBlue;
        this.label1.Location = new System.Drawing.Point(166, 77);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(159, 14);
        this.label1.TabIndex = 15;
        this.label1.Text = "Palabras claves ejemplar:";
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label2.ForeColor = System.Drawing.Color.DarkBlue;
        this.label2.Location = new System.Drawing.Point(27, 55);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(133, 36);
        this.label2.TabIndex = 16;
        this.label2.Text = "Introduzca los nuevos datos de ejemplar:\r\n";
        // 
        // picEditarEjemplar
        // 
        this.picEditarEjemplar.Image = ((System.Drawing.Image) (resources.GetObject("picEditarEjemplar.Image")));
        this.picEditarEjemplar.Location = new System.Drawing.Point(123, 139);
        this.picEditarEjemplar.Name = "picEditarEjemplar";
        this.picEditarEjemplar.Size = new System.Drawing.Size(113, 35);
        this.picEditarEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.picEditarEjemplar.TabIndex = 91;
        this.picEditarEjemplar.TabStop = false;
        this.picEditarEjemplar.Click += new System.EventHandler(this.picEditarEjemplar_Click);
        // 
        // txtIdEjemplarEditar
        // 
        this.txtIdEjemplarEditar.Location = new System.Drawing.Point(363, 175);
        this.txtIdEjemplarEditar.Name = "txtIdEjemplarEditar";
        this.txtIdEjemplarEditar.Size = new System.Drawing.Size(10, 20);
        this.txtIdEjemplarEditar.TabIndex = 92;
        // 
        // frmEjemplarEditar
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(385, 207);
        this.Controls.Add(this.txtIdEjemplarEditar);
        this.Controls.Add(this.picEditarEjemplar);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.TxtPalabrasClavesE);
        this.Controls.Add(this.txtNombreE);
        this.MaximizeBox = false;
        this.Name = "frmEjemplarEditar";
        ((System.ComponentModel.ISupportInitialize) (this.picEditarEjemplar)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    public System.Windows.Forms.TextBox txtIdEjemplarEditar;

    private System.Windows.Forms.PictureBox picEditarEjemplar;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label4;

    public System.Windows.Forms.TextBox txtNombreE;

    public System.Windows.Forms.TextBox TxtPalabrasClavesE;

    #endregion
}