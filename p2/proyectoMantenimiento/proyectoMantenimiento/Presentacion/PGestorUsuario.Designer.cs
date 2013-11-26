namespace proyectoMantenimiento.Presentacion
{
    partial class PGestorUsuario
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
            this.tabRol = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.edtDescripcionRol = new System.Windows.Forms.TextBox();
            this.edtNombreRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listAsignado = new System.Windows.Forms.ListBox();
            this.listPriv = new System.Windows.Forms.ListBox();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnBuscarRol = new System.Windows.Forms.Button();
            this.btnGuardarRol = new System.Windows.Forms.Button();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.cbxRol = new System.Windows.Forms.ComboBox();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.edtNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabRol.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRol);
            this.tabControl1.Controls.Add(this.tabUsuario);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(568, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // tabRol
            // 
            this.tabRol.Controls.Add(this.button2);
            this.tabRol.Controls.Add(this.btnNext);
            this.tabRol.Controls.Add(this.edtDescripcionRol);
            this.tabRol.Controls.Add(this.edtNombreRol);
            this.tabRol.Controls.Add(this.label5);
            this.tabRol.Controls.Add(this.label4);
            this.tabRol.Controls.Add(this.listAsignado);
            this.tabRol.Controls.Add(this.listPriv);
            this.tabRol.Controls.Add(this.btnEliminarRol);
            this.tabRol.Controls.Add(this.btnBuscarRol);
            this.tabRol.Controls.Add(this.btnGuardarRol);
            this.tabRol.Location = new System.Drawing.Point(4, 22);
            this.tabRol.Name = "tabRol";
            this.tabRol.Padding = new System.Windows.Forms.Padding(3);
            this.tabRol.Size = new System.Drawing.Size(560, 256);
            this.tabRol.TabIndex = 0;
            this.tabRol.Text = "ROL";
            this.tabRol.UseVisualStyleBackColor = true;
            this.tabRol.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(397, 65);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // edtDescripcionRol
            // 
            this.edtDescripcionRol.Location = new System.Drawing.Point(96, 87);
            this.edtDescripcionRol.Multiline = true;
            this.edtDescripcionRol.Name = "edtDescripcionRol";
            this.edtDescripcionRol.Size = new System.Drawing.Size(146, 58);
            this.edtDescripcionRol.TabIndex = 8;
            // 
            // edtNombreRol
            // 
            this.edtNombreRol.Location = new System.Drawing.Point(96, 39);
            this.edtNombreRol.Name = "edtNombreRol";
            this.edtNombreRol.Size = new System.Drawing.Size(146, 20);
            this.edtNombreRol.TabIndex = 7;
            this.edtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtNombreRol_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DESCRIPCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOMBRE:";
            // 
            // listAsignado
            // 
            this.listAsignado.FormattingEnabled = true;
            this.listAsignado.Location = new System.Drawing.Point(434, 29);
            this.listAsignado.Name = "listAsignado";
            this.listAsignado.Size = new System.Drawing.Size(120, 147);
            this.listAsignado.TabIndex = 4;
            this.listAsignado.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listAsignado_MouseDoubleClick);
            // 
            // listPriv
            // 
            this.listPriv.FormattingEnabled = true;
            this.listPriv.Location = new System.Drawing.Point(268, 29);
            this.listPriv.Name = "listPriv";
            this.listPriv.Size = new System.Drawing.Size(120, 147);
            this.listPriv.TabIndex = 3;
            this.listPriv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listPriv_MouseDoubleClick);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Location = new System.Drawing.Point(479, 200);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarRol.TabIndex = 2;
            this.btnEliminarRol.Text = "ELIMINAR";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.Location = new System.Drawing.Point(372, 200);
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarRol.TabIndex = 1;
            this.btnBuscarRol.Text = "BUSCAR";
            this.btnBuscarRol.UseVisualStyleBackColor = true;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // btnGuardarRol
            // 
            this.btnGuardarRol.Location = new System.Drawing.Point(268, 200);
            this.btnGuardarRol.Name = "btnGuardarRol";
            this.btnGuardarRol.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarRol.TabIndex = 0;
            this.btnGuardarRol.Text = "GUARDAR";
            this.btnGuardarRol.UseVisualStyleBackColor = true;
            this.btnGuardarRol.Click += new System.EventHandler(this.btnGuardarRol_Click);
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.cbxRol);
            this.tabUsuario.Controls.Add(this.edtPass);
            this.tabUsuario.Controls.Add(this.edtNombre);
            this.tabUsuario.Controls.Add(this.btnBuscar);
            this.tabUsuario.Controls.Add(this.btnEliminar);
            this.tabUsuario.Controls.Add(this.btnGuardar);
            this.tabUsuario.Controls.Add(this.label3);
            this.tabUsuario.Controls.Add(this.label2);
            this.tabUsuario.Controls.Add(this.label1);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(560, 256);
            this.tabUsuario.TabIndex = 1;
            this.tabUsuario.Text = "USUARIO";
            this.tabUsuario.UseVisualStyleBackColor = true;
            this.tabUsuario.Click += new System.EventHandler(this.tabUsuario_Click);
            // 
            // cbxRol
            // 
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Items.AddRange(new object[] {
            "seleccionar"});
            this.cbxRol.Location = new System.Drawing.Point(172, 124);
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(192, 21);
            this.cbxRol.TabIndex = 8;
            // 
            // edtPass
            // 
            this.edtPass.Location = new System.Drawing.Point(172, 87);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(192, 20);
            this.edtPass.TabIndex = 7;
            // 
            // edtNombre
            // 
            this.edtNombre.Location = new System.Drawing.Point(172, 44);
            this.edtNombre.Name = "edtNombre";
            this.edtNombre.Size = new System.Drawing.Size(192, 20);
            this.edtNombre.TabIndex = 6;
            this.edtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtNombre_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(429, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(429, 122);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(429, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ROL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA DE USUARIO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DE USUARIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PGestorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 282);
            this.Controls.Add(this.tabControl1);
            this.Name = "PGestorUsuario";
            this.Text = "GESTOR DE USUARIO";
            this.Load += new System.EventHandler(this.PGestorUsuario_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabRol.ResumeLayout(false);
            this.tabRol.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRol;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtDescripcionRol;
        private System.Windows.Forms.TextBox edtNombreRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listAsignado;
        private System.Windows.Forms.ListBox listPriv;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnBuscarRol;
        private System.Windows.Forms.Button btnGuardarRol;
        private System.Windows.Forms.ComboBox cbxRol;
        private System.Windows.Forms.TextBox edtPass;
        private System.Windows.Forms.TextBox edtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNext;
    }
}