using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basso.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            frmListado formLista = new frmListado();
            formLista.ShowDialog();
        }
    }
}
