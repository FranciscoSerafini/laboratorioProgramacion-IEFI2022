namespace prySerafiniGiorgi_IEFI
{
    partial class frmNuevosSocios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevosSocios));
            this.grpNuevoSocio = new System.Windows.Forms.GroupBox();
            this.cmdAgregarCliente = new System.Windows.Forms.Button();
            this.mskSaldo = new System.Windows.Forms.MaskedTextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lstSucursal = new System.Windows.Forms.ComboBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNuevoSocio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNuevoSocio
            // 
            this.grpNuevoSocio.Controls.Add(this.lstActividad);
            this.grpNuevoSocio.Controls.Add(this.lstSucursal);
            this.grpNuevoSocio.Controls.Add(this.pictureBox1);
            this.grpNuevoSocio.Controls.Add(this.cmdAgregarCliente);
            this.grpNuevoSocio.Controls.Add(this.mskSaldo);
            this.grpNuevoSocio.Controls.Add(this.mskDni);
            this.grpNuevoSocio.Controls.Add(this.lblNombre);
            this.grpNuevoSocio.Controls.Add(this.lblSaldo);
            this.grpNuevoSocio.Controls.Add(this.lblDni);
            this.grpNuevoSocio.Controls.Add(this.txtNombre);
            this.grpNuevoSocio.Controls.Add(this.lblActividad);
            this.grpNuevoSocio.Controls.Add(this.txtDireccion);
            this.grpNuevoSocio.Controls.Add(this.lblDetalle);
            this.grpNuevoSocio.Controls.Add(this.lblDireccion);
            this.grpNuevoSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoSocio.Location = new System.Drawing.Point(12, 12);
            this.grpNuevoSocio.Name = "grpNuevoSocio";
            this.grpNuevoSocio.Size = new System.Drawing.Size(414, 269);
            this.grpNuevoSocio.TabIndex = 0;
            this.grpNuevoSocio.TabStop = false;
            this.grpNuevoSocio.Text = "Nuevo socio";
            this.grpNuevoSocio.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdAgregarCliente
            // 
            this.cmdAgregarCliente.Enabled = false;
            this.cmdAgregarCliente.Location = new System.Drawing.Point(311, 231);
            this.cmdAgregarCliente.Name = "cmdAgregarCliente";
            this.cmdAgregarCliente.Size = new System.Drawing.Size(88, 29);
            this.cmdAgregarCliente.TabIndex = 24;
            this.cmdAgregarCliente.Text = "Agregar";
            this.cmdAgregarCliente.UseVisualStyleBackColor = true;
            this.cmdAgregarCliente.Click += new System.EventHandler(this.cmdAgregarCliente_Click);
            // 
            // mskSaldo
            // 
            this.mskSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSaldo.Location = new System.Drawing.Point(146, 234);
            this.mskSaldo.Mask = "0000000000";
            this.mskSaldo.Name = "mskSaldo";
            this.mskSaldo.Size = new System.Drawing.Size(141, 21);
            this.mskSaldo.TabIndex = 23;
            this.mskSaldo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSaldo_MaskInputRejected);
            // 
            // mskDni
            // 
            this.mskDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDni.Location = new System.Drawing.Point(146, 70);
            this.mskDni.Mask = "0000000000";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(141, 21);
            this.mskDni.TabIndex = 18;
            this.mskDni.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskDni_MaskInputRejected);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 15);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre y apellido";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(6, 234);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(48, 15);
            this.lblSaldo.TabIndex = 17;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(6, 70);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(71, 15);
            this.lblDni.TabIndex = 12;
            this.lblDni.Text = "Dni socio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(136, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 21);
            this.txtNombre.TabIndex = 19;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(6, 193);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(68, 15);
            this.lblActividad.TabIndex = 16;
            this.lblActividad.Text = "Actividad:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(146, 106);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(141, 21);
            this.txtDireccion.TabIndex = 20;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(6, 152);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(119, 15);
            this.lblDetalle.TabIndex = 15;
            this.lblDetalle.Text = "Detalle  sucursal:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(6, 111);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 15);
            this.lblDireccion.TabIndex = 14;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lstSucursal
            // 
            this.lstSucursal.FormattingEnabled = true;
            this.lstSucursal.Location = new System.Drawing.Point(146, 152);
            this.lstSucursal.Name = "lstSucursal";
            this.lstSucursal.Size = new System.Drawing.Size(141, 23);
            this.lstSucursal.TabIndex = 26;
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(146, 193);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(141, 23);
            this.lstActividad.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::prySerafiniGiorgi_IEFI.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(311, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // frmNuevosSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 298);
            this.Controls.Add(this.grpNuevoSocio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNuevosSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nuevos socios";
            this.Load += new System.EventHandler(this.frmAgregarNuevosClientes_Load);
            this.grpNuevoSocio.ResumeLayout(false);
            this.grpNuevoSocio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNuevoSocio;
        private System.Windows.Forms.Button cmdAgregarCliente;
        private System.Windows.Forms.MaskedTextBox mskSaldo;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.ComboBox lstSucursal;
    }
}