using System.ComponentModel;

namespace proyectoVdufferx
{
    partial class frmRegistro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.picRegistrarme2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevaInstitucion = new System.Windows.Forms.Button();
            this.cmbInstitucion = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFotografia = new System.Windows.Forms.Label();
            this.txtFotografia = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.cmbOcupacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCor = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pbCor = new System.Windows.Forms.PictureBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pbTel = new System.Windows.Forms.PictureBox();
            this.lblInsti = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbInsti = new System.Windows.Forms.PictureBox();
            this.lblOcu = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbOcu = new System.Windows.Forms.PictureBox();
            this.lblDirec = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbDirec = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbName = new System.Windows.Forms.PictureBox();
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumero = new System.Windows.Forms.ErrorProvider(this.components);
            this.opfImagen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize) (this.picRegistrarme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbInsti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbOcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDirec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // picRegistrarme2
            // 
            this.picRegistrarme2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRegistrarme2.Image = ((System.Drawing.Image) (resources.GetObject("picRegistrarme2.Image")));
            this.picRegistrarme2.Location = new System.Drawing.Point(100, 474);
            this.picRegistrarme2.Name = "picRegistrarme2";
            this.picRegistrarme2.Size = new System.Drawing.Size(146, 36);
            this.picRegistrarme2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRegistrarme2.TabIndex = 27;
            this.picRegistrarme2.TabStop = false;
            this.picRegistrarme2.Click += new System.EventHandler(this.picRegistrarme2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnNuevaInstitucion);
            this.panel1.Controls.Add(this.cmbInstitucion);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.lblFotografia);
            this.panel1.Controls.Add(this.txtFotografia);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.cmbOcupacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblCor);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pbCor);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pbTel);
            this.panel1.Controls.Add(this.lblInsti);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pbInsti);
            this.panel1.Controls.Add(this.lblOcu);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pbOcu);
            this.panel1.Controls.Add(this.lblDirec);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pbDirec);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pbName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.picRegistrarme2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 522);
            this.panel1.TabIndex = 29;
            // 
            // btnNuevaInstitucion
            // 
            this.btnNuevaInstitucion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.btnNuevaInstitucion.Location = new System.Drawing.Point(338, 240);
            this.btnNuevaInstitucion.Name = "btnNuevaInstitucion";
            this.btnNuevaInstitucion.Size = new System.Drawing.Size(31, 33);
            this.btnNuevaInstitucion.TabIndex = 72;
            this.btnNuevaInstitucion.UseVisualStyleBackColor = false;
            this.btnNuevaInstitucion.Click += new System.EventHandler(this.btnNuevaInstitucion_Click);
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.BackColor = System.Drawing.Color.White;
            this.cmbInstitucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInstitucion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbInstitucion.FormattingEnabled = true;
            this.cmbInstitucion.Items.AddRange(new object[] {"Instituto", "Empresa", "Otros"});
            this.cmbInstitucion.Location = new System.Drawing.Point(156, 243);
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.Size = new System.Drawing.Size(170, 26);
            this.cmbInstitucion.TabIndex = 71;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.btnBuscar.Location = new System.Drawing.Point(333, 425);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 33);
            this.btnBuscar.TabIndex = 70;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFotografia
            // 
            this.lblFotografia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFotografia.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblFotografia.Location = new System.Drawing.Point(54, 413);
            this.lblFotografia.Name = "lblFotografia";
            this.lblFotografia.Size = new System.Drawing.Size(100, 20);
            this.lblFotografia.TabIndex = 69;
            this.lblFotografia.Text = "Fotografía:";
            // 
            // txtFotografia
            // 
            this.txtFotografia.BackColor = System.Drawing.Color.White;
            this.txtFotografia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFotografia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFotografia.Location = new System.Drawing.Point(56, 432);
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.ReadOnly = true;
            this.txtFotografia.Size = new System.Drawing.Size(262, 19);
            this.txtFotografia.TabIndex = 68;
            this.txtFotografia.Tag = "Fot";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(48, 427);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(277, 29);
            this.pictureBox8.TabIndex = 66;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pictureBox9.Location = new System.Drawing.Point(46, 425);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(282, 33);
            this.pictureBox9.TabIndex = 67;
            this.pictureBox9.TabStop = false;
            // 
            // cmbOcupacion
            // 
            this.cmbOcupacion.BackColor = System.Drawing.Color.White;
            this.cmbOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOcupacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbOcupacion.FormattingEnabled = true;
            this.cmbOcupacion.Items.AddRange(new object[] {"Estudiante", "Empleado", "Otros"});
            this.cmbOcupacion.Location = new System.Drawing.Point(156, 181);
            this.cmbOcupacion.Name = "cmbOcupacion";
            this.cmbOcupacion.Size = new System.Drawing.Size(169, 26);
            this.cmbOcupacion.TabIndex = 58;
            this.cmbOcupacion.SelectedIndexChanged += new System.EventHandler(this.cmbOcupacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 30);
            this.label1.TabIndex = 57;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCor
            // 
            this.lblCor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCor.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblCor.Location = new System.Drawing.Point(57, 356);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(70, 16);
            this.lblCor.TabIndex = 56;
            this.lblCor.Text = "Correo:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtCorreo.Location = new System.Drawing.Point(54, 373);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(262, 19);
            this.txtCorreo.TabIndex = 55;
            this.txtCorreo.Tag = "Cor";
            this.txtCorreo.Enter += new System.EventHandler(this.txtEnter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(48, 366);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(279, 29);
            this.pictureBox7.TabIndex = 53;
            this.pictureBox7.TabStop = false;
            // 
            // pbCor
            // 
            this.pbCor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbCor.Location = new System.Drawing.Point(46, 364);
            this.pbCor.Name = "pbCor";
            this.pbCor.Size = new System.Drawing.Size(283, 33);
            this.pbCor.TabIndex = 54;
            this.pbCor.TabStop = false;
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblTel.Location = new System.Drawing.Point(57, 295);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(82, 16);
            this.lblTel.TabIndex = 52;
            this.lblTel.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTelefono.Location = new System.Drawing.Point(54, 311);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(259, 19);
            this.txtTelefono.TabIndex = 51;
            this.txtTelefono.Tag = "Tel";
            this.txtTelefono.Enter += new System.EventHandler(this.txtEnter);
            this.txtTelefono.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(48, 305);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(279, 28);
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // pbTel
            // 
            this.pbTel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbTel.Location = new System.Drawing.Point(46, 303);
            this.pbTel.Name = "pbTel";
            this.pbTel.Size = new System.Drawing.Size(283, 32);
            this.pbTel.TabIndex = 50;
            this.pbTel.TabStop = false;
            // 
            // lblInsti
            // 
            this.lblInsti.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInsti.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblInsti.Location = new System.Drawing.Point(52, 233);
            this.lblInsti.Name = "lblInsti";
            this.lblInsti.Size = new System.Drawing.Size(106, 16);
            this.lblInsti.TabIndex = 48;
            this.lblInsti.Text = "Institucion:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(47, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(283, 29);
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pbInsti
            // 
            this.pbInsti.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbInsti.Location = new System.Drawing.Point(45, 241);
            this.pbInsti.Name = "pbInsti";
            this.pbInsti.Size = new System.Drawing.Size(287, 33);
            this.pbInsti.TabIndex = 46;
            this.pbInsti.TabStop = false;
            // 
            // lblOcu
            // 
            this.lblOcu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblOcu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblOcu.Location = new System.Drawing.Point(53, 171);
            this.lblOcu.Name = "lblOcu";
            this.lblOcu.Size = new System.Drawing.Size(107, 20);
            this.lblOcu.TabIndex = 44;
            this.lblOcu.Text = "Ocupacion:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(47, 181);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(282, 30);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // pbOcu
            // 
            this.pbOcu.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbOcu.Location = new System.Drawing.Point(45, 179);
            this.pbOcu.Name = "pbOcu";
            this.pbOcu.Size = new System.Drawing.Size(286, 34);
            this.pbOcu.TabIndex = 42;
            this.pbOcu.TabStop = false;
            // 
            // lblDirec
            // 
            this.lblDirec.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDirec.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblDirec.Location = new System.Drawing.Point(63, 118);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(90, 16);
            this.lblDirec.TabIndex = 36;
            this.lblDirec.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtDireccion.Location = new System.Drawing.Point(53, 139);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(263, 19);
            this.txtDireccion.TabIndex = 35;
            this.txtDireccion.Tag = "Direc";
            this.txtDireccion.Enter += new System.EventHandler(this.txtEnter);
            this.txtDireccion.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(47, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 31);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // pbDirec
            // 
            this.pbDirec.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbDirec.Location = new System.Drawing.Point(45, 129);
            this.pbDirec.Name = "pbDirec";
            this.pbDirec.Size = new System.Drawing.Size(283, 35);
            this.pbDirec.TabIndex = 34;
            this.pbDirec.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.lblName.Location = new System.Drawing.Point(61, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 16);
            this.lblName.TabIndex = 32;
            this.lblName.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtNombre.Location = new System.Drawing.Point(54, 77);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(262, 19);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.Tag = "Name";
            this.txtNombre.Enter += new System.EventHandler(this.txtEnter);
            this.txtNombre.Leave += new System.EventHandler(this.txtLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(47, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 30);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pbName
            // 
            this.pbName.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (33)))), ((int) (((byte) (62)))), ((int) (((byte) (153)))));
            this.pbName.Location = new System.Drawing.Point(45, 66);
            this.pbName.Name = "pbName";
            this.pbName.Size = new System.Drawing.Size(283, 34);
            this.pbName.TabIndex = 30;
            this.pbName.TabStop = false;
            // 
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            // 
            // errorNumero
            // 
            this.errorNumero.ContainerControl = this;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(376, 522);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize) (this.picRegistrarme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbInsti)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbOcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbDirec)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbName)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.errorNumero)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnNuevaInstitucion;

        public System.Windows.Forms.ComboBox cmbInstitucion;

        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.TextBox txtFotografia;
        private System.Windows.Forms.Label lblFotografia;

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;

        public System.Windows.Forms.OpenFileDialog opfImagen;

        private System.Windows.Forms.ErrorProvider errorNumero;

        private System.Windows.Forms.ErrorProvider errorCorreo;


        public System.Windows.Forms.ComboBox cmbOcupacion;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pbInsti;
        private System.Windows.Forms.Label lblTel;

        private System.Windows.Forms.TextBox txtCorreo;

        private System.Windows.Forms.Label lblInsti;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.PictureBox pbTel;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pbCor;

        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;

        private System.Windows.Forms.Label lblOcu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbOcu;

        private System.Windows.Forms.Label lblDirec;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pbDirec;

        private System.Windows.Forms.PictureBox pbName;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblName;

        private System.Windows.Forms.PictureBox pbNombre;
        

        private System.Windows.Forms.PictureBox picTxt1;

        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.PictureBox picRegistrarme2;

        #endregion
    }
}