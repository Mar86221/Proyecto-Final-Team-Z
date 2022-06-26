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
        this.picEditarEjemplar = new System.Windows.Forms.PictureBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.TxtPalabrasClavesE = new System.Windows.Forms.TextBox();
        this.txtNombreE = new System.Windows.Forms.TextBox();
        this.txtIdEliminarE = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize) (this.picEditarEjemplar)).BeginInit();
        this.SuspendLayout();
        // 
        // picEditarEjemplar
        // 
        this.picEditarEjemplar.Image = ((System.Drawing.Image) (resources.GetObject("picEditarEjemplar.Image")));
        this.picEditarEjemplar.Location = new System.Drawing.Point(122, 171);
        this.picEditarEjemplar.Name = "picEditarEjemplar";
        this.picEditarEjemplar.Size = new System.Drawing.Size(113, 35);
        this.picEditarEjemplar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.picEditarEjemplar.TabIndex = 98;
        this.picEditarEjemplar.TabStop = false;
        this.picEditarEjemplar.Click += new System.EventHandler(this.picEditarEjemplar_Click);
        // 
        // label2
        // 
        this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label2.ForeColor = System.Drawing.Color.DarkBlue;
        this.label2.Location = new System.Drawing.Point(23, 77);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(133, 36);
        this.label2.TabIndex = 97;
        this.label2.Text = "Introduzca los nuevos datos de ejemplar:\r\n";
        // 
        // label1
        // 
        this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label1.ForeColor = System.Drawing.Color.DarkBlue;
        this.label1.Location = new System.Drawing.Point(181, 106);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(159, 14);
        this.label1.TabIndex = 96;
        this.label1.Text = "Palabras claves ejemplar:";
        // 
        // label4
        // 
        this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.label4.ForeColor = System.Drawing.Color.DarkBlue;
        this.label4.Location = new System.Drawing.Point(181, 56);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(115, 14);
        this.label4.TabIndex = 95;
        this.label4.Text = "Nombre ejemplar:";
        // 
        // TxtPalabrasClavesE
        // 
        this.TxtPalabrasClavesE.Location = new System.Drawing.Point(180, 123);
        this.TxtPalabrasClavesE.Name = "TxtPalabrasClavesE";
        this.TxtPalabrasClavesE.Size = new System.Drawing.Size(160, 20);
        this.TxtPalabrasClavesE.TabIndex = 94;
        // 
        // txtNombreE
        // 
        this.txtNombreE.Location = new System.Drawing.Point(180, 73);
        this.txtNombreE.Name = "txtNombreE";
        this.txtNombreE.Size = new System.Drawing.Size(160, 20);
        this.txtNombreE.TabIndex = 93;
        // 
        // txtIdEliminarE
        // 
        this.txtIdEliminarE.Location = new System.Drawing.Point(298, 202);
        this.txtIdEliminarE.Name = "txtIdEliminarE";
        this.txtIdEliminarE.Size = new System.Drawing.Size(74, 20);
        this.txtIdEliminarE.TabIndex = 100;
        // 
        // frmEjemplarEditar
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
        this.ClientSize = new System.Drawing.Size(384, 234);
        this.Controls.Add(this.txtIdEliminarE);
        this.Controls.Add(this.picEditarEjemplar);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.TxtPalabrasClavesE);
        this.Controls.Add(this.txtNombreE);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "frmEjemplarEditar";
        this.Text = "frmEjemplarEditar";
        ((System.ComponentModel.ISupportInitialize) (this.picEditarEjemplar)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    public System.Windows.Forms.TextBox txtIdEliminarE;

    private System.Windows.Forms.PictureBox picEditarEjemplar;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    public System.Windows.Forms.TextBox TxtPalabrasClavesE;
    public System.Windows.Forms.TextBox txtNombreE;

    #endregion
}