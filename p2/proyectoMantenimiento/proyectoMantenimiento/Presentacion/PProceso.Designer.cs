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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarL = new System.Windows.Forms.Button();
            this.btnGuardarLinea = new System.Windows.Forms.Button();
            this.dgvLinea = new System.Windows.Forms.DataGridView();
            this.edtDescL = new System.Windows.Forms.TextBox();
            this.edtNombreL = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.maskedTextBoxAnho = new System.Windows.Forms.MaskedTextBox();
            this.textBoxFuncion = new System.Windows.Forms.TextBox();
            this.textBoxIndustria = new System.Windows.Forms.TextBox();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxLinea = new System.Windows.Forms.ComboBox();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.tabMaquinaria.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinea)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnEliminarL);
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
            // btnEliminarL
            // 
            this.btnEliminarL.Location = new System.Drawing.Point(409, 71);
            this.btnEliminarL.Name = "btnEliminarL";
            this.btnEliminarL.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarL.TabIndex = 4;
            this.btnEliminarL.Text = "ELIMINAR";
            this.btnEliminarL.UseVisualStyleBackColor = true;
            this.btnEliminarL.Click += new System.EventHandler(this.btnEliminarL_Click);
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
            this.tabPage2.Controls.Add(this.buttonAdicionar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBoxEstado);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.comboBoxLinea);
            this.tabPage2.Controls.Add(this.maskedTextBoxAnho);
            this.tabPage2.Controls.Add(this.textBoxFuncion);
            this.tabPage2.Controls.Add(this.textBoxIndustria);
            this.tabPage2.Controls.Add(this.textBoxMarca);
            this.tabPage2.Controls.Add(this.textBoxNombre);
            this.tabPage2.Controls.Add(this.textBoxId);
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
            // 
            // maskedTextBoxAnho
            // 
            this.maskedTextBoxAnho.Location = new System.Drawing.Point(330, 50);
            this.maskedTextBoxAnho.Mask = "99999";
            this.maskedTextBoxAnho.Name = "maskedTextBoxAnho";
            this.maskedTextBoxAnho.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxAnho.TabIndex = 26;
            this.maskedTextBoxAnho.ValidatingType = typeof(int);
            // 
            // textBoxFuncion
            // 
            this.textBoxFuncion.Location = new System.Drawing.Point(330, 150);
            this.textBoxFuncion.Name = "textBoxFuncion";
            this.textBoxFuncion.Size = new System.Drawing.Size(100, 20);
            this.textBoxFuncion.TabIndex = 25;
            // 
            // textBoxIndustria
            // 
            this.textBoxIndustria.Location = new System.Drawing.Point(330, 106);
            this.textBoxIndustria.Name = "textBoxIndustria";
            this.textBoxIndustria.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndustria.TabIndex = 24;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(105, 150);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(100, 20);
            this.textBoxMarca.TabIndex = 23;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(105, 106);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 22;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(105, 61);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "FUNCION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "INDUSTRIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "ANHO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "MARCA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "CODIGO:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "ESTADO";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "REPARACION",
            "DESCONTINUADO"});
            this.comboBoxEstado.Location = new System.Drawing.Point(70, 292);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "LINEA";
            // 
            // comboBoxLinea
            // 
            this.comboBoxLinea.FormattingEnabled = true;
            this.comboBoxLinea.Location = new System.Drawing.Point(70, 223);
            this.comboBoxLinea.Name = "comboBoxLinea";
            this.comboBoxLinea.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLinea.TabIndex = 27;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(234, 191);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 31;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMaquinaria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLinea;
        private System.Windows.Forms.TextBox edtDescL;
        private System.Windows.Forms.TextBox edtNombreL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarL;
        private System.Windows.Forms.Button btnGuardarLinea;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxLinea;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxAnho;
        private System.Windows.Forms.TextBox textBoxFuncion;
        private System.Windows.Forms.TextBox textBoxIndustria;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}