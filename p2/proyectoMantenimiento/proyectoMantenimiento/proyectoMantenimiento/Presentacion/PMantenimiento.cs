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
    public partial class PMantenimiento : Form
    {
        NMaquina negocioM;
        NSolicitud negocioS;
        NMantenimiento negocioMant;
        NInventario negocioInv;
        private Usuario user;
        private int id_recomendacion;
        private int id_fproblema;
        private int id_freparo;
        private List<string[]> listac;
        private List<materialusado> listam;
        public PMantenimiento()
        {
            InitializeComponent();
            user = Form1.user;
            negocioM= new NMaquina();
            negocioS = new NSolicitud();
            negocioMant = new NMantenimiento();
            negocioInv = new NInventario();
            cargarCMaquina();
            cargarGSol();
            listac = new List<string[]>();
            listam = new List<materialusado>();
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
                cbxMaquinaP2.Items.Add(m);
                cbxMaqP.Items.Add(m);
                cbxMaqFR.Items.Add(m);
                cbxMaquinaR.Items.Add(m);
                cbxMaquinaR2.Items.Add(m);
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

        private void btnModP_Click(object sender, EventArgs e)
        {

        }

        private void btnDelP_Click(object sender, EventArgs e)
        {

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnNR_Click(object sender, EventArgs e)
        {
            habilitarRecomendacion();
            id_recomendacion = 0;
        }

        //metodo para limpiar los campos de la pestaña recomendacion
        private void limpiarRecomendacion()
        {
            edtRecR.Text = "";
            cbxMaquinaR.SelectedIndex = -1;
            cbxTipoR.SelectedIndex = -1;

        }
        //metodo encargado de verificar que todos los campos tienen datos.
        private bool validarRecomendacion()
        {
            if(edtRecR.Text!="" && cbxTipoR.SelectedIndex!=-1 && cbxMaquinaR.SelectedIndex!=-1){
                return true;
            }else{
                 MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        private bool validarFProblema()
        {
            if(edtMotivoP.Text!="" && cbxMaqP.SelectedIndex!=-1){
                return true;
            }else{
                 MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        private bool validarFReparo()
        {
            if(cbxMaqFR.SelectedIndex!=-1 && dgvCompFR.RowCount!=0 && dgvMatFR.RowCount!=0){
                return true;
            }else{
                 MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
                return false;
            }
        }
        //metodo que habilita los campos ya sea para modificar o añadir un nuevo registro
        private void habilitarRecomendacion()
        {
            edtRecR.Enabled = true;
            cbxMaquinaR.Enabled = true;
            cbxTipoR.Enabled = true;
            cbxMaquinaR2.Enabled = false;
            dgvHRec.Enabled = false;
            dgvRec.Enabled = false;
            btnGR.Enabled = true;
            btnMR.Enabled = false;
            btnER.Enabled = false; btnNR.Enabled = false;
        }
        //bloquea los campos luego realizar alguna operacion ABM
        private void bloquearRecomendacion()
        {
            edtRecR.Enabled =false;
            cbxMaquinaR.Enabled = false;
            cbxTipoR.Enabled = false;
            cbxMaquinaR2.Enabled = true;
            dgvHRec.Enabled = true;
            dgvRec.Enabled = true;
            btnGR.Enabled = false;
            btnMR.Enabled = false;
            btnER.Enabled = false;
            btnNR.Enabled = true;
        }
        private void limpiarFProblema()
        {
            edtMotivoP.Text = "";
            cbxMaqP.SelectedIndex = -1;

        }
     
        private void habilitarFProblema()
        {
            edtMotivoP.Enabled = true;
            cbxMaqP.Enabled = true;
            cbxMaquinaP2.Enabled = false;
            btnNFP.Enabled = false;
            btnMFP.Enabled = false; btnGFP.Enabled = true;
            btnEFP.Enabled = false;
            dgvHistorialP.Enabled = false;
            dgvListaP.Enabled = false;

        }
        private void bloquearFProblema()
        {
            edtMotivoP.Enabled = false;
            cbxMaqP.Enabled = false;
            cbxMaquinaP2.Enabled = true;
            btnNFP.Enabled = true;
            btnMFP.Enabled = false;
            btnEFP.Enabled = false; btnGFP.Enabled = false;
            dgvHistorialP.Enabled = true;
            dgvListaP.Enabled = true;
        }
        private void limpiarFReparacion()
        {
        }

        private void habilitarFReparacion()
        {
        }
        private void bloquearFReparacion()
        {
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            cargarRecomendacion();
            bloquearRecomendacion();
        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            limpiarRecomendacion();
            bloquearRecomendacion();
            id_recomendacion = 0;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if(id_recomendacion!=0){
                habilitarRecomendacion();
            }
        }

        private void dgvRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_recomendacion = (int)dgvRec.CurrentRow.Cells[0].Value;
            recomendacion rec = negocioMant.buscarRecomendacion(id_recomendacion);
            edtRecR.Text = rec.Propertyrecomendacion;
            List<maquina> mc = negocioM.listar();
            int c=0;
            foreach (maquina m in mc)
            {
                if(m.id==rec.idmaquina && m.estado2!=false){
                    cbxMaquinaR.SelectedIndex = c;
                    if (rec.tipo == "PREVENTIVO")
                    {
                        cbxTipoR.SelectedIndex = 0;
                    }
                    else
                    {
                        cbxTipoR.SelectedIndex = 1;
                    }
                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            cbxMaquinaR.SelectedIndex = -1;
            if (rec.tipo == "PREVENTIVO")
            {
                cbxTipoR.SelectedIndex = 0;
            }
            else
            {
                cbxTipoR.SelectedIndex = 1;
            }
            btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
        }

        private void cargarRecomendacion()
        {
            dgvRec.DataSource = negocioMant.listarRecomendacion();
            dgvRec.Columns["id"].Visible = false;
            dgvRec.Columns["estado"].Visible = false;
            dgvRec.Columns["maquina"].Visible = false;
            dgvRec.Columns[2].HeaderText = "RECOMENDACION";
        }

        private void cargarFProblema()
        {
            dgvListaP.DataSource = negocioMant.listarProblema();
            dgvListaP.Columns["id"].Visible = false;
            dgvListaP.Columns["estado"].Visible = false;
            dgvListaP.Columns["maquina"].Visible = false;
        }

        private void btnGR_Click(object sender, EventArgs e)
        {
            if(validarRecomendacion()){
                maquina m= (maquina) cbxMaquinaR.SelectedItem;
                if(id_recomendacion==0){
                    negocioMant.insertarRecomendacion(m.id, edtRecR.Text, (string)cbxTipoR.SelectedItem);
                }else{
                    negocioMant.modificarRecomendacion(id_recomendacion, m.id, edtRecR.Text, (string)cbxTipoR.SelectedItem);
                }
                limpiarRecomendacion();
                bloquearRecomendacion();
                cargarRecomendacion();
            }
        }

        private void dgvHRec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_recomendacion = (int)dgvHRec.CurrentRow.Cells[0].Value;
            recomendacion rec = negocioMant.buscarRecomendacion(id_recomendacion);
            edtRecR.Text = rec.Propertyrecomendacion;
            List<maquina> mc = negocioM.listar();
            int c = 0;
            foreach (maquina m in mc)
            {
                if (m.id == rec.idmaquina && m.estado2 != false)
                {
                    cbxMaquinaR.SelectedIndex = c;
                    if (rec.tipo == "PREVENTIVO")
                    {
                        cbxTipoR.SelectedIndex = 0;
                    }
                    else
                    {
                        cbxTipoR.SelectedIndex = 1;
                    }
                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            cbxMaquinaR.SelectedIndex = -1;
            if (rec.tipo == "PREVENTIVO")
            {
                cbxTipoR.SelectedIndex = 0;
            }
            else
            {
                cbxTipoR.SelectedIndex = 1;
            }
            btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
        }

        private void cbxMaquinaR2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHRec.DataSource = negocioMant.listarRecomendacion2((maquina)cbxMaquinaR2.SelectedItem);
            dgvHistorialP.Columns["id"].Visible = false;
            dgvHistorialP.Columns["estado"].Visible = false;
            dgvHistorialP.Columns["maquina"].Visible = false;
            dgvRec.Columns[2].HeaderText = "RECOMENDACION";
        }

        private void btnER_Click(object sender, EventArgs e)
        {
            if(id_recomendacion!=0){
                negocioMant.eliminarRecomendacion(id_recomendacion);
                cargarRecomendacion();
                limpiarRecomendacion();
                bloquearRecomendacion();
            }
        }

        private void btnCFP_Click(object sender, EventArgs e)
        {
            limpiarFProblema();
            bloquearFProblema();
            id_fproblema = 0;
        }

        private void btnNFP_Click(object sender, EventArgs e)
        {
            id_fproblema = 0;
            habilitarFProblema();

        }

        private void btnGFP_Click(object sender, EventArgs e)
        {
            if(validarFProblema()){
                maquina m= (maquina) cbxMaqP.SelectedItem;
                if(id_fproblema==0){
                    negocioMant.insertarProblema(dtpFechaP.Value, edtMotivoP.Text, m.id);
                }else{
                    negocioMant.modificarProblema(id_fproblema, dtpFechaP.Value, edtMotivoP.Text, m.id);
                }

                limpiarFProblema();
                bloquearFProblema();
                cargarFProblema();
            }
        }

        private void dgvListaP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEFP.Enabled = true;
            btnMFP.Enabled = true;
            id_fproblema = (int)dgvListaP.CurrentRow.Cells[0].Value;
            problema p = negocioMant.buscarProblema(id_fproblema);
            edtMotivoP.Text = p.motivo;
            dtpFechaP.Value = (DateTime)p.fecha;
            List<maquina> mc = negocioM.listar();
            int c = 0;
            foreach (maquina m in mc)
            {
                if (m.id == p.idmaquina && m.estado2 != false)
                {
                    cbxMaqP.SelectedIndex = c;
                    
                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            cbxMaqP.SelectedIndex = -1;

        }

        private void dgvHistorialP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEFP.Enabled = true;
            btnMFP.Enabled = true;
            id_fproblema = (int)dgvHistorialP.CurrentRow.Cells[0].Value;
            problema p = negocioMant.buscarProblema(id_fproblema);
            edtMotivoP.Text = p.motivo;
            dtpFechaP.Value = (DateTime)p.fecha;
            List<maquina> mc = negocioM.listar();
            int c = 0;
            foreach (maquina m in mc)
            {
                if (m.id == p.idmaquina && m.estado2 != false)
                {
                    cbxMaquinaR.SelectedIndex = c;

                    btnMR.Enabled = true; btnER.Enabled = true; btnNR.Enabled = false;
                    return;
                }
                c++;
            }
            MessageBox.Show("DEBE ACTUALIZAR EL CAMPO MAQUINA.");
            cbxMaquinaR.SelectedIndex = -1;

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            bloquearFProblema();
            cargarFProblema();
        }

        private void btnEFP_Click(object sender, EventArgs e)
        {
            if(id_fproblema!=0){
                negocioMant.eliminarProblema(id_fproblema);
                limpiarFProblema();
                cargarFProblema();
                bloquearFProblema();
                id_fproblema = 0;
            }
        }

        private void btnMFP_Click(object sender, EventArgs e)
        {
            if (id_fproblema != 0)
            {
                habilitarFProblema();
            }
        }

        private void cbxMaquinaP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHistorialP.DataSource = negocioMant.listarProblema2((maquina)cbxMaquinaP2.SelectedItem);
            dgvHistorialP.Columns["id"].Visible = false;
            dgvHistorialP.Columns["estado"].Visible = false;
            dgvHistorialP.Columns["maquina"].Visible = false;
            //dgvRec.Columns[2].HeaderText = "RECOMENDACION";
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            FListaComponente form = new FListaComponente();
            form.ShowDialog(this);
            componente c = negocioInv.buscar_c(FListaComponente.id);
            
            if(!verificar_c(c)){
              
            string[] row = new string[] { c.nombre, FListaComponente.cantidad, FListaComponente.monto };
            listac.Add(row);
            dgvCompFR.Rows.Add(row);
            }
            
            
        }


        public void preparar_grilla_comp()
        {
            dgvCompFR.ColumnCount = 3;
            dgvCompFR.Columns[0].Name = "NOMBRE";
            dgvCompFR.Columns[1].Name = "CANTIDAD";
            dgvCompFR.Columns[2].Name = "PRECIO";
        }


        private bool verificar_c(componente c)
        {
            foreach (string[] cmp in listac)
            {
           
               if(cmp[0]==c.nombre){
                   return true;
               }
           
           }
           return false;
        }

        private bool verificar_mat(material_herramienta m)
        {
            foreach(materialusado mh in listam){
           
               if(mh.idmaterial==m.id){
                   return true;
               }
           
           }
           return false;
        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            edtMecanico.Text = user.usuario;
            preparar_grilla_comp();
        }

        private void btnNFR_Click(object sender, EventArgs e)
        {

        }
        

    }
}
