using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySerafiniGiorgi_IEFI
{
    public partial class frmListadoDeTodosSocios : Form
    {
        public frmListadoDeTodosSocios()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            clsSocio listar = new clsSocio();
            listar.Listar(dgvListadoSocios);
        }

        private void cmdListar_Click_1(object sender, EventArgs e)
        {
            //llamamos a la clase
            //ejecuta el procediemento de la clase
            clsSocio listar = new clsSocio();
            listar.Listar(dgvListadoSocios);
        }
    }
}
