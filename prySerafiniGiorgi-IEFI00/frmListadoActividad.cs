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
    public partial class frmListadoActividad : Form
    {
        public frmListadoActividad()
        {
            InitializeComponent();
        }

        private void frmListadoDependiendoActividad_Load(object sender, EventArgs e)
        {
            //llamamos a la clase
            //ejecuta el procediemento de la clase
            clsActividad actividad = new clsActividad();
            actividad.ListarC(lstActividades);

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            //listamos en la interfaz grafica

            clsSocio objCliente = new clsSocio();
            objCliente.ListarSocios2(dgvListadoActividad);
           lblSaldoTotal.Text = objCliente.TotalSaldo.ToString();
            
            lblPromedio.Text = objCliente.promedioSaldo.ToString();


        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();//nos abre la interfaz de usuario para ver elegir donde queremos la impresion
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings; //asginamos la impresora que elegimos en la ventana
            prtDocumento.Print();//ejecutara el metodo print
            MessageBox.Show("Su reporte fue impreso");

        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            clsSocio reporte = new clsSocio();
            reporte.Imprimir(e);
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            //exportamos en excel

            Int32 idActividad = Convert.ToInt32(lstActividades.SelectedValue);
            clsSocio objCliente = new clsSocio();
            objCliente.ExportarClientes(idActividad);
            
            

        }
    }
}
