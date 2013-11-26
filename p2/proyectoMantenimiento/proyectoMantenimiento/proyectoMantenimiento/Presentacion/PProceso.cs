using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Negocio;
using dbMantenimientoBiz;

namespace proyectoMantenimiento.Presentacion
{
    public partial class PProceso : Form
    {
        private int id_l;
        private string id_maq;
        private NLineaP negocioL;
        private NMaquina negocioM;
        public PProceso()
        {
            InitializeComponent();
            negocioL = new NLineaP();
            negocioM = new NMaquina();
            cargarGridL();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarLinea_Click(object sender, EventArgs e)
        {
            if(validarCLinea()){
                if(id_l==0){
                    negocioL.insertar(edtNombreL.Text, edtDescL.Text);
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                limpiarCLinea();
                cargarGridL();
                }else{
                    negocioL.modificar(id_l,edtNombreL.Text, edtDescL.Text);
                    MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                    limpiarCLinea();
                    cargarGridL();
                }
                bloquearLinea();
            }
            else { MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE"); }
        }

        public void limpiarCLinea()
        {
            edtDescL.Text = "";
            edtNombreL.Text = "";
        }

        public bool validarCLinea()
        {
            if (edtNombreL.Text.Length != 0)
            {
                return true;
            }
            else { return false; }
        }

        public void cargarGridL()
        {
            
            dgvLinea.DataSource = negocioL.listar();
           
            dgvLinea.Columns["id"].Visible = false;
            dgvLinea.Columns["estado"].Visible = false;
            dgvLinea.Columns["nombre"].Width = 150;
            dgvLinea.Columns["descripcion"].Width = 250;
            //dgvLinea.Databind

        }
        public void cargarGridM()
        {

            dgvMaquina.DataSource = negocioM.listar();

            dgvMaquina.Columns["id"].Visible = false;
            //dgvMaquina.Columns["estado"].Visible = false;
            //dgvMaquina.Columns["nombre"].Width = 150;
            //dgvMaquina.Columns["descripcion"].Width = 250;
            //dgvLinea.Databind

        }
        private void btnEliminarL_Click(object sender, EventArgs e)
        {
            int var=dgvLinea.CurrentRow.Index;
            string nombre = dgvLinea.CurrentRow.Cells[1].Value.ToString();
            if(nombre.Length!=0){

               negocioL.eliminar(nombre);
               MessageBox.Show("SE ELIMINARON LOS DATOS CORRECTAMENTE");
               cargarGridL();
            }
            limpiarCLinea();
            bloquearLinea();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddR_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateR_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            habilitarLinea();
            limpiarCLinea();
            id_l = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            habilitarLinea();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiarCLinea();
            bloquearLinea();
        }

        private void habilitarLinea()
        {
            edtNombreL.Enabled = true;
            edtDescL.Enabled = true;
            dgvLinea.Enabled = false;
            btnNL.Enabled = false;
            btnML.Enabled = false;
            btnEL.Enabled = false;
            btnGuardarLinea.Enabled = true;
            btnCL.Enabled = true;


        }

        private void bloquearLinea()
        {
            edtNombreL.Enabled = false;
            edtDescL.Enabled =false;
            dgvLinea.Enabled = true;
            btnNL.Enabled = true;
            btnML.Enabled = false;
            btnEL.Enabled = false;
            btnGuardarLinea.Enabled = false;
            btnCL.Enabled = true;

        }

        private void bloquearMaquina() {
            edtCodM.Enabled = false;
            edtNombreM.Enabled = false;
            edtMarcaM.Enabled = false;
            edtAnhoM.Enabled = false;
            edtIndM.Enabled = false;
            edtFuncM.Enabled = false;
            edtCarM.Enabled = false;
            cbxLineaM.Enabled = false;
            btnNM.Enabled = true;
            btnMM.Enabled = false;
            btnGM.Enabled = false;
            btnEM.Enabled = false;
            dgvMaquina.Enabled = true;
        }

        private void habilitarMaquina()
        {
            edtCodM.Enabled = true;
            edtNombreM.Enabled = true;
            edtMarcaM.Enabled = true;
            edtAnhoM.Enabled = true;
            edtIndM.Enabled = true;
            edtFuncM.Enabled = true;
            edtCarM.Enabled = true;
            cbxLineaM.Enabled = true;
            dgvMaquina.Enabled = false;
            btnNM.Enabled = false;
            btnGM.Enabled = true;
            
        }
        public void limpiarMaquina()
        {
            edtCodM.Text="";
            edtNombreM.Text = "";
            edtMarcaM.Text = "";
            edtAnhoM.Text = "";
            edtIndM.Text = "";
            edtFuncM.Text = "";
            edtCarM.Text = "";
            cbxLineaM.SelectedIndex=-1;
        }
        public bool validarMaquina()
        {
            if (edtNombreM.Text != "" && edtCodM.Text != "" && edtMarcaM.Text != "" && edtAnhoM.Text != "" && edtIndM.Text != "" && edtFuncM.Text != "" && edtCarM.Text != "" && cbxLineaM.SelectedIndex!=-1)
            {
                return true;
            }else{
                return false;
            }
        }
        private void tabPage1_Enter(object sender, EventArgs e)
        {
           
            bloquearLinea();
            cargarGridL();
        }

        private void dgvLinea_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEL.Enabled = true;
            btnML.Enabled = true;
            id_l = (int)dgvLinea.CurrentRow.Cells[0].Value;
            linea_produccion l = negocioL.buscar(id_l);
            edtNombreL.Text = l.nombre;
            edtDescL.Text = l.descripcion;

        }

        private void PProceso_Load(object sender, EventArgs e)
        {

        }

        private void btnNM_Click(object sender, EventArgs e)
        {
            habilitarMaquina();
            limpiarMaquina();
            id_maq = "";
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            limpiarMaquina();
            bloquearMaquina();
            cargarGridM();
        }

        private void btnGM_Click(object sender, EventArgs e)
        {
            if(validarMaquina()){

                linea_produccion p=(linea_produccion) cbxLineaM.SelectedItem;
                if(id_maq==""){
                    negocioM.insertar(edtCodM.Text, edtNombreM.Text, edtMarcaM.Text, p.id, Convert.ToInt32(edtAnhoM.Text), edtFuncM.Text, edtCarM.Text, "activo");
                    cargarGridM();
                }
                else{
                }
            }
        }

        public void cargarLlinea()
        {
            List<linea_produccion> l = negocioL.listar2();
            foreach (linea_produccion lp in l)
            {
                cbxLineaM.Items.Add(lp);
            }
        }
    }
}
