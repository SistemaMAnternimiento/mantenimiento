﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using proyectoMantenimiento.Negocio;
using Microsoft.VisualBasic;
using dbMantenimiento2Biz;
namespace proyectoMantenimiento.Presentacion
{
    public partial class PGestorUsuario : Form
    {
        NRol negocioR;
        NUsuario negocioU;
        public PGestorUsuario()
        {
            InitializeComponent();
            negocioR = new NRol();
            negocioU = new NUsuario();
            cargarTabla();
            cargarCombo();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            if (verificarDatos())
            {
                negocioR.insertar(edtNombreRol.Text, listAsignado.Items.Cast<funcion>().ToList());
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                limpiar();
            }
            else
            {
                MessageBox.Show("DEBE LLENAR LOS DATOS CORRECTAMENTE");
            }
            

        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            String id_busqueda = Interaction.InputBox("NOMBRE DE ROL:", "BUSQUEDA", "");
            if (id_busqueda.Length != 0)
            {
                rol nRol = negocioR.buscar(id_busqueda);
                if (nRol == null || nRol.estado==false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    edtNombreRol.Text = nRol.nombre;
                    listAsignado.DataSource = nRol.privilegios;
                    Console.Write(nRol.privilegios.Count);
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            }
        }

        public bool verificarDatos(){
            if(edtNombreRol.Text!="" && listAsignado.Items.Count!=0){
                return true;
            }else{
                return false;
            }
        }

        public void limpiar()
        {
            edtNombreRol.Text = "";
            edtDescripcionRol.Text = "";
            listAsignado.Items.Clear();

        }

        public void cargarTabla()
        {
            List<funcion>l=negocioR.Listarfuncion();
            foreach(funcion f in l){
                listPriv.Items.Add(f);

            }
        }

        private void listPriv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!listAsignado.Items.Contains(listPriv.SelectedItem))
            {
                listAsignado.Items.Add(listPriv.SelectedItem);
            }
            
        }

        private void listAsignado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listAsignado.Items.Remove(listAsignado.SelectedItem);
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            String id_busqueda = Interaction.InputBox("NOMBRE DE ROL:", "BUSQUEDA", "");
            if (id_busqueda.Length != 0)
            {
                rol nRol = negocioR.buscar(id_busqueda);
                if (nRol == null && nRol.estado == false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO?", "CONFIRMAR ACCION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        negocioR.eliminar(id_busqueda);
                        MessageBox.Show("SE COMPLETO LA ACCION CORRECTAMENTE");
                    }
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            }
        }

        private void edtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarDatosU())
            {
                rol rb = (rol)cbxRol.SelectedItem;
                rol rolS = negocioR.buscar(rb.nombre);
                negocioU.insertar(edtNombre.Text,edtPass.Text,rb.id);
                MessageBox.Show("DATOS REGISTRADOS CORRECTAMENTE!!!");
                limpiarCamposU();
            }
            else
            {
                MessageBox.Show("DEBE INTRODUCIR LOS DATOS CORRECTAMENTE");
            }


        }

        public bool validarDatosU(){
            if(edtNombre.Text!="" && edtPass.Text!="" && cbxRol.SelectedItem!=null){
                return true;
            }
            else { return false; }
            
            
        }

        public void limpiarCamposU()
        {
            edtPass.Text = "";
            edtNombre.Text = "";
            cbxRol.SelectedItem = null;
        }

        private void PGestorUsuario_Load(object sender, EventArgs e)
        {

        }

        private void cargarCombo()
        {
          //  List<rol> lista= negocioR.Listar();
          //foreach(rol r in lista){
          //    cbxRol.Items.Add(r);

          //}
            cbxRol.DataSource = negocioR.Listar();
        }

        private void tabUsuario_Click(object sender, EventArgs e)
        {

        }

        private void edtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String id_busqueda = Interaction.InputBox("NOMBRE DE USUARIO:", "BUSQUEDA", "");
            if (id_busqueda.Length != 0)
            {
                Usuario nUser = negocioU.buscar(id_busqueda);
                if (nUser == null || nUser.estado == false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    edtNombre.Text = nUser.usuario;
                    edtPass.Text = nUser.password;
                    rolCollection rc= negocioR.Listar();
                    int c=0;
                    foreach(rol r in rc){
                        if (r.id == nUser.rol.id)
                        {
                           break;
                        }
                        c++;
                    }
                    cbxRol.SelectedIndex=c;
                   
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String id_busqueda = Interaction.InputBox("NOMBRE DE USUARIO:", "BUSQUEDA", "");
            if (id_busqueda.Length != 0)
            {
                Usuario nUser = negocioU.buscar(id_busqueda);
                if (nUser == null && nUser.estado == false)
                {
                    MessageBox.Show("NO EXISTE REGISTRO CON ESE NOMBRE.");
                }
                else
                {
                    if (MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO?", "CONFIRMAR ACCION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        negocioU.eliminar(id_busqueda);
                        MessageBox.Show("SE COMPLETO LA ACCION CORRECTAMENTE");
                    }
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR UN NOMBRE PARA INICIAR LA BUSQUEDA");
            }
        }
    }
}
