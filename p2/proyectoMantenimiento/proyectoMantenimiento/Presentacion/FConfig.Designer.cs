namespace proyectoMantenimiento.Presentacion
{
    partial class FConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtPass = new System.Windows.Forms.TextBox();
            this.edtUser = new System.Windows.Forms.TextBox();
            this.edtIp = new System.Windows.Forms.TextBox();
            this.edtNombredb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbWin = new System.Windows.Forms.RadioButton();
            this.rbsql = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.edtServer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtServer);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.rbsql);
            this.groupBox1.Controls.Add(this.rbWin);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edtNombredb);
            this.groupBox1.Controls.Add(this.edtIp);
            this.groupBox1.Controls.Add(this.edtUser);
            this.groupBox1.Controls.Add(this.edtPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 224);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS CONEXION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DE USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP SERVIDOR:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NOMBRE DE BD:";
            // 
            // edtPass
            // 
            this.edtPass.Location = new System.Drawing.Point(409, 109);
            this.edtPass.Name = "edtPass";
            this.edtPass.Size = new System.Drawing.Size(100, 20);
            this.edtPass.TabIndex = 4;
            // 
            // edtUser
            // 
            this.edtUser.Location = new System.Drawing.Point(165, 109);
            this.edtUser.Name = "edtUser";
            this.edtUser.Size = new System.Drawing.Size(133, 20);
            this.edtUser.TabIndex = 5;
            // 
            // edtIp
            // 
            this.edtIp.Location = new System.Drawing.Point(347, 70);
            this.edtIp.Name = "edtIp";
            this.edtIp.Size = new System.Drawing.Size(100, 20);
            this.edtIp.TabIndex = 6;
            // 
            // edtNombredb
            // 
            this.edtNombredb.Location = new System.Drawing.Point(347, 29);
            this.edtNombredb.Name = "edtNombredb";
            this.edtNombredb.Size = new System.Drawing.Size(100, 20);
            this.edtNombredb.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "TIPO AUTENTICACION:";
            // 
            // rbWin
            // 
            this.rbWin.AutoSize = true;
            this.rbWin.Location = new System.Drawing.Point(108, 50);
            this.rbWin.Name = "rbWin";
            this.rbWin.Size = new System.Drawing.Size(81, 17);
            this.rbWin.TabIndex = 9;
            this.rbWin.TabStop = true;
            this.rbWin.Text = "WINDOWS";
            this.rbWin.UseVisualStyleBackColor = true;
            this.rbWin.CheckedChanged += new System.EventHandler(this.rbWin_CheckedChanged);
            this.rbWin.TabIndexChanged += new System.EventHandler(this.rbWin_TabIndexChanged);
            // 
            // rbsql
            // 
            this.rbsql.AutoSize = true;
            this.rbsql.Location = new System.Drawing.Point(108, 73);
            this.rbsql.Name = "rbsql";
            this.rbsql.Size = new System.Drawing.Size(46, 17);
            this.rbsql.TabIndex = 10;
            this.rbsql.TabStop = true;
            this.rbsql.Text = "SQL";
            this.rbsql.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(299, 175);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(418, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "CANCELAR";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "NOMBRE DE SERVIDOR:";
            // 
            // edtServer
            // 
            this.edtServer.Location = new System.Drawing.Point(165, 145);
            this.edtServer.Name = "edtServer";
            this.edtServer.Size = new System.Drawing.Size(100, 20);
            this.edtServer.TabIndex = 14;
            // 
            // FConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 281);
            this.Controls.Add(this.groupBox1);
            this.Name = "FConfig";
            this.Text = "FConfig";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtNombredb;
        private System.Windows.Forms.TextBox edtIp;
        private System.Windows.Forms.TextBox edtUser;
        private System.Windows.Forms.TextBox edtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbsql;
        private System.Windows.Forms.RadioButton rbWin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox edtServer;
        private System.Windows.Forms.Label label6;
    }
}