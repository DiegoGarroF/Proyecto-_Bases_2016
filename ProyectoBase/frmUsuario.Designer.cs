namespace Vista
{
    partial class frmUsuario
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
            this.btnAccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarPrivilegioPantalla = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.lvPrivilegios = new System.Windows.Forms.ListView();
            this.lvPantallaColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRoles = new System.Windows.Forms.ListView();
            this.lvRolColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPantalla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPrivilegio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.chkRol = new System.Windows.Forms.CheckBox();
            this.chkPrivilegio = new System.Windows.Forms.CheckBox();
            this.lvInsertarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConsultarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvModificarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEliminarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxBotones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(6, 14);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 31);
            this.btnAccion.TabIndex = 4;
            this.btnAccion.Text = "Accion";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(117, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 31);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnLimpiar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnAccion);
            this.gbxBotones.Location = new System.Drawing.Point(48, 398);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(305, 51);
            this.gbxBotones.TabIndex = 8;
            this.gbxBotones.TabStop = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(128, 114);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(153, 20);
            this.txtContrasena.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(5, 114);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(64, 13);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(5, 63);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(128, 63);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(153, 20);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(314, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(52, 24);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identificador:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(128, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 20);
            this.txtId.TabIndex = 1;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.txtApellidos);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblApellidos);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtId);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.btnBuscar);
            this.gbxDatos.Controls.Add(this.txtNombreUsuario);
            this.gbxDatos.Controls.Add(this.lblNombreUsuario);
            this.gbxDatos.Controls.Add(this.lblContrasena);
            this.gbxDatos.Controls.Add(this.txtContrasena);
            this.gbxDatos.Location = new System.Drawing.Point(4, 22);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(376, 322);
            this.gbxDatos.TabIndex = 7;
            this.gbxDatos.TabStop = false;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(126, 215);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(153, 20);
            this.txtApellidos.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(126, 169);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(5, 215);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(52, 13);
            this.lblApellidos.TabIndex = 13;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(5, 169);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarPrivilegioPantalla);
            this.groupBox2.Controls.Add(this.btnEliminarRol);
            this.groupBox2.Controls.Add(this.lvPrivilegios);
            this.groupBox2.Controls.Add(this.lvRoles);
            this.groupBox2.Location = new System.Drawing.Point(413, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 241);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles y Privilegios asignados a este usuario";
            // 
            // btnEliminarPrivilegioPantalla
            // 
            this.btnEliminarPrivilegioPantalla.Enabled = false;
            this.btnEliminarPrivilegioPantalla.Location = new System.Drawing.Point(271, 192);
            this.btnEliminarPrivilegioPantalla.Name = "btnEliminarPrivilegioPantalla";
            this.btnEliminarPrivilegioPantalla.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarPrivilegioPantalla.TabIndex = 3;
            this.btnEliminarPrivilegioPantalla.Text = "Eliminar provilegio";
            this.btnEliminarPrivilegioPantalla.UseVisualStyleBackColor = true;
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Enabled = false;
            this.btnEliminarRol.Location = new System.Drawing.Point(22, 192);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarRol.TabIndex = 2;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            // 
            // lvPrivilegios
            // 
            this.lvPrivilegios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvPantallaColumna,
            this.lvInsertarColumna,
            this.lvConsultarColumna,
            this.lvModificarColumna,
            this.lvEliminarColumna});
            this.lvPrivilegios.Enabled = false;
            this.lvPrivilegios.FullRowSelect = true;
            this.lvPrivilegios.GridLines = true;
            this.lvPrivilegios.Location = new System.Drawing.Point(140, 32);
            this.lvPrivilegios.Name = "lvPrivilegios";
            this.lvPrivilegios.Size = new System.Drawing.Size(323, 143);
            this.lvPrivilegios.TabIndex = 1;
            this.lvPrivilegios.UseCompatibleStateImageBehavior = false;
            this.lvPrivilegios.View = System.Windows.Forms.View.Details;
            // 
            // lvPantallaColumna
            // 
            this.lvPantallaColumna.Text = "Pantalla";
            this.lvPantallaColumna.Width = 98;
            // 
            // lvRoles
            // 
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvRolColumna});
            this.lvRoles.Enabled = false;
            this.lvRoles.GridLines = true;
            this.lvRoles.Location = new System.Drawing.Point(12, 32);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(109, 143);
            this.lvRoles.TabIndex = 0;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // lvRolColumna
            // 
            this.lvRolColumna.Text = "Rol";
            this.lvRolColumna.Width = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPantalla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbPrivilegio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Location = new System.Drawing.Point(459, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 147);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbPantalla
            // 
            this.cbPantalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPantalla.Enabled = false;
            this.cbPantalla.FormattingEnabled = true;
            this.cbPantalla.Location = new System.Drawing.Point(306, 78);
            this.cbPantalla.Name = "cbPantalla";
            this.cbPantalla.Size = new System.Drawing.Size(101, 21);
            this.cbPantalla.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pantalla:";
            // 
            // cbPrivilegio
            // 
            this.cbPrivilegio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrivilegio.Enabled = false;
            this.cbPrivilegio.FormattingEnabled = true;
            this.cbPrivilegio.Items.AddRange(new object[] {
            "Insertar",
            "Consultar",
            "Modificar",
            "Eliminar"});
            this.cbPrivilegio.Location = new System.Drawing.Point(94, 78);
            this.cbPrivilegio.Name = "cbPrivilegio";
            this.cbPrivilegio.Size = new System.Drawing.Size(100, 21);
            this.cbPrivilegio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Privilegio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol a asignar:";
            // 
            // cbRol
            // 
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Enabled = false;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante",
            "Atención al cliente"});
            this.cbRol.Location = new System.Drawing.Point(94, 16);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(100, 21);
            this.cbRol.TabIndex = 0;
            // 
            // chkRol
            // 
            this.chkRol.AutoSize = true;
            this.chkRol.Location = new System.Drawing.Point(435, 45);
            this.chkRol.Name = "chkRol";
            this.chkRol.Size = new System.Drawing.Size(15, 14);
            this.chkRol.TabIndex = 13;
            this.chkRol.UseVisualStyleBackColor = true;
            this.chkRol.CheckedChanged += new System.EventHandler(this.chkRol_CheckedChanged);
            // 
            // chkPrivilegio
            // 
            this.chkPrivilegio.AutoSize = true;
            this.chkPrivilegio.Location = new System.Drawing.Point(435, 100);
            this.chkPrivilegio.Name = "chkPrivilegio";
            this.chkPrivilegio.Size = new System.Drawing.Size(15, 14);
            this.chkPrivilegio.TabIndex = 13;
            this.chkPrivilegio.UseVisualStyleBackColor = true;
            this.chkPrivilegio.CheckedChanged += new System.EventHandler(this.chkPrivilegio_CheckedChanged);
            // 
            // lvInsertarColumna
            // 
            this.lvInsertarColumna.Text = "Insertar";
            this.lvInsertarColumna.Width = 47;
            // 
            // lvConsultarColumna
            // 
            this.lvConsultarColumna.Text = "Consultar";
            // 
            // lvModificarColumna
            // 
            this.lvModificarColumna.Text = "Modificar";
            this.lvModificarColumna.Width = 56;
            // 
            // lvEliminarColumna
            // 
            this.lvEliminarColumna.Text = "Eliminar";
            this.lvEliminarColumna.Width = 58;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 475);
            this.ControlBox = false;
            this.Controls.Add(this.chkPrivilegio);
            this.Controls.Add(this.chkRol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxBotones);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.gbxBotones.ResumeLayout(false);
            this.gbxDatos.ResumeLayout(false);
            this.gbxDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gbxDatos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRol;
        private System.Windows.Forms.ComboBox cbPantalla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPrivilegio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkRol;
        private System.Windows.Forms.CheckBox chkPrivilegio;
        private System.Windows.Forms.Button btnEliminarPrivilegioPantalla;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.ListView lvPrivilegios;
        private System.Windows.Forms.ColumnHeader lvPantallaColumna;
        private System.Windows.Forms.ListView lvRoles;
        private System.Windows.Forms.ColumnHeader lvRolColumna;
        private System.Windows.Forms.ColumnHeader lvInsertarColumna;
        private System.Windows.Forms.ColumnHeader lvConsultarColumna;
        private System.Windows.Forms.ColumnHeader lvModificarColumna;
        private System.Windows.Forms.ColumnHeader lvEliminarColumna;
    }
}