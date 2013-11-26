using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Negocio;
using dbMantenimiento2Biz;

namespace proyectoMantenimiento.Presentacion
{
    public partial class PMantenimiento : Form
    {
        NMaquina negocioM;
        NSolicitud negocioS;
        private Usuario user;
        public PMantenimiento()
        {
            InitializeComponent();
            user = Form1.user;
            negocioM= new NMaquina();
            negocioS = new NSolicitud();
            cargarCMaquina();
            cargarGSol();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PMantenimiento_Load(object sender, EventArgs e)
        {
            user = Form1.user;
        }

        public void cargarCMaquina()
        {   List<maquina>lista=negocioM.listar();
            foreach(maquina m in lista){
                cbxMaquina.Items.Add(m);
            }
        }

        private void btnSolicitud_Click(object sender, EventArgs e)
        {
            maquina m=(maquina)cbxMaquina.SelectedItem;
            negocioS.insertar(dtpFecha.Value, edtObser.Text, user.id, m.id, (string)cbxTipo.SelectedItem);
            cargarGSol();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cargarGSol()
        {

            dgvSol.DataSource = negocioS.listar(user.id);
            dgvSol.Columns["id"].Visible = false;
            dgvSol.Columns["idusuario"].Visible = false;
            dgvSol.Columns["estado"].Visible = false;
            dgvSol.Columns["maquina"].Visible = false;
            dgvSol.Columns["Usuario"].Visible = false;
        }
    }
}
