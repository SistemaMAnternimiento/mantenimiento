using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectoMantenimiento.Presentacion
{
    public partial class FConfig : Form
    {
        public FConfig()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rbWin_TabIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void rbWin_CheckedChanged(object sender, EventArgs e)
        {
            edtUser.Enabled = !edtUser.Enabled;
            edtPass.Enabled = !edtPass.Enabled;
        }
    }
}
