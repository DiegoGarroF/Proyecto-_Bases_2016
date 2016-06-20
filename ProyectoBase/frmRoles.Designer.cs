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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Privilegios de pantalla:";
            // 
            // chkInsertar
            // 
            this.chkInsertar.AutoSize = true;
            this.chkInsertar.Location = new System.Drawing.Point(284, 44);
            this.chkInsertar.Name = "chkInsertar";
            this.chkInsertar.Size = new System.Drawing.Size(61, 17);
            this.chkInsertar.TabIndex = 27;
            this.chkInsertar.Text = "Insertar";
            this.chkInsertar.UseVisualStyleBackColor = true;
            // 
            // btnAgregarPrivilegios
            // 
            this.btnAgregarPrivilegios.Location = new System.Drawing.Point(421, 44);
            this.btnAgregarPrivilegios.Name = "btnAgregarPrivilegios";
            this.btnAgregarPrivilegios.Size = new System.Drawing.Size(75, 40);
            this.btnAgregarPrivilegios.TabIndex = 31;
            this.btnAgregarPrivilegios.Text = "Agregar";
            this.btnAgregarPrivilegios.UseVisualStyleBackColor = true;
            this.btnAgregarPrivilegios.Click += new System.EventHandler(this.btnAgregarPrivilegios_Click);
            // 
            // chkConsultar
            // 
            this.chkConsultar.AutoSize = true;
            this.chkConsultar.Location = new System.Drawing.Point(284, 67);
            this.chkConsultar.Name = "chkConsultar";
            this.chkConsultar.Size = new System.Drawing.Size(70, 17);
            this.chkConsultar.TabIndex = 28;
            this.chkConsultar.Text = "Consultar";
            this.chkConsultar.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(284, 110);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(62, 17);
            this.chkEliminar.TabIndex = 30;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Location = new System.Drawing.Point(284, 91);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(69, 17);
            this.chkModificar.TabIndex = 29;
            this.chkModificar.Text = "Modificar";
            this.chkModificar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 145);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // cbPantalla
            // 
            this.cbPantalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPantalla.FormattingEnabled = true;
            this.cbPantalla.Location = new System.Drawing.Point(94, 68);
            this.cbPantalla.Name = "cbPantalla";
            this.cbPantalla.Size = new System.Drawing.Size(154, 21);
            this.cbPantalla.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Pantalla:";
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(94, 28);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(154, 20);
            this.txtNombreRol.TabIndex = 22;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(26, 31);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(63, 13);
            this.lbNombre.TabIndex = 21;
            this.lbNombre.Text = "Nombre Rol";
            // 
            // btnQuitarPantalla
            // 
            this.btnQuitarPantalla.Location = new System.Drawing.Point(514, 208);
            this.btnQuitarPantalla.Name = "btnQuitarPantalla";
            this.btnQuitarPantalla.Size = new System.Drawing.Size(75, 36);
            this.btnQuitarPantalla.TabIndex = 32;
            this.btnQuitarPantalla.Text = "Quitar Pantalla";
            this.btnQuitarPantalla.UseVisualStyleBackColor = true;
            this.btnQuitarPantalla.Click += new System.EventHandler(this.btnQuitarPantalla_Click);
            // 
            // lvPantalla
            // 
            this.lvPantalla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnaRol,
            this.columnaPantalla,
            this.columnaInsertar,
            this.columnaConsultar,
            this.columnaModificar,
            this.columnaEliminar});
            this.lvPantalla.FullRowSelect = true;
            this.lvPantalla.GridLines = true;
            this.lvPantalla.Location = new System.Drawing.Point(12, 208);
            this.lvPantalla.Name = "lvPantalla";
            this.lvPantalla.Size = new System.Drawing.Size(472, 200);
            this.lvPantalla.TabIndex = 31;
            this.lvPantalla.UseCompatibleStateImageBehavior = false;
            this.lvPantalla.View = System.Windows.Forms.View.Details;
            this.lvPantalla.SelectedIndexChanged += new System.EventHandler(this.lvPantalla_SelectedIndexChanged);
            // 
            // columnaRol
            // 
            this.columnaRol.Text = "Rol";
            this.columnaRol.Width = 86;
            // 
            // columnaPantalla
            // 
            this.columnaPantalla.Text = "Pantalla";
            this.columnaPantalla.Width = 141;
            // 
            // columnaInsertar
            // 
            this.columnaInsertar.Text = "Insertar";
            // 
            // columnaConsultar
            // 
            this.columnaConsultar.Text = "Consultar";
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
            this.btnEliminar.Location = new System.Drawing.Point(213, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 35);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(123, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 35);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(25, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(309, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 500);
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
    }
}