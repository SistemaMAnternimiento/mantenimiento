using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Presentacion;
using dbMantenimiento2Biz;

namespace proyectoMantenimiento
{
    public partial class Form1 : Form
    {
        public static Usuario user;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user = PInicioSesion.user;
            String s = "";
        }

        private void btnAcceso_Click(object sender, EventArgs e)
        {
            PGestorUsuario pUsuario = new PGestorUsuario();
            pUsuario.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PProceso pProc = new PProceso();
            pProc.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PMantenimiento pMant = new PMantenimiento();
            pMant.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FConfig fc = new FConfig();
            fc.Visible = true;
        }
    }
}
