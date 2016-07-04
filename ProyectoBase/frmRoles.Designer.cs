namespace Vista
{
    partial class frmRoles
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
            this.label3 = new System.Windows.Forms.Label();
            this.chkInsertar = new System.Windows.Forms.CheckBox();
            this.btnAgregarPrivilegios = new System.Windows.Forms.Button();
            this.chkConsultar = new System.Windows.Forms.CheckBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbPantalla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.btnQuitarPantalla = new System.Windows.Forms.Button();
            this.lvPantalla = new System.Windows.Forms.ListView();
            this.columnaRol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaPantalla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaInsertar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaConsultar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaModificar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnaEliminar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 14);
            this.label3.TabIndex = 26;
            this.label3.Text = "Privilegios de pantalla:";
            // 
            // chkInsertar
            // 
            this.chkInsertar.AutoSize = true;
            this.chkInsertar.Enabled = false;
            this.chkInsertar.Location = new System.Drawing.Point(363, 45);
            this.chkInsertar.Name = "chkInsertar";
            this.chkInsertar.Size = new System.Drawing.Size(68, 18);
            this.chkInsertar.TabIndex = 27;
            this.chkInsertar.Text = "Insertar";
            this.chkInsertar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPrivilegios
            // 
            this.btnAgregarPrivilegios.Enabled = false;
            this.btnAgregarPrivilegios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrivilegios.Location = new System.Drawing.Point(465, 44);
            this.btnAgregarPrivilegios.Name = "btnAgregarPrivilegios";
            this.btnAgregarPrivilegios.Size = new System.Drawing.Size(75, 31);
            this.btnAgregarPrivilegios.TabIndex = 31;
            this.btnAgregarPrivilegios.Text = "Agregar";
            this.btnAgregarPrivilegios.UseVisualStyleBackColor = true;
            this.btnAgregarPrivilegios.Click += new System.EventHandler(this.btnAgregarPrivilegios_Click);
            // 
            // chkConsultar
            // 
            this.chkConsultar.AutoSize = true;
            this.chkConsultar.Enabled = false;
            this.chkConsultar.Location = new System.Drawing.Point(363, 67);
            this.chkConsultar.Name = "chkConsultar";
            this.chkConsultar.Size = new System.Drawing.Size(76, 18);
            this.chkConsultar.TabIndex = 28;
            this.chkConsultar.Text = "Consultar";
            this.chkConsultar.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Enabled = false;
            this.chkEliminar.Location = new System.Drawing.Point(363, 110);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(66, 18);
            this.chkEliminar.TabIndex = 30;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Enabled = false;
            this.chkModificar.Location = new System.Drawing.Point(363, 91);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(73, 18);
            this.chkModificar.TabIndex = 29;
            this.chkModificar.Text = "Modificar";
            this.chkModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cbPantalla);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombreRol);
            this.groupBox1.Controls.Add(this.chkInsertar);
            this.groupBox1.Controls.Add(this.btnAgregarPrivilegios);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.chkConsultar);
            this.groupBox1.Controls.Add(this.chkModificar);
            this.groupBox1.Controls.Add(this.chkEliminar);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 149);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(245, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 29);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbPantalla
            // 
            this.cbPantalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPantalla.FormattingEnabled = true;
            this.cbPantalla.Location = new System.Drawing.Point(73, 72);
            this.cbPantalla.Name = "cbPantalla";
            this.cbPantalla.Size = new System.Drawing.Size(154, 22);
            this.cbPantalla.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pantalla:";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Enabled = false;
            this.txtNombreRol.Location = new System.Drawing.Point(73, 32);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(154, 22);
            this.txtNombreRol.TabIndex = 22;
            this.txtNombreRol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreRol_KeyPress);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(5, 35);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(70, 14);
            this.lbNombre.TabIndex = 21;
            this.lbNombre.Text = "Nombre Rol";
            // 
            // btnQuitarPantalla
            // 
            this.btnQuitarPantalla.Enabled = false;
            this.btnQuitarPantalla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarPantalla.Location = new System.Drawing.Point(536, 208);
            this.btnQuitarPantalla.Name = "btnQuitarPantalla";
            this.btnQuitarPantalla.Size = new System.Drawing.Size(75, 36);
            this.btnQuitarPantalla.TabIndex = 32;
            this.btnQuitarPantalla.Text = "Quitar Pantalla";
            this.btnQuitarPantalla.UseVisualStyleBackColor = true;
            this.btnQuitarPantalla.Click += new System.EventHandler(this.btnQuitarPantalla_Click);
            // 
            // lvPantalla
            // 
            this.lvPantalla.BackColor = System.Drawing.Color.SpringGreen;
            this.lvPantalla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaRol,
            this.columnaPantalla,
            this.columnaInsertar,
            this.columnaConsultar,
            this.columnaModificar,
            this.columnaEliminar});
            this.lvPantalla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPantalla.FullRowSelect = true;
            this.lvPantalla.GridLines = true;
            this.lvPantalla.Location = new System.Drawing.Point(13, 208);
            this.lvPantalla.Name = "lvPantalla";
            this.lvPantalla.Size = new System.Drawing.Size(517, 204);
            this.lvPantalla.TabIndex = 31;
            this.lvPantalla.UseCompatibleStateImageBehavior = false;
            this.lvPantalla.View = System.Windows.Forms.View.Details;
            // 
            // columnaRol
            // 
            this.columnaRol.Text = "Rol";
            this.columnaRol.Width = 86;
            // 
            // columnaPantalla
            // 
            this.columnaPantalla.Text = "Pantalla";
            this.columnaPantalla.Width = 183;
            // 
            // columnaInsertar
            // 
            this.columnaInsertar.Text = "Insertar";
            // 
            // columnaConsultar
            // 
            this.columnaConsultar.Text = "Consultar";
            this.columnaConsultar.Width = 64;
            // 
            // columnaModificar
            // 
            this.columnaModificar.Text = "Modificar";
            // 
            // columnaEliminar
            // 
            this.columnaEliminar.Text = "Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(251, 432);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 27);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(161, 432);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 27);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(63, 432);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 27);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(456, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(74, 27);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(354, 432);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpiar.TabIndex = 33;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(623, 502);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitarPantalla);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lvPantalla);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRoles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkInsertar;
        private System.Windows.Forms.Button btnAgregarPrivilegios;
        private System.Windows.Forms.CheckBox chkConsultar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPantalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Button btnQuitarPantalla;
        private System.Windows.Forms.ListView lvPantalla;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnaRol;
        private System.Windows.Forms.ColumnHeader columnaPantalla;
        private System.Windows.Forms.ColumnHeader columnaInsertar;
        private System.Windows.Forms.ColumnHeader columnaConsultar;
        private System.Windows.Forms.ColumnHeader columnaModificar;
        private System.Windows.Forms.ColumnHeader columnaEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}