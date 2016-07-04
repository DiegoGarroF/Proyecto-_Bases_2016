namespace Vista
{
    partial class frmConsultaPrestamos
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
            this.lvConsultaPrestamos = new System.Windows.Forms.ListView();
            this.idPrestamos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idLibro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idUsuarioCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvConsultaPrestamos
            // 
            this.lvConsultaPrestamos.BackColor = System.Drawing.Color.SpringGreen;
            this.lvConsultaPrestamos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idPrestamos,
            this.fecha,
            this.idUsuario,
            this.idLibro,
            this.idUsuarioCliente});
            this.lvConsultaPrestamos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvConsultaPrestamos.FullRowSelect = true;
            this.lvConsultaPrestamos.GridLines = true;
            this.lvConsultaPrestamos.Location = new System.Drawing.Point(12, 12);
            this.lvConsultaPrestamos.Name = "lvConsultaPrestamos";
            this.lvConsultaPrestamos.Size = new System.Drawing.Size(601, 232);
            this.lvConsultaPrestamos.TabIndex = 0;
            this.lvConsultaPrestamos.UseCompatibleStateImageBehavior = false;
            this.lvConsultaPrestamos.View = System.Windows.Forms.View.Details;
            this.lvConsultaPrestamos.SelectedIndexChanged += new System.EventHandler(this.lvConsultaPrestamos_SelectedIndexChanged);
            this.lvConsultaPrestamos.DoubleClick += new System.EventHandler(this.lvConsultaPrestamos_DoubleClick);
            // 
            // idPrestamos
            // 
            this.idPrestamos.Text = "IdPrestamos";
            this.idPrestamos.Width = 105;
            // 
            // fecha
            // 
            this.fecha.Text = "Fecha";
            this.fecha.Width = 113;
            // 
            // idUsuario
            // 
            this.idUsuario.Text = "IdUsuario";
            this.idUsuario.Width = 147;
            // 
            // idLibro
            // 
            this.idLibro.Text = "IdLibro";
            this.idLibro.Width = 96;
            // 
            // idUsuarioCliente
            // 
            this.idUsuarioCliente.Text = "IdUsuarioCliente";
            this.idUsuarioCliente.Width = 131;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(526, 258);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(639, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvConsultaPrestamos);
            this.Name = "frmConsultaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Prestamos";
            this.Load += new System.EventHandler(this.frmConsultaPrestamos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvConsultaPrestamos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader idPrestamos;
        private System.Windows.Forms.ColumnHeader fecha;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader idLibro;
        private System.Windows.Forms.ColumnHeader idUsuarioCliente;
    }
}