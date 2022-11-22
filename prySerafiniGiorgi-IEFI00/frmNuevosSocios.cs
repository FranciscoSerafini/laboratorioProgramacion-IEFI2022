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
    public partial class frmNuevosSocios : Form
    {
        public frmNuevosSocios()
        {
            InitializeComponent();
        }

        private void frmAgregarNuevosClientes_Load(object sender, EventArgs e)
        {
            clsSucursales objSucursal = new clsSucursales();
            objSucursal.ListarComboBox(lstSucursal);

            clsActividad objActividad = new clsActividad();
            objActividad.ListarC(lstActividad);

            lstActividad.SelectedIndex = -1;
            lstSucursal.SelectedIndex = -1;
        }

        private void cmdAgregarCliente_Click(object sender, EventArgs e)
        {
            //llamamos a la clase
            //ejecuta el procediemento de la clase
            //agregamos el nuevo cliente
            clsSocio agregado = new clsSocio();
            agregado.Dni_Socio = Convert.ToInt32(mskDni.Text);
            agregado.Nombre_Apellido = txtNombre.Text;
            agregado.Direccion = txtDireccion.Text;
            agregado.CodigoSucursal = Convert.ToInt32(lstSucursal.SelectedIndex);
            agregado.CodigoActividad = Convert.ToInt32(lstActividad.SelectedIndex);
            agregado.Saldo = Convert.ToInt32(mskSaldo.Text);
            agregado.RegistroClientes();

        }
        private void verificacion()
        {
            if (txtNombre.Text != "" && txtDireccion.Text != "" &&  mskDni.Text != "" && mskSaldo.Text !="")
            {
                cmdAgregarCliente.Enabled = true;
            }
            else
            {
                cmdAgregarCliente.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void mskDni_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacion();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            verificacion();
        }

        private void mskCodigoSucursal_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacion();
        }

        private void mskActividad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacion();
        }

        private void mskSaldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            verificacion();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
