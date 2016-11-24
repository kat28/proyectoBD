namespace ProyectoFinalG3
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabBD = new System.Windows.Forms.TabPage();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picCrearBD = new System.Windows.Forms.PictureBox();
            this.treeViewBD = new System.Windows.Forms.TreeView();
            this.txtNuevaBD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.tabSQL = new System.Windows.Forms.TabPage();
            this.rtxtConsulta = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chboxColumna = new System.Windows.Forms.CheckedListBox();
            this.picEjecutar = new System.Windows.Forms.PictureBox();
            this.picBorrar = new System.Windows.Forms.PictureBox();
            this.picAnalizar = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTituloSQL = new System.Windows.Forms.Label();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtInstancia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblServidor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.LogoTitulo = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.bottom1Panel = new System.Windows.Forms.Panel();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bottom2Panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabBD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrearBD)).BeginInit();
            this.tabSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEjecutar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnalizar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.LogoPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.AccessibleDescription = "";
            this.tabMenu.Controls.Add(this.tabBD);
            this.tabMenu.Controls.Add(this.tabUsuario);
            this.tabMenu.Controls.Add(this.tabSQL);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.ImageList = this.imageList32;
            this.tabMenu.Location = new System.Drawing.Point(225, 41);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(718, 391);
            this.tabMenu.TabIndex = 2;
            // 
            // tabBD
            // 
            this.tabBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tabBD.Controls.Add(this.label8);
            this.tabBD.Controls.Add(this.cmbBD);
            this.tabBD.Controls.Add(this.label7);
            this.tabBD.Controls.Add(this.picCrearBD);
            this.tabBD.Controls.Add(this.treeViewBD);
            this.tabBD.Controls.Add(this.txtNuevaBD);
            this.tabBD.Controls.Add(this.label2);
            this.tabBD.ImageIndex = 1;
            this.tabBD.Location = new System.Drawing.Point(4, 39);
            this.tabBD.Name = "tabBD";
            this.tabBD.Padding = new System.Windows.Forms.Padding(3);
            this.tabBD.Size = new System.Drawing.Size(710, 348);
            this.tabBD.TabIndex = 0;
            this.tabBD.Text = "Bases de Datos";
            this.tabBD.Click += new System.EventHandler(this.tabBD_Click);
            // 
            // cmbBD
            // 
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Location = new System.Drawing.Point(25, 59);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(178, 26);
            this.cmbBD.TabIndex = 13;
            this.cmbBD.SelectedIndexChanged += new System.EventHandler(this.cmbBD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(490, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tablas:";
            // 
            // picCrearBD
            // 
            this.picCrearBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCrearBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCrearBD.Image = ((System.Drawing.Image)(resources.GetObject("picCrearBD.Image")));
            this.picCrearBD.Location = new System.Drawing.Point(394, 52);
            this.picCrearBD.Name = "picCrearBD";
            this.picCrearBD.Size = new System.Drawing.Size(33, 33);
            this.picCrearBD.TabIndex = 10;
            this.picCrearBD.TabStop = false;
            this.toolTip1.SetToolTip(this.picCrearBD, "Crear BD");
            this.picCrearBD.Click += new System.EventHandler(this.picCrearBD_Click);
            // 
            // treeViewBD
            // 
            this.treeViewBD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.treeViewBD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewBD.ForeColor = System.Drawing.SystemColors.Info;
            this.treeViewBD.Location = new System.Drawing.Point(485, 22);
            this.treeViewBD.Name = "treeViewBD";
            this.treeViewBD.Size = new System.Drawing.Size(222, 309);
            this.treeViewBD.TabIndex = 3;
            // 
            // txtNuevaBD
            // 
            this.txtNuevaBD.Location = new System.Drawing.Point(233, 59);
            this.txtNuevaBD.Name = "txtNuevaBD";
            this.txtNuevaBD.Size = new System.Drawing.Size(155, 26);
            this.txtNuevaBD.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bases de Datos";
            // 
            // tabUsuario
            // 
            this.tabUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tabUsuario.ImageIndex = 5;
            this.tabUsuario.Location = new System.Drawing.Point(4, 39);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Size = new System.Drawing.Size(710, 348);
            this.tabUsuario.TabIndex = 2;
            this.tabUsuario.Text = "Usuarios";
            // 
            // tabSQL
            // 
            this.tabSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.tabSQL.Controls.Add(this.rtxtConsulta);
            this.tabSQL.Controls.Add(this.label3);
            this.tabSQL.Controls.Add(this.comboBox1);
            this.tabSQL.Controls.Add(this.picGuardar);
            this.tabSQL.Controls.Add(this.richTextBox1);
            this.tabSQL.Controls.Add(this.chboxColumna);
            this.tabSQL.Controls.Add(this.picEjecutar);
            this.tabSQL.Controls.Add(this.picBorrar);
            this.tabSQL.Controls.Add(this.picAnalizar);
            this.tabSQL.Controls.Add(this.btnDelete);
            this.tabSQL.Controls.Add(this.btnUpdate);
            this.tabSQL.Controls.Add(this.btnInsert);
            this.tabSQL.Controls.Add(this.btnSelect);
            this.tabSQL.Controls.Add(this.label1);
            this.tabSQL.Controls.Add(this.labelTituloSQL);
            this.tabSQL.ImageIndex = 2;
            this.tabSQL.Location = new System.Drawing.Point(4, 39);
            this.tabSQL.Name = "tabSQL";
            this.tabSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabSQL.Size = new System.Drawing.Size(710, 348);
            this.tabSQL.TabIndex = 1;
            this.tabSQL.Text = "Editor SQL";
            // 
            // rtxtConsulta
            // 
            this.rtxtConsulta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtConsulta.Location = new System.Drawing.Point(10, 55);
            this.rtxtConsulta.Name = "rtxtConsulta";
            this.rtxtConsulta.Size = new System.Drawing.Size(517, 135);
            this.rtxtConsulta.TabIndex = 18;
            this.rtxtConsulta.Text = "";
            this.rtxtConsulta.TextChanged += new System.EventHandler(this.rtxtSentencia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(360, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "BD:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(406, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picGuardar
            // 
            this.picGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuardar.Image = global::ProyectoFinalG3.Properties.Resources.guardar1;
            this.picGuardar.Location = new System.Drawing.Point(369, 9);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(35, 40);
            this.picGuardar.TabIndex = 15;
            this.picGuardar.TabStop = false;
            this.toolTip1.SetToolTip(this.picGuardar, "Ejecutar Consulta");
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 229);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(517, 82);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // chboxColumna
            // 
            this.chboxColumna.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxColumna.FormattingEnabled = true;
            this.chboxColumna.Location = new System.Drawing.Point(551, 55);
            this.chboxColumna.Name = "chboxColumna";
            this.chboxColumna.Size = new System.Drawing.Size(151, 256);
            this.chboxColumna.TabIndex = 13;
            // 
            // picEjecutar
            // 
            this.picEjecutar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("picEjecutar.Image")));
            this.picEjecutar.Location = new System.Drawing.Point(410, 9);
            this.picEjecutar.Name = "picEjecutar";
            this.picEjecutar.Size = new System.Drawing.Size(35, 40);
            this.picEjecutar.TabIndex = 11;
            this.picEjecutar.TabStop = false;
            this.toolTip1.SetToolTip(this.picEjecutar, "Ejecutar Consulta");
            this.picEjecutar.Click += new System.EventHandler(this.picEjecutar_Click);
            // 
            // picBorrar
            // 
            this.picBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBorrar.Image = ((System.Drawing.Image)(resources.GetObject("picBorrar.Image")));
            this.picBorrar.Location = new System.Drawing.Point(492, 9);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Size = new System.Drawing.Size(35, 40);
            this.picBorrar.TabIndex = 10;
            this.picBorrar.TabStop = false;
            this.toolTip1.SetToolTip(this.picBorrar, "Borrar Consulta");
            this.picBorrar.Click += new System.EventHandler(this.picBorrar_Click);
            // 
            // picAnalizar
            // 
            this.picAnalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAnalizar.Image = ((System.Drawing.Image)(resources.GetObject("picAnalizar.Image")));
            this.picAnalizar.Location = new System.Drawing.Point(451, 9);
            this.picAnalizar.Name = "picAnalizar";
            this.picAnalizar.Size = new System.Drawing.Size(35, 40);
            this.picAnalizar.TabIndex = 9;
            this.picAnalizar.TabStop = false;
            this.toolTip1.SetToolTip(this.picAnalizar, "Analizar");
            this.picAnalizar.Click += new System.EventHandler(this.picAnalizar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(172, 196);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(10, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnInsert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(91, 196);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 27);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(253, 196);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 4;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(570, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Columnas";
            // 
            // labelTituloSQL
            // 
            this.labelTituloSQL.AutoSize = true;
            this.labelTituloSQL.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloSQL.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelTituloSQL.Location = new System.Drawing.Point(6, 20);
            this.labelTituloSQL.Name = "labelTituloSQL";
            this.labelTituloSQL.Size = new System.Drawing.Size(267, 22);
            this.labelTituloSQL.TabIndex = 1;
            this.labelTituloSQL.Text = "Ejecuta las consultas de SQL";
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32.Images.SetKeyName(0, "addDatabase.png");
            this.imageList32.Images.SetKeyName(1, "database.png");
            this.imageList32.Images.SetKeyName(2, "draw.png");
            this.imageList32.Images.SetKeyName(3, "execute.png");
            this.imageList32.Images.SetKeyName(4, "query.png");
            this.imageList32.Images.SetKeyName(5, "team.png");
            this.imageList32.Images.SetKeyName(6, "exit.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.txtInstancia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtServidor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(3, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 347);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexion con Servidor";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.BackColor = System.Drawing.Color.Crimson;
            this.btnDesconectar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDesconectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDesconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconectar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDesconectar.ImageIndex = 4;
            this.btnDesconectar.Location = new System.Drawing.Point(62, 227);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(92, 24);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = false;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.btnConectar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectar.ImageIndex = 4;
            this.btnConectar.Location = new System.Drawing.Point(66, 181);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(84, 24);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtInstancia
            // 
            this.txtInstancia.Location = new System.Drawing.Point(13, 124);
            this.txtInstancia.Name = "txtInstancia";
            this.txtInstancia.Size = new System.Drawing.Size(190, 23);
            this.txtInstancia.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(52, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre Instancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(55, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(13, 56);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(190, 23);
            this.txtServidor.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lblServidor);
            this.headerPanel.Controls.Add(this.label4);
            this.headerPanel.Controls.Add(this.picExit);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(225, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(718, 41);
            this.headerPanel.TabIndex = 1;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServidor.Location = new System.Drawing.Point(62, 13);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(41, 16);
            this.lblServidor.TabIndex = 2;
            this.lblServidor.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Servidor:";
            // 
            // picExit
            // 
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(674, 3);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(32, 32);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picExit.TabIndex = 0;
            this.picExit.TabStop = false;
            this.toolTip1.SetToolTip(this.picExit, "Salir");
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.LogoPanel.Controls.Add(this.LogoTitulo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(225, 61);
            this.LogoPanel.TabIndex = 2;
            // 
            // LogoTitulo
            // 
            this.LogoTitulo.AutoSize = true;
            this.LogoTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.LogoTitulo.Location = new System.Drawing.Point(6, 18);
            this.LogoTitulo.Name = "LogoTitulo";
            this.LogoTitulo.Size = new System.Drawing.Size(180, 23);
            this.LogoTitulo.TabIndex = 0;
            this.LogoTitulo.Text = "Proyecto Final BD2";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            this.sidePanel.Controls.Add(this.groupBox1);
            this.sidePanel.Controls.Add(this.bottom1Panel);
            this.sidePanel.Controls.Add(this.LogoPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(225, 432);
            this.sidePanel.TabIndex = 0;
            // 
            // bottom1Panel
            // 
            this.bottom1Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottom1Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom1Panel.Location = new System.Drawing.Point(0, 411);
            this.bottom1Panel.Name = "bottom1Panel";
            this.bottom1Panel.Size = new System.Drawing.Size(225, 21);
            this.bottom1Panel.TabIndex = 2;
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16.Images.SetKeyName(0, "addDatabase.png");
            this.imageList16.Images.SetKeyName(1, "databas.png");
            this.imageList16.Images.SetKeyName(2, "database.png");
            this.imageList16.Images.SetKeyName(3, "databaseGrey.png");
            this.imageList16.Images.SetKeyName(4, "datagrey.png");
            this.imageList16.Images.SetKeyName(5, "datawhite.png");
            this.imageList16.Images.SetKeyName(6, "dbgrey.png");
            this.imageList16.Images.SetKeyName(7, "dbwhite.png");
            this.imageList16.Images.SetKeyName(8, "draw.png");
            this.imageList16.Images.SetKeyName(9, "execute.png");
            this.imageList16.Images.SetKeyName(10, "exit.png");
            this.imageList16.Images.SetKeyName(11, "query.png");
            this.imageList16.Images.SetKeyName(12, "team.png");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            // 
            // bottom2Panel
            // 
            this.bottom2Panel.BackColor = System.Drawing.Color.Gainsboro;
            this.bottom2Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom2Panel.Location = new System.Drawing.Point(225, 411);
            this.bottom2Panel.Name = "bottom2Panel";
            this.bottom2Panel.Size = new System.Drawing.Size(718, 21);
            this.bottom2Panel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(233, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Crear Base Datos";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(943, 432);
            this.Controls.Add(this.bottom2Panel);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.tabMenu.ResumeLayout(false);
            this.tabBD.ResumeLayout(false);
            this.tabBD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrearBD)).EndInit();
            this.tabSQL.ResumeLayout(false);
            this.tabSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEjecutar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnalizar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabBD;
        private System.Windows.Forms.TabPage tabSQL;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.ImageList imageList32;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Label LogoTitulo;
        private System.Windows.Forms.TreeView treeViewBD;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label labelTituloSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picAnalizar;
        private System.Windows.Forms.PictureBox picBorrar;
        private System.Windows.Forms.PictureBox picEjecutar;
        private System.Windows.Forms.Panel bottom2Panel;
        private System.Windows.Forms.Panel bottom1Panel;
        private System.Windows.Forms.PictureBox picCrearBD;
        private System.Windows.Forms.TextBox txtNuevaBD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckedListBox chboxColumna;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtInstancia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.ComboBox cmbBD;
        private System.Windows.Forms.Label label8;
    }
}