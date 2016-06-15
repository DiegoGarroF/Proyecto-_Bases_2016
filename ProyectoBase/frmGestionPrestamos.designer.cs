namespace Vista
{
    partial class frmGestionPrestamos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.IdCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.txtNombreLibro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(22, 237);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(247, 237);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(136, 237);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPrestamo.TabIndex = 8;
            this.btnBuscarPrestamo.Text = "Buscar";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.btnBuscarPrestamo.Click += new System.EventHandler(this.btnBuscarPrestamo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.IdCliente);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion del Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(202, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(71, 64);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(71, 30);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 1;
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSize = true;
            this.IdCliente.Location = new System.Drawing.Point(7, 30);
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.Size = new System.Drawing.Size(51, 13);
            this.IdCliente.TabIndex = 0;
            this.IdCliente.Text = "IdCliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIsbn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnBuscarLibro);
            this.groupBox2.Controls.Add(this.txtNombreLibro);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIdLibro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(393, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 147);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion del Libro";
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(202, 25);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 9;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // txtNombreLibro
            // 
            this.txtNombreLibro.Location = new System.Drawing.Point(73, 68);
            this.txtNombreLibro.Name = "txtNombreLibro";
            this.txtNombreLibro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreLibro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre:";
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(73, 30);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLibro.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "IdLibro:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(366, 237);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(71, 102);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 20);
            this.txtApellidos.TabIndex = 11;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(71, 105);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 20);
            this.txtIsbn.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ISBN:";
            // 
            // frmGestionPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 312);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarPrestamo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "frmGestionPrestamos";
            this.Text = "Gestión Prestamos";
            this.Load += new System.EventHandler(this.frmGestionPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label IdCliente;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.TextBox txtNombreLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label5;
    }
}