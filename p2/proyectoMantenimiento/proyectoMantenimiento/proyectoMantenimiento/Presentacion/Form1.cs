using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Presentacion;
using dbMantenimientoBiz;

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
            //pMant.SetBounds(0, 0, 600, 500);
            //if (pMant.Modal == true)
            //{
            //    pMant.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //    pMant.TopLevel = false;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FConfig fc = new FConfig();
            fc.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PInventario pantalla_inventario = new PInventario();
            pantalla_inventario.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PSolicitudes fsol = new PSolicitudes();
            fsol.Visible = true;
        }
    }
}
