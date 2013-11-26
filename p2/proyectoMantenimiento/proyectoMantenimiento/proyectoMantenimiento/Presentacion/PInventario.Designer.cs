namespace proyectoMantenimiento.Presentacion
{
    partial class PInventario
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.edtCantI = new System.Windows.Forms.MaskedTextBox();
            this.btnNa = new System.Windows.Forms.Button();
            this.btnMA = new System.Windows.Forms.Button();
            this.btnCA = new System.Windows.Forms.Button();
            this.btnDA = new System.Windows.Forms.Button();
            this.btnGA = new System.Windows.Forms.Button();
            this.cbxItem = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvInv = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnElimM = new System.Windows.Forms.Button();
            this.btnNM = new System.Windows.Forms.Button();
            this.btnAddM = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxProv1 = new System.Windows.Forms.ComboBox();
            this.edtMarcaM = new System.Windows.Forms.TextBox();
            this.edtNombreM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtPrecioM = new System.Windows.Forms.MaskedTextBox();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnCanM = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNP = new System.Windows.Forms.Button();
            this.btnModP = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvProv = new System.Windows.Forms.DataGridView();
            this.edtDirP = new System.Windows.Forms.TextBox();
            this.edtContactoP = new System.Windows.Forms.TextBox();
            this.edtNombreP = new System.Windows.Forms.TextBox();
            this.edtTelfP = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnNC = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvComp = new System.Windows.Forms.DataGridView();
            this.btnCanC = new System.Windows.Forms.Button();
            this.btnModC = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.edtCodC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxProv2 = new System.Windows.Forms.ComboBox();
            this.edtMarcaC = new System.Windows.Forms.TextBox();
            this.edtNombreC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnElimC = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ALMACEN";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.edtCantI);
            this.groupBox7.Controls.Add(this.btnNa);
            this.groupBox7.Controls.Add(this.btnMA);
            this.groupBox7.Controls.Add(this.btnCA);
            this.groupBox7.Controls.Add(this.btnDA);
            this.groupBox7.Controls.Add(this.btnGA);
            this.groupBox7.Controls.Add(this.cbxItem);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(22, 32);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 267);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "DATOS";
            // 
            // edtCantI
            // 
            this.edtCantI.Location = new System.Drawing.Point(79, 93);
            this.edtCantI.Mask = "999";
            this.edtCantI.Name = "edtCantI";
            this.edtCantI.Size = new System.Drawing.Size(76, 20);
            this.edtCantI.TabIndex = 19;
            // 
            // btnNa
            // 
            this.btnNa.Location = new System.Drawing.Point(34, 139);
            this.btnNa.Name = "btnNa";
            this.btnNa.Size = new System.Drawing.Size(75, 23);
            this.btnNa.TabIndex = 18;
            this.btnNa.Text = "NUEVO";
            this.btnNa.UseVisualStyleBackColor = true;
            this.btnNa.Click += new System.EventHandler(this.btnNa_Click);
            // 
            // btnMA
            // 
            this.btnMA.Location = new System.Drawing.Point(115, 168);
            this.btnMA.Name = "btnMA";
            this.btnMA.Size = new System.Drawing.Size(75, 23);
            this.btnMA.TabIndex = 17;
            this.btnMA.Text = "MODIFICAR";
            this.btnMA.UseVisualStyleBackColor = true;
            this.btnMA.Click += new System.EventHandler(this.btnMA_Click);
            // 
            // btnCA
            // 
            this.btnCA.Location = new System.Drawing.Point(11, 222);
            this.btnCA.Name = "btnCA";
            this.btnCA.Size = new System.Drawing.Size(75, 24);
            this.btnCA.TabIndex = 16;
            this.btnCA.Text = "CANCELAR";
            this.btnCA.UseVisualStyleBackColor = true;
            this.btnCA.Click += new System.EventHandler(this.btnCA_Click);
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(119, 223);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(75, 23);
            this.btnDA.TabIndex = 5;
            this.btnDA.Text = "ELIMINAR";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // btnGA
            // 
            this.btnGA.Location = new System.Drawing.Point(34, 168);
            this.btnGA.Name = "btnGA";
            this.btnGA.Size = new System.Drawing.Size(75, 23);
            this.btnGA.TabIndex = 4;
            this.btnGA.Text = "GUARDAR";
            this.btnGA.UseVisualStyleBackColor = true;
            this.btnGA.Click += new System.EventHandler(this.btnGA_Click);
            // 
            // cbxItem
            // 
            this.cbxItem.FormattingEnabled = true;
            this.cbxItem.Location = new System.Drawing.Point(77, 38);
            this.cbxItem.Name = "cbxItem";
            this.cbxItem.Size = new System.Drawing.Size(121, 21);
            this.cbxItem.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "CANTIDAD:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "ITEM:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvInv);
            this.groupBox6.Location = new System.Drawing.Point(279, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(386, 270);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "LISTA INVENTARIO";
            // 
            // dgvInv
            // 
            this.dgvInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInv.Location = new System.Drawing.Point(23, 39);
            this.dgvInv.Name = "dgvInv";
            this.dgvInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInv.Size = new System.Drawing.Size(334, 209);
            this.dgvInv.TabIndex = 0;
            this.dgvInv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInv_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnElimM);
            this.tabPage2.Controls.Add(this.btnNM);
            this.tabPage2.Controls.Add(this.btnAddM);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnMM);
            this.tabPage2.Controls.Add(this.btnCanM);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MATERIAL";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnElimM
            // 
            this.btnElimM.Location = new System.Drawing.Point(292, 292);
            this.btnElimM.Name = "btnElimM";
            this.btnElimM.Size = new System.Drawing.Size(75, 23);
            this.btnElimM.TabIndex = 9;
            this.btnElimM.Text = "ELIMINAR";
            this.btnElimM.UseVisualStyleBackColor = true;
            this.btnElimM.Click += new System.EventHandler(this.btnElimM_Click);
            // 
            // btnNM
            // 
            this.btnNM.Location = new System.Drawing.Point(23, 292);
            this.btnNM.Name = "btnNM";
            this.btnNM.Size = new System.Drawing.Size(75, 23);
            this.btnNM.TabIndex = 18;
            this.btnNM.Text = "NUEVO";
            this.btnNM.UseVisualStyleBackColor = true;
            this.btnNM.Click += new System.EventHandler(this.btnNM_Click);
            // 
            // btnAddM
            // 
            this.btnAddM.Location = new System.Drawing.Point(194, 293);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(75, 23);
            this.btnAddM.TabIndex = 8;
            this.btnAddM.Text = "GUARDAR";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvMat);
            this.groupBox5.Location = new System.Drawing.Point(257, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 235);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LISTA DE MATERIALES";
            // 
            // dgvMat
            // 
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Location = new System.Drawing.Point(19, 22);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.ReadOnly = true;
            this.dgvMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMat.Size = new System.Drawing.Size(381, 207);
            this.dgvMat.TabIndex = 0;
            this.dgvMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMat_CellContentClick);
            this.dgvMat.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMat_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxProv1);
            this.groupBox1.Controls.Add(this.edtMarcaM);
            this.groupBox1.Controls.Add(this.edtNombreM);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edtPrecioM);
            this.groupBox1.Location = new System.Drawing.Point(23, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MATERIALES";
            // 
            // cbxProv1
            // 
            this.cbxProv1.FormattingEnabled = true;
            this.cbxProv1.Location = new System.Drawing.Point(90, 150);
            this.cbxProv1.Name = "cbxProv1";
            this.cbxProv1.Size = new System.Drawing.Size(121, 21);
            this.cbxProv1.TabIndex = 7;
            // 
            // edtMarcaM
            // 
            this.edtMarcaM.Location = new System.Drawing.Point(77, 74);
            this.edtMarcaM.Name = "edtMarcaM";
            this.edtMarcaM.Size = new System.Drawing.Size(134, 20);
            this.edtMarcaM.TabIndex = 6;
            // 
            // edtNombreM
            // 
            this.edtNombreM.Location = new System.Drawing.Point(77, 37);
            this.edtNombreM.Name = "edtNombreM";
            this.edtNombreM.Size = new System.Drawing.Size(134, 20);
            this.edtNombreM.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "PROVEEDOR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "MARCA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NOMBRE:";
            // 
            // edtPrecioM
            // 
            this.edtPrecioM.Location = new System.Drawing.Point(77, 114);
            this.edtPrecioM.Mask = "9999";
            this.edtPrecioM.Name = "edtPrecioM";
            this.edtPrecioM.Size = new System.Drawing.Size(134, 20);
            this.edtPrecioM.TabIndex = 0;
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(113, 293);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(75, 23);
            this.btnMM.TabIndex = 17;
            this.btnMM.Text = "MODIFICAR";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnCanM
            // 
            this.btnCanM.Location = new System.Drawing.Point(373, 293);
            this.btnCanM.Name = "btnCanM";
            this.btnCanM.Size = new System.Drawing.Size(75, 24);
            this.btnCanM.TabIndex = 16;
            this.btnCanM.Text = "CANCELAR";
            this.btnCanM.UseVisualStyleBackColor = true;
            this.btnCanM.Click += new System.EventHandler(this.btnCanM_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnNP);
            this.tabPage3.Controls.Add(this.btnModP);
            this.tabPage3.Controls.Add(this.btnCancelar);
            this.tabPage3.Controls.Add(this.btnEliminar);
            this.tabPage3.Controls.Add(this.btnGuardar);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.edtDirP);
            this.tabPage3.Controls.Add(this.edtContactoP);
            this.tabPage3.Controls.Add(this.edtNombreP);
            this.tabPage3.Controls.Add(this.edtTelfP);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(717, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PROVEEDORES";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnNP
            // 
            this.btnNP.Location = new System.Drawing.Point(614, 27);
            this.btnNP.Name = "btnNP";
            this.btnNP.Size = new System.Drawing.Size(75, 23);
            this.btnNP.TabIndex = 15;
            this.btnNP.Text = "NUEVO";
            this.btnNP.UseVisualStyleBackColor = true;
            this.btnNP.Click += new System.EventHandler(this.btnNP_Click);
            // 
            // btnModP
            // 
            this.btnModP.Location = new System.Drawing.Point(614, 70);
            this.btnModP.Name = "btnModP";
            this.btnModP.Size = new System.Drawing.Size(75, 23);
            this.btnModP.TabIndex = 14;
            this.btnModP.Text = "MODIFICAR";
            this.btnModP.UseVisualStyleBackColor = true;
            this.btnModP.Click += new System.EventHandler(this.btnModP_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(614, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(614, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(614, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvProv);
            this.groupBox3.Location = new System.Drawing.Point(18, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 129);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LISTA DE PROVEEDORES";
            // 
            // dgvProv
            // 
            this.dgvProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProv.Location = new System.Drawing.Point(29, 19);
            this.dgvProv.MultiSelect = false;
            this.dgvProv.Name = "dgvProv";
            this.dgvProv.ReadOnly = true;
            this.dgvProv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProv.Size = new System.Drawing.Size(438, 94);
            this.dgvProv.TabIndex = 0;
            this.dgvProv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProv_CellClick);
            this.dgvProv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProv_CellContentClick);
            // 
            // edtDirP
            // 
            this.edtDirP.Location = new System.Drawing.Point(373, 72);
            this.edtDirP.Name = "edtDirP";
            this.edtDirP.Size = new System.Drawing.Size(100, 20);
            this.edtDirP.TabIndex = 8;
            // 
            // edtContactoP
            // 
            this.edtContactoP.Location = new System.Drawing.Point(130, 80);
            this.edtContactoP.Name = "edtContactoP";
            this.edtContactoP.Size = new System.Drawing.Size(100, 20);
            this.edtContactoP.TabIndex = 7;
            // 
            // edtNombreP
            // 
            this.edtNombreP.Location = new System.Drawing.Point(130, 37);
            this.edtNombreP.Name = "edtNombreP";
            this.edtNombreP.Size = new System.Drawing.Size(100, 20);
            this.edtNombreP.TabIndex = 6;
            // 
            // edtTelfP
            // 
            this.edtTelfP.Location = new System.Drawing.Point(373, 37);
            this.edtTelfP.Mask = "99999999";
            this.edtTelfP.Name = "edtTelfP";
            this.edtTelfP.Size = new System.Drawing.Size(100, 20);
            this.edtTelfP.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIRECCION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTACTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPRESA:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnNC);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.btnCanC);
            this.tabPage4.Controls.Add(this.btnModC);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.btnElimC);
            this.tabPage4.Controls.Add(this.btnAddC);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(717, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "COMPONENTE";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // btnNC
            // 
            this.btnNC.Location = new System.Drawing.Point(373, 282);
            this.btnNC.Name = "btnNC";
            this.btnNC.Size = new System.Drawing.Size(75, 23);
            this.btnNC.TabIndex = 18;
            this.btnNC.Text = "NUEVO";
            this.btnNC.UseVisualStyleBackColor = true;
            this.btnNC.Click += new System.EventHandler(this.btnNC_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvComp);
            this.groupBox4.Location = new System.Drawing.Point(275, 41);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 234);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LISTA DE COMPONENTES";
            // 
            // dgvComp
            // 
            this.dgvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComp.Location = new System.Drawing.Point(13, 25);
            this.dgvComp.Name = "dgvComp";
            this.dgvComp.ReadOnly = true;
            this.dgvComp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComp.Size = new System.Drawing.Size(397, 203);
            this.dgvComp.TabIndex = 0;
            this.dgvComp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComp_CellClick);
            // 
            // btnCanC
            // 
            this.btnCanC.Location = new System.Drawing.Point(275, 281);
            this.btnCanC.Name = "btnCanC";
            this.btnCanC.Size = new System.Drawing.Size(75, 24);
            this.btnCanC.TabIndex = 16;
            this.btnCanC.Text = "CANCELAR";
            this.btnCanC.UseVisualStyleBackColor = true;
            this.btnCanC.Click += new System.EventHandler(this.btnCanC_Click);
            // 
            // btnModC
            // 
            this.btnModC.Location = new System.Drawing.Point(174, 281);
            this.btnModC.Name = "btnModC";
            this.btnModC.Size = new System.Drawing.Size(75, 23);
            this.btnModC.TabIndex = 17;
            this.btnModC.Text = "MODIFICAR";
            this.btnModC.UseVisualStyleBackColor = true;
            this.btnModC.Click += new System.EventHandler(this.btnModC_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.edtCodC);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbxProv2);
            this.groupBox2.Controls.Add(this.edtMarcaC);
            this.groupBox2.Controls.Add(this.edtNombreC);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(23, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COMPONENTES";
            // 
            // edtCodC
            // 
            this.edtCodC.Location = new System.Drawing.Point(89, 21);
            this.edtCodC.Name = "edtCodC";
            this.edtCodC.Size = new System.Drawing.Size(121, 20);
            this.edtCodC.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "CODIGO:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cbxProv2
            // 
            this.cbxProv2.FormattingEnabled = true;
            this.cbxProv2.Location = new System.Drawing.Point(89, 139);
            this.cbxProv2.Name = "cbxProv2";
            this.cbxProv2.Size = new System.Drawing.Size(121, 21);
            this.cbxProv2.TabIndex = 5;
            // 
            // edtMarcaC
            // 
            this.edtMarcaC.Location = new System.Drawing.Point(89, 89);
            this.edtMarcaC.Name = "edtMarcaC";
            this.edtMarcaC.Size = new System.Drawing.Size(121, 20);
            this.edtMarcaC.TabIndex = 4;
            // 
            // edtNombreC
            // 
            this.edtNombreC.Location = new System.Drawing.Point(92, 54);
            this.edtNombreC.Name = "edtNombreC";
            this.edtNombreC.Size = new System.Drawing.Size(121, 20);
            this.edtNombreC.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "PROVEEDOR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "MARCA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "NOMBRE:";
            // 
            // btnElimC
            // 
            this.btnElimC.Location = new System.Drawing.Point(93, 281);
            this.btnElimC.Name = "btnElimC";
            this.btnElimC.Size = new System.Drawing.Size(75, 23);
            this.btnElimC.TabIndex = 7;
            this.btnElimC.Text = "ELIMINAR";
            this.btnElimC.UseVisualStyleBackColor = true;
            this.btnElimC.Click += new System.EventHandler(this.btnElimC_Click);
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(12, 281);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(75, 23);
            this.btnAddC.TabIndex = 6;
            this.btnAddC.Text = "GUARDAR";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // PInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "PInventario";
            this.Text = "PInventario";
            this.Load += new System.EventHandler(this.PInventario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProv)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvProv;
        private System.Windows.Forms.TextBox edtDirP;
        private System.Windows.Forms.TextBox edtContactoP;
        private System.Windows.Forms.TextBox edtNombreP;
        private System.Windows.Forms.MaskedTextBox edtTelfP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnElimM;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.ComboBox cbxProv1;
        private System.Windows.Forms.TextBox edtMarcaM;
        private System.Windows.Forms.TextBox edtNombreM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox edtPrecioM;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvComp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnElimC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.ComboBox cbxProv2;
        private System.Windows.Forms.TextBox edtMarcaC;
        private System.Windows.Forms.TextBox edtNombreC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtCodC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button btnGA;
        private System.Windows.Forms.ComboBox cbxItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvInv;
        private System.Windows.Forms.Button btnNP;
        private System.Windows.Forms.Button btnModP;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnCanM;
        private System.Windows.Forms.Button btnNC;
        private System.Windows.Forms.Button btnCanC;
        private System.Windows.Forms.Button btnModC;
        private System.Windows.Forms.Button btnNa;
        private System.Windows.Forms.Button btnMA;
        private System.Windows.Forms.Button btnCA;
        private System.Windows.Forms.MaskedTextBox edtCantI;
    }
}