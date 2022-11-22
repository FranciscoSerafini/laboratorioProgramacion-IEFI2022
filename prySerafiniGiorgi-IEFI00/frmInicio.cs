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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmNuevosSocios objVentanaNuevosClientes = new frmNuevosSocios();
            objVentanaNuevosClientes.ShowDialog();

        }

        private void consultaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarCliente objVentanaBuscarCliente = new frmBuscarCliente();
            objVentanaBuscarCliente.ShowDialog();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeSocios objVentanaListadoDeSocios = new frmListadoDeSocios();
            objVentanaListadoDeSocios.ShowDialog();
        }

        private void listadoDeClieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoActividad objVentana = new frmListadoActividad();
            objVentana.ShowDialog();
        }

        private void listadoDeSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoDeTodosSocios objVentana = new frmListadoDeTodosSocios();
            objVentana.ShowDialog();
        }

        private void listadoDependiendoSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoSucursal objVentanaSucursal = new frmListadoSucursal();
            objVentanaSucursal.ShowDialog();
        }

        private void acercaDelDesarroladorDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistemas objSistemas = new frmSistemas();
            objSistemas.ShowDialog();
        }
    }
}
