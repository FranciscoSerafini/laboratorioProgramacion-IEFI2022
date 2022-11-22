namespace prySerafiniGiorgi_IEFI
{
    partial class frmListadoDeSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoDeSocios));
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConsultaDatos = new System.Windows.Forms.GroupBox();
            this.lblPromedioSaldos = new System.Windows.Forms.Label();
            this.lblTotalSueldos = new System.Windows.Forms.Label();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblPersonasInscr = new System.Windows.Forms.Label();
            this.lblCantidadPersonasInscripitas2 = new System.Windows.Forms.Label();
            this.lblPromedioSaldos2 = new System.Windows.Forms.Label();
            this.lblTotalSaldos1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.grpConsultaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(17, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.Size = new System.Drawing.Size(494, 201);
            this.dgvGrilla.TabIndex = 0;
            this.dgvGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DNI";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Saldo";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // grpConsultaDatos
            // 
            this.grpConsultaDatos.Controls.Add(this.lblPromedioSaldos);
            this.grpConsultaDatos.Controls.Add(this.lblTotalSueldos);
            this.grpConsultaDatos.Controls.Add(this.cmdListar);
            this.grpConsultaDatos.Controls.Add(this.lblPersonasInscr);
            this.grpConsultaDatos.Controls.Add(this.lblCantidadPersonasInscripitas2);
            this.grpConsultaDatos.Controls.Add(this.lblPromedioSaldos2);
            this.grpConsultaDatos.Controls.Add(this.lblTotalSaldos1);
            this.grpConsultaDatos.Controls.Add(this.dgvGrilla);
            this.grpConsultaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpConsultaDatos.Location = new System.Drawing.Point(12, 12);
            this.grpConsultaDatos.Name = "grpConsultaDatos";
            this.grpConsultaDatos.Size = new System.Drawing.Size(523, 414);
            this.grpConsultaDatos.TabIndex = 1;
            this.grpConsultaDatos.TabStop = false;
            this.grpConsultaDatos.Text = "Consulta de datos";
            // 
            // lblPromedioSaldos
            // 
            this.lblPromedioSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromedioSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos.Location = new System.Drawing.Point(251, 329);
            this.lblPromedioSaldos.Name = "lblPromedioSaldos";
            this.lblPromedioSaldos.Size = new System.Drawing.Size(260, 32);
            this.lblPromedioSaldos.TabIndex = 11;
            // 
            // lblTotalSueldos
            // 
            this.lblTotalSueldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSueldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSueldos.Location = new System.Drawing.Point(251, 241);
            this.lblTotalSueldos.Name = "lblTotalSueldos";
            this.lblTotalSueldos.Size = new System.Drawing.Size(260, 32);
            this.lblTotalSueldos.TabIndex = 10;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(17, 382);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(494, 23);
            this.cmdListar.TabIndex = 9;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblPersonasInscr
            // 
            this.lblPersonasInscr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPersonasInscr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonasInscr.Location = new System.Drawing.Point(251, 285);
            this.lblPersonasInscr.Name = "lblPersonasInscr";
            this.lblPersonasInscr.Size = new System.Drawing.Size(260, 32);
            this.lblPersonasInscr.TabIndex = 5;
            // 
            // lblCantidadPersonasInscripitas2
            // 
            this.lblCantidadPersonasInscripitas2.AutoSize = true;
            this.lblCantidadPersonasInscripitas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPersonasInscripitas2.Location = new System.Drawing.Point(14, 286);
            this.lblCantidadPersonasInscripitas2.Name = "lblCantidadPersonasInscripitas2";
            this.lblCantidadPersonasInscripitas2.Size = new System.Drawing.Size(213, 15);
            this.lblCantidadPersonasInscripitas2.TabIndex = 3;
            this.lblCantidadPersonasInscripitas2.Text = "Cantidad de personas inscriptas";
            // 
            // lblPromedioSaldos2
            // 
            this.lblPromedioSaldos2.AutoSize = true;
            this.lblPromedioSaldos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedioSaldos2.Location = new System.Drawing.Point(14, 330);
            this.lblPromedioSaldos2.Name = "lblPromedioSaldos2";
            this.lblPromedioSaldos2.Size = new System.Drawing.Size(135, 15);
            this.lblPromedioSaldos2.TabIndex = 2;
            this.lblPromedioSaldos2.Text = "Promedio de saldos";
            // 
            // lblTotalSaldos1
            // 
            this.lblTotalSaldos1.AutoSize = true;
            this.lblTotalSaldos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos1.Location = new System.Drawing.Point(14, 242);
            this.lblTotalSaldos1.Name = "lblTotalSaldos1";
            this.lblTotalSaldos1.Size = new System.Drawing.Size(105, 15);
            this.lblTotalSaldos1.TabIndex = 1;
            this.lblTotalSaldos1.Text = "Total de saldos";
            // 
            // frmListadoDeSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 427);
            this.Controls.Add(this.grpConsultaDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListadoDeSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de socios";
            this.Load += new System.EventHandler(this.frmListadoDeSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.grpConsultaDatos.ResumeLayout(false);
            this.grpConsultaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.GroupBox grpConsultaDatos;
        private System.Windows.Forms.Label lblPromedioSaldos;
        private System.Windows.Forms.Label lblTotalSueldos;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Label lblPersonasInscr;
        private System.Windows.Forms.Label lblCantidadPersonasInscripitas2;
        private System.Windows.Forms.Label lblPromedioSaldos2;
        private System.Windows.Forms.Label lblTotalSaldos1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}