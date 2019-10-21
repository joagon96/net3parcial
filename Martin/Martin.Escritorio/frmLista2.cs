using Martin.Entidades;
using Martin.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martin.Escritorio
{
    public partial class frmLista2 : Form
    {
        public frmLista2()
        {
            InitializeComponent();
            this.dgvUsuario.AutoGenerateColumns = false;
        }

        private void FrmLista2_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            UsuarioLogic usuLog = new UsuarioLogic();
            this.dgvUsuario.DataSource = usuLog.RecuperarTodos();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuario.SelectedRows.Count > 0)
            {
                UsuarioLogic usuLog = new UsuarioLogic();
                string nombre = ((Usuario)this.dgvUsuario.SelectedRows[0].DataBoundItem).NombreUsuario;
                try
                {
                    usuLog.Eliminar(nombre);
                }
                catch (Exception EX)
                {
                    Exception ex = new Exception("Error");
                    Error er = new Error();
                    er.ShowDialog();
                }
                finally
                {
                    this.Listar();
                }
            }


        }
    }
}
