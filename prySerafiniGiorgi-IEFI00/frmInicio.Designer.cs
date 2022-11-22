namespace prySerafiniGiorgi_IEFI
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelDesarroladorDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeSociosDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDependiendoSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelDesarroladorDelSistemaToolStripMenuItem});
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // acercaDelDesarroladorDelSistemaToolStripMenuItem
            // 
            this.acercaDelDesarroladorDelSistemaToolStripMenuItem.Name = "acercaDelDesarroladorDelSistemaToolStripMenuItem";
            this.acercaDelDesarroladorDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.acercaDelDesarroladorDelSistemaToolStripMenuItem.Text = "Acerca del desarrolador del sistema";
            this.acercaDelDesarroladorDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelDesarroladorDelSistemaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultaClienteToolStripMenuItem,
            this.toolStripSeparator2,
            this.listadoDeSociosDeudoresToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem,
            this.listadoDeClieToolStripMenuItem,
            this.listadoDependiendoSucursalToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos clientes..";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(251, 6);
            // 
            // consultaClienteToolStripMenuItem
            // 
            this.consultaClienteToolStripMenuItem.Name = "consultaClienteToolStripMenuItem";
            this.consultaClienteToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.consultaClienteToolStripMenuItem.Text = "Buscar socio..";
            this.consultaClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaClienteToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(251, 6);
            // 
            // listadoDeSociosDeudoresToolStripMenuItem
            // 
            this.listadoDeSociosDeudoresToolStripMenuItem.Name = "listadoDeSociosDeudoresToolStripMenuItem";
            this.listadoDeSociosDeudoresToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.listadoDeSociosDeudoresToolStripMenuItem.Text = "Listado de los datos de los socios..";
            this.listadoDeSociosDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeudoresToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Listado de todos los clientes..";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // listadoDeClieToolStripMenuItem
            // 
            this.listadoDeClieToolStripMenuItem.Name = "listadoDeClieToolStripMenuItem";
            this.listadoDeClieToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.listadoDeClieToolStripMenuItem.Text = "Listado dependiendo activad..";
            this.listadoDeClieToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClieToolStripMenuItem_Click);
            // 
            // listadoDependiendoSucursalToolStripMenuItem
            // 
            this.listadoDependiendoSucursalToolStripMenuItem.Name = "listadoDependiendoSucursalToolStripMenuItem";
            this.listadoDependiendoSucursalToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.listadoDependiendoSucursalToolStripMenuItem.Text = "Listado dependiendo sucursal..";
            this.listadoDependiendoSucursalToolStripMenuItem.Click += new System.EventHandler(this.listadoDependiendoSucursalToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmInicio";
            this.Text = "Bienvenidos || Sistema de control para gimnasio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consultaClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelDesarroladorDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDependiendoSucursalToolStripMenuItem;
    }
}

