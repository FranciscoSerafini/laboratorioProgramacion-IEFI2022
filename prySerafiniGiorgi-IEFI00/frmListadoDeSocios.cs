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
    public partial class frmListadoDeSocios : Form
    {
        public frmListadoDeSocios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            
            //llamamos a la clase
            //ejecuta el procediemento de la clase
            clsSocio objCliente = new clsSocio();
            objCliente.ListarSocios(dgvGrilla);
            lblTotalSueldos.Text = objCliente.TotalSaldo.ToString();
            lblPersonasInscr.Text = objCliente.cantidadSocios.ToString();
            lblPromedioSaldos.Text = objCliente.promedioSaldo.ToString();
           

        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {

        }

        private void frmListadoDeSocios_Load(object sender, EventArgs e)
        {

        }
    }
}
