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
    public partial class PInicioSesion : Form
    {
        private NUsuario negocio;
        public static Usuario user;
        public PInicioSesion()
        {
            InitializeComponent();
            negocio = new NUsuario();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Usuario u = negocio.buscar(edtNombre.Text);
                if (u != null && u.password.Equals(edtPass.Text)&& u.estado==true)
                {
                    user = u;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTAS.");
                }
            }
            else
            {
                MessageBox.Show("DEBE INGRESAR TODOS LOS DATOS NECESARIOS");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        public bool validarCampos()
        {
            if(edtNombre.Text!="" && edtPass.Text!=""){
                return true;
            }
            else{
                return false;
            }
        }

        private void PInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
