using System.ComponentModel;

namespace proyectoVdufferx;

partial class Colecciones
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colecciones));
        this.DgvColecciones = new System.Windows.Forms.DataGridView();
        this.pictureBox2 = new System.Windows.Forms.PictureBox();
        this.pbEditarColeccion = new System.Windows.Forms.PictureBox();
        this.picEliminarColeccion = new System.Windows.Forms.PictureBox();
        this.pbNuevacoleccion = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize) (this.DgvColecciones)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pbEditarColeccion)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.picEliminarColeccion)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.pbNuevacoleccion)).BeginInit();
        this.SuspendLayout();
        // 
        // DgvColecciones
        // 
        this.DgvColecciones.BackgroundColor = System.Drawing.Color.AliceBlue;
        this.DgvColecciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.DgvColecciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
        dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
        dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
        this.DgvColecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        this.DgvColecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.DgvColecciones.ColumnHeadersVisible = false;
        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
        dataGridViewCellStyle2.NullValue = null;
        dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
        dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
        this.DgvColecciones.DefaultCellStyle = dataGridViewCellStyle2;
        this.DgvColecciones.Location = new System.Drawing.Point(29, 53);
        this.DgvColecciones.Name = "DgvColecciones";
        this.DgvColecciones.ReadOnly = true;
        this.DgvColecciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
        this.DgvColecciones.Size = new System.Drawing.Size(390, 325);
        this.DgvColecciones.TabIndex = 1;
        // 
        // pictureBox2
        // 
        this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
        this.pictureBox2.Location = new System.Drawing.Point(0, 0);
        this.pictureBox2.Name = "pictureBox2";
        this.pictureBox2.Size = new System.Drawing.Size(816, 40);
        this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.pictureBox2.TabIndex = 15;
        this.pictureBox2.TabStop = false;
        // 
        // pbEditarColeccion
        // 
        this.pbEditarColeccion.Image = ((System.Drawing.Image) (resources.GetObject("pbEditarColeccion.Image")));
        this.pbEditarColeccion.Location = new System.Drawing.Point(170, 397);
        this.pbEditarColeccion.Name = "pbEditarColeccion";
        this.pbEditarColeccion.Size = new System.Drawing.Size(113, 35);
        this.pbEditarColeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.pbEditarColeccion.TabIndex = 97;
        this.pbEditarColeccion.TabStop = false;
        this.pbEditarColeccion.Click += new System.EventHandler(this.pbEditarColeccion_Click);
        // 
        // picEliminarColeccion
        // 
        this.picEliminarColeccion.Image = ((System.Drawing.Image) (resources.GetObject("picEliminarColeccion.Image")));
        this.picEliminarColeccion.Location = new System.Drawing.Point(306, 397);
        this.picEliminarColeccion.Name = "picEliminarColeccion";
        this.picEliminarColeccion.Size = new System.Drawing.Size(113, 35);
        this.picEliminarColeccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.picEliminarColeccion.TabIndex = 98;
        this.picEliminarColeccion.TabStop = false;
        // 
        // pbNuevacoleccion
        // 
        this.pbNuevacoleccion.Image = ((System.Drawing.Image) (resources.GetObject("pbNuevacoleccion.Image")));
        this.pbNuevacoleccion.Location = new System.Drawing.Point(29, 397);
        this.pbNuevacoleccion.Name = "pbNuevacoleccion";
        this.pbNuevacoleccion.Size = new System.Drawing.Size(120, 34);
        this.pbNuevacoleccion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.pbNuevacoleccion.TabIndex = 99;
        this.pbNuevacoleccion.TabStop = false;
        this.pbNuevacoleccion.Click += new System.EventHandler(this.pbNuevacoleccion_Click);
        // 
        // Colecciones
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(456, 444);
        this.Controls.Add(this.pbNuevacoleccion);
        this.Controls.Add(this.picEliminarColeccion);
        this.Controls.Add(this.pbEditarColeccion);
        this.Controls.Add(this.pictureBox2);
        this.Controls.Add(this.DgvColecciones);
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "Colecciones";
        this.Load += new System.EventHandler(this.Colecciones_Load);
        ((System.ComponentModel.ISupportInitialize) (this.DgvColecciones)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pbEditarColeccion)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.picEliminarColeccion)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.pbNuevacoleccion)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.PictureBox pbNuevacoleccion;

    private System.Windows.Forms.PictureBox picEliminarColeccion;

    private System.Windows.Forms.PictureBox pbEditarColeccion;

    private System.Windows.Forms.PictureBox pictureBox2;

    public System.Windows.Forms.DataGridView DgvColecciones;

    #endregion
}