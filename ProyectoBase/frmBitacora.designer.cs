namespace Vista
{
    partial class frmBitacora
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
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.lbNombreUsuario = new System.Windows.Forms.Label();
            this.lvBitacora = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Location = new System.Drawing.Point(138, 23);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbNombreUsuario.TabIndex = 0;
            // 
            // lbNombreUsuario
            // 
            this.lbNombreUsuario.AutoSize = true;
            this.lbNombreUsuario.Location = new System.Drawing.Point(36, 23);
            this.lbNombreUsuario.Name = "lbNombreUsuario";
            this.lbNombreUsuario.Size = new System.Drawing.Size(83, 13);
            this.lbNombreUsuario.TabIndex = 1;
            this.lbNombreUsuario.Text = "Nombre Usuario";
            // 
            // lvBitacora
            // 
            this.lvBitacora.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvBitacora.FullRowSelect = true;
            this.lvBitacora.GridLines = true;
            this.lvBitacora.Location = new System.Drawing.Point(25, 70);
            this.lvBitacora.Name = "lvBitacora";
            this.lvBitacora.Size = new System.Drawing.Size(639, 258);
            this.lvBitacora.TabIndex = 2;
            this.lvBitacora.UseCompatibleStateImageBehavior = false;
            this.lvBitacora.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hora";
            this.columnHeader2.Width = 63;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nombre de la Tabla";
            this.columnHeader3.Width = 122;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descripcion";
            this.columnHeader4.Width = 346;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(272, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(656, 344);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 379);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lvBitacora);
            this.Controls.Add(this.lbNombreUsuario);
            this.Controls.Add(this.tbNombreUsuario);
            this.Name = "frmBitacora";
            this.Text = "frmBitacora";
            this.Load += new System.EventHandler(this.frmBitacora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label lbNombreUsuario;
        private System.Windows.Forms.ListView lvBitacora;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
    }
}