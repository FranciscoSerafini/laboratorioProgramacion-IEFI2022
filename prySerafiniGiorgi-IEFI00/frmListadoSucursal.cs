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
    public partial class frmListadoSucursal : Form
    {
        public frmListadoSucursal()
        {
            InitializeComponent();
        }

        private void frmListadoSucursal_Load(object sender, EventArgs e)
        {
            clsSucursales sucursales= new clsSucursales();
            sucursales.ListarComboBox(lstActividadesSucursales);
        }

        private void cmdListarSucursales_Click(object sender, EventArgs e)
        {
            //llamamos a la clase
            //ejecuta el procediemento de la clase
            Int32 varFiltro = Convert.ToInt32(lstActividadesSucursales.SelectedValue);
            clsSucursales filtro = new clsSucursales();
            filtro.FiltrarClientesDeUnaSucursal(dgvListadoSucursales,varFiltro);
        }
    }
}
