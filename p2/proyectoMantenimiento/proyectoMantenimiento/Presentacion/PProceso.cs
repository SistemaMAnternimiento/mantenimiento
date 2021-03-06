﻿using System;
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
    public partial class PProceso : Form
    {
        private NLineaP negocioL;
        public PProceso()
        {
            InitializeComponent();
            negocioL = new NLineaP();
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
                negocioL.insertar(edtNombreL.Text, edtDescL.Text);
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                limpiarCLinea();
                cargarGridL();
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

        private void btnEliminarL_Click(object sender, EventArgs e)
        {
            int var=dgvLinea.CurrentRow.Index;
            string nombre = dgvLinea.CurrentRow.Cells[1].Value.ToString();
            if(nombre.Length!=0){

               negocioL.eliminar(nombre);
               MessageBox.Show("SE ELIMINARON LOS DATOS CORRECTAMENTE");
               cargarGridL();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PProceso_Load(object sender, EventArgs e)
        {

        }
    }
}
