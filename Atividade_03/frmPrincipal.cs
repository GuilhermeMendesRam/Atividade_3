using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_03
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFabricantes frmFabricantes = new frmFabricantes();
            frmFabricantes.Show();
            
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculos frmVeiculos = new frmVeiculos();
            frmVeiculos.Show();
        }
    }
}
