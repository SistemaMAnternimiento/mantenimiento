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
   
    public partial class FListaComponente : Form
    {
        NInventario negocio;
        public static string id;
         public static string cantidad;
         public static string monto;
        public FListaComponente()
        {
            InitializeComponent();
            negocio = new NInventario();
            List<componente> lista = negocio.lista_comp();
            foreach(componente c in lista){
                cbxLista.Items.Add(c);
            }

        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbxLista.SelectedIndex == -1 || textBox1.Text=="" || numericUpDown1.Value==0)
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS PARA CONTINUAR.");
            }
            else
            {
                componente c = (componente) cbxLista.SelectedItem;
                id = c.id;
                cantidad = Convert.ToString(numericUpDown1.Value);
                monto =textBox1.Text;
                Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }


            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }


            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;

        }
    }
}
