namespace proyectoMantenimiento.Presentacion
{
    partial class PProceso
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
            this.tabMaquinaria = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNL = new System.Windows.Forms.Button();
            this.btnML = new System.Windows.Forms.Button();
            this.btnCL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEL = new System.Windows.Forms.Button();
            this.btnGuardarLinea = new System.Windows.Forms.Button();
            this.dgvLinea = new System.Windows.Forms.DataGridView();
            this.edtDescL = new System.Windows.Forms.TextBox();
            this.edtNombreL = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEM = new System.Windows.Forms.Button();
            this.btnNM = new System.Windows.Forms.Button();
            this.btnGM = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnCM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMaquina = new System.Windows.Forms.DataGridView();
            this.edtCarM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edtFuncM = new System.Windows.Forms.TextBox();
            this.edtIndM = new System.Windows.Forms.TextBox();
            this.edtAnhoM = new System.Windows.Forms.TextBox();
            this.edtMarcaM = new System.Windows.Forms.TextBox();
            this.edtNombreM = new System.Windows.Forms.TextBox();
            this.edtCodM = new System.Windows.Forms.TextBox();
            this.cbxLineaM = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMaquinaria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquina)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMaquinaria
            // 
            this.tabMaquinaria.Controls.Add(this.tabPage1);
            this.tabMaquinaria.Controls.Add(this.tabPage2);
            this.tabMaquinaria.Location = new System.Drawing.Point(2, 2);
            this.tabMaquinaria.Name = "tabMaquinaria";
            this.tabMaquinaria.SelectedIndex = 0;
            this.tabMaquinaria.Size = new System.Drawing.Size(550, 430);
            this.tabMaquinaria.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNL);
            this.tabPage1.Controls.Add(this.btnML);
            this.tabPage1.Controls.Add(this.btnCL);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEL);
            this.tabPage1.Controls.Add(this.btnGuardarLinea);
            this.tabPage1.Controls.Add(this.dgvLinea);
            this.tabPage1.Controls.Add(this.edtDescL);
            this.tabPage1.Controls.Add(this.edtNombreL);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(542, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LINEA DE PRODUCCION";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // btnNL
            // 
            this.btnNL.Location = new System.Drawing.Point(317, 28);
            this.btnNL.Name = "btnNL";
            this.btnNL.Size = new System.Drawing.Size(75, 23);
            this.btnNL.TabIndex = 28;
            this.btnNL.Text = "NUEVO";
            this.btnNL.UseVisualStyleBackColor = true;
            this.btnNL.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnML
            // 
            this.btnML.Location = new System.Drawing.Point(409, 118);
            this.btnML.Name = "btnML";
            this.btnML.Size = new System.Drawing.Size(75, 23);
            this.btnML.TabIndex = 27;
            this.btnML.Text = "MODIFICAR";
            this.btnML.UseVisualStyleBackColor = true;
            this.btnML.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCL
            // 
            this.btnCL.Location = new System.Drawing.Point(317, 71);
            this.btnCL.Name = "btnCL";
            this.btnCL.Size = new System.Drawing.Size(75, 24);
            this.btnCL.TabIndex = 26;
            this.btnCL.Text = "CANCELAR";
            this.btnCL.UseVisualStyleBackColor = true;
            this.btnCL.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DESCRIPCION:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEL
            // 
            this.btnEL.Location = new System.Drawing.Point(409, 71);
            this.btnEL.Name = "btnEL";
            this.btnEL.Size = new System.Drawing.Size(75, 23);
            this.btnEL.TabIndex = 4;
            this.btnEL.Text = "ELIMINAR";
            this.btnEL.UseVisualStyleBackColor = true;
            this.btnEL.Click += new System.EventHandler(this.btnEliminarL_Click);
            // 
            // btnGuardarLinea
            // 
            this.btnGuardarLinea.Location = new System.Drawing.Point(409, 25);
            this.btnGuardarLinea.Name = "btnGuardarLinea";
            this.btnGuardarLinea.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarLinea.TabIndex = 3;
            this.btnGuardarLinea.Text = "GUARDAR";
            this.btnGuardarLinea.UseVisualStyleBackColor = true;
            this.btnGuardarLinea.Click += new System.EventHandler(this.btnGuardarLinea_Click);
            // 
            // dgvLinea
            // 
            this.dgvLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinea.Location = new System.Drawing.Point(29, 169);
            this.dgvLinea.Name = "dgvLinea";
            this.dgvLinea.ReadOnly = true;
            this.dgvLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinea.Size = new System.Drawing.Size(442, 150);
            this.dgvLinea.TabIndex = 2;
            this.dgvLinea.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinea_CellClick);
            // 
            // edtDescL
            // 
            this.edtDescL.Location = new System.Drawing.Point(114, 74);
            this.edtDescL.Multiline = true;
            this.edtDescL.Name = "edtDescL";
            this.edtDescL.Size = new System.Drawing.Size(147, 67);
            this.edtDescL.TabIndex = 1;
            // 
            // edtNombreL
            // 
            this.edtNombreL.Location = new System.Drawing.Point(114, 28);
            this.edtNombreL.Name = "edtNombreL";
            this.edtNombreL.Size = new System.Drawing.Size(147, 20);
            this.edtNombreL.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEM);
            this.tabPage2.Controls.Add(this.btnNM);
            this.tabPage2.Controls.Add(this.btnGM);
            this.tabPage2.Controls.Add(this.btnMM);
            this.tabPage2.Controls.Add(this.btnCM);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.edtCarM);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.edtFuncM);
            this.tabPage2.Controls.Add(this.edtIndM);
            this.tabPage2.Controls.Add(this.edtAnhoM);
            this.tabPage2.Controls.Add(this.edtMarcaM);
            this.tabPage2.Controls.Add(this.edtNombreM);
            this.tabPage2.Controls.Add(this.edtCodM);
            this.tabPage2.Controls.Add(this.cbxLineaM);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(542, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MAQUINARIA";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // btnEM
            // 
            this.btnEM.Location = new System.Drawing.Point(325, 177);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(75, 23);
            this.btnEM.TabIndex = 25;
            this.btnEM.Text = "ELIMINAR";
            this.btnEM.UseVisualStyleBackColor = true;
            // 
            // btnNM
            // 
            this.btnNM.Location = new System.Drawing.Point(56, 177);
            this.btnNM.Name = "btnNM";
            this.btnNM.Size = new System.Drawing.Size(75, 23);
            this.btnNM.TabIndex = 28;
            this.btnNM.Text = "NUEVO";
            this.btnNM.UseVisualStyleBackColor = true;
            this.btnNM.Click += new System.EventHandler(this.btnNM_Click);
            // 
            // btnGM
            // 
            this.btnGM.Location = new System.Drawing.Point(227, 178);
            this.btnGM.Name = "btnGM";
            this.btnGM.Size = new System.Drawing.Size(75, 23);
            this.btnGM.TabIndex = 24;
            this.btnGM.Text = "GUARDAR";
            this.btnGM.UseVisualStyleBackColor = true;
            this.btnGM.Click += new System.EventHandler(this.btnGM_Click);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(146, 178);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(75, 23);
            this.btnMM.TabIndex = 27;
            this.btnMM.Text = "MODIFICAR";
            this.btnMM.UseVisualStyleBackColor = true;
            // 
            // btnCM
            // 
            this.btnCM.Location = new System.Drawing.Point(406, 178);
            this.btnCM.Name = "btnCM";
            this.btnCM.Size = new System.Drawing.Size(75, 24);
            this.btnCM.TabIndex = 26;
            this.btnCM.Text = "CANCELAR";
            this.btnCM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMaquina);
            this.groupBox1.Location = new System.Drawing.Point(28, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 175);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTA DE MAQUINARIA";
            // 
            // dgvMaquina
            // 
            this.dgvMaquina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaquina.Location = new System.Drawing.Point(6, 19);
            this.dgvMaquina.Name = "dgvMaquina";
            this.dgvMaquina.Size = new System.Drawing.Size(464, 150);
            this.dgvMaquina.TabIndex = 0;
            // 
            // edtCarM
            // 
            this.edtCarM.Location = new System.Drawing.Point(325, 131);
            this.edtCarM.Name = "edtCarM";
            this.edtCarM.Size = new System.Drawing.Size(100, 20);
            this.edtCarM.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "CARACTERISTICAS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "LINEA:";
            // 
            // edtFuncM
            // 
            this.edtFuncM.Location = new System.Drawing.Point(325, 98);
            this.edtFuncM.Name = "edtFuncM";
            this.edtFuncM.Size = new System.Drawing.Size(100, 20);
            this.edtFuncM.TabIndex = 12;
            // 
            // edtIndM
            // 
            this.edtIndM.Location = new System.Drawing.Point(325, 61);
            this.edtIndM.Name = "edtIndM";
            this.edtIndM.Size = new System.Drawing.Size(100, 20);
            this.edtIndM.TabIndex = 11;
            // 
            // edtAnhoM
            // 
            this.edtAnhoM.Location = new System.Drawing.Point(325, 22);
            this.edtAnhoM.Name = "edtAnhoM";
            this.edtAnhoM.Size = new System.Drawing.Size(100, 20);
            this.edtAnhoM.TabIndex = 10;
            // 
            // edtMarcaM
            // 
            this.edtMarcaM.Location = new System.Drawing.Point(83, 98);
            this.edtMarcaM.Name = "edtMarcaM";
            this.edtMarcaM.Size = new System.Drawing.Size(100, 20);
            this.edtMarcaM.TabIndex = 9;
            // 
            // edtNombreM
            // 
            this.edtNombreM.Location = new System.Drawing.Point(83, 58);
            this.edtNombreM.Name = "edtNombreM";
            this.edtNombreM.Size = new System.Drawing.Size(100, 20);
            this.edtNombreM.TabIndex = 8;
            // 
            // edtCodM
            // 
            this.edtCodM.Location = new System.Drawing.Point(78, 22);
            this.edtCodM.Name = "edtCodM";
            this.edtCodM.Size = new System.Drawing.Size(100, 20);
            this.edtCodM.TabIndex = 7;
            // 
            // cbxLineaM
            // 
            this.cbxLineaM.FormattingEnabled = true;
            this.cbxLineaM.Location = new System.Drawing.Point(83, 131);
            this.cbxLineaM.Name = "cbxLineaM";
            this.cbxLineaM.Size = new System.Drawing.Size(121, 21);
            this.cbxLineaM.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "FUNCION:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "INDUSTRIA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(204, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "AÑO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "MARCA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "NOMBRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "CODIGO:";
            // 
            // PProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 433);
            this.Controls.Add(this.tabMaquinaria);
            this.Name = "PProceso";
            this.Text = "PProceso";
            this.Load += new System.EventHandler(this.PProceso_Load);
            this.tabMaquinaria.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaquina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMaquinaria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLinea;
        private System.Windows.Forms.TextBox edtDescL;
        private System.Windows.Forms.TextBox edtNombreL;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEL;
        private System.Windows.Forms.Button btnGuardarLinea;
        private System.Windows.Forms.ComboBox cbxLineaM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtCarM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtFuncM;
        private System.Windows.Forms.TextBox edtIndM;
        private System.Windows.Forms.TextBox edtAnhoM;
        private System.Windows.Forms.TextBox edtMarcaM;
        private System.Windows.Forms.TextBox edtNombreM;
        private System.Windows.Forms.TextBox edtCodM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMaquina;
        private System.Windows.Forms.Button btnNL;
        private System.Windows.Forms.Button btnML;
        private System.Windows.Forms.Button btnCL;
        private System.Windows.Forms.Button btnEM;
        private System.Windows.Forms.Button btnNM;
        private System.Windows.Forms.Button btnGM;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnCM;
    }
}