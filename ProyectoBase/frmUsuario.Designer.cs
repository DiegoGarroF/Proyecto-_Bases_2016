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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.gbxDatos = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarPrivilegioPantalla = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.lvPrivilegios = new System.Windows.Forms.ListView();
            this.lvPantallaColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvInsertarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvConsultarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvModificarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEliminarColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRoles = new System.Windows.Forms.ListView();
            this.lvRolColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarRol = new System.Windows.Forms.Button();
            this.btnAgregarPrivilegios = new System.Windows.Forms.Button();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkModificar = new System.Windows.Forms.CheckBox();
            this.chkConsultar = new System.Windows.Forms.CheckBox();
            this.chkInsertar = new System.Windows.Forms.CheckBox();
            this.cbPantalla = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRol = new System.Windows.Forms.ComboBox();
            this.chkRol = new System.Windows.Forms.CheckBox();
            this.chkPrivilegio = new System.Windows.Forms.CheckBox();
            this.gbxBotones.SuspendLayout();
            this.gbxDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(255, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(255, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnEliminar);
            this.gbxBotones.Controls.Add(this.btnModificar);
            this.gbxBotones.Controls.Add(this.btnConsultar);
            this.gbxBotones.Controls.Add(this.btnLimpiar);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnAgregar);
            this.gbxBotones.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBotones.Location = new System.Drawing.Point(17, 350);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(336, 113);
            this.gbxBotones.TabIndex = 8;
            this.gbxBotones.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(134, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 33);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(6, 66);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 34);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(134, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 34);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.SystemColors.Window;
            this.txtContrasena.Location = new System.Drawing.Point(128, 105);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(153, 22);
            this.txtContrasena.TabIndex = 3;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(5, 105);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(72, 14);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(5, 64);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(114, 14);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreUsuario.Location = new System.Drawing.Point(128, 64);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(153, 22);
            this.txtNombreUsuario.TabIndex = 2;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(291, 64);
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
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Identificador:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(128, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(153, 22);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "Automático";
            // 
            // gbxDatos
            // 
            this.gbxDatos.Controls.Add(this.cbEstado);
            this.gbxDatos.Controls.Add(this.lblEstado);
            this.gbxDatos.Controls.Add(this.label5);
            this.gbxDatos.Controls.Add(this.txtApellidos);
            this.gbxDatos.Controls.Add(this.txtNombre);
            this.gbxDatos.Controls.Add(this.lblApellidos);
            this.gbxDatos.Controls.Add(this.lblNombre);
            this.gbxDatos.Controls.Add(this.txtId);
            this.gbxDatos.Controls.Add(this.label1);
            this.gbxDatos.Controls.Add(this.btnBuscar);
            this.gbxDatos.Controls.Add(this.txtNombreUsuario);
            this.gbxDatos.Controls.Add(this.lblNombreUsuario);
            this.gbxDatos.Controls.Add(this.cbTipoUsuario);
            this.gbxDatos.Controls.Add(this.lblContrasena);
            this.gbxDatos.Controls.Add(this.txtContrasena);
            this.gbxDatos.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatos.Location = new System.Drawing.Point(4, 22);
            this.gbxDatos.Name = "gbxDatos";
            this.gbxDatos.Size = new System.Drawing.Size(376, 322);
            this.gbxDatos.TabIndex = 7;
            this.gbxDatos.TabStop = false;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Bloqueado",
            "Desbloqueado"});
            this.cbEstado.Location = new System.Drawing.Point(126, 281);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(110, 22);
            this.cbEstado.TabIndex = 18;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 281);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(44, 14);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtApellidos.Location = new System.Drawing.Point(126, 197);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(153, 22);
            this.txtApellidos.TabIndex = 15;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(128, 148);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(5, 197);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(58, 14);
            this.lblApellidos.TabIndex = 13;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 148);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 14);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombre:";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.cbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Estudiante",
            "Atención al cliente"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(126, 241);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(110, 22);
            this.cbTipoUsuario.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarPrivilegioPantalla);
            this.groupBox2.Controls.Add(this.btnEliminarRol);
            this.groupBox2.Controls.Add(this.lvPrivilegios);
            this.groupBox2.Controls.Add(this.lvRoles);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(413, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(522, 255);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles y Privilegios asignados a este usuario";
            // 
            // btnEliminarPrivilegioPantalla
            // 
            this.btnEliminarPrivilegioPantalla.Enabled = false;
            this.btnEliminarPrivilegioPantalla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPrivilegioPantalla.Location = new System.Drawing.Point(251, 204);
            this.btnEliminarPrivilegioPantalla.Name = "btnEliminarPrivilegioPantalla";
            this.btnEliminarPrivilegioPantalla.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarPrivilegioPantalla.TabIndex = 3;
            this.btnEliminarPrivilegioPantalla.Text = "Eliminar provilegio";
            this.btnEliminarPrivilegioPantalla.UseVisualStyleBackColor = true;
            this.btnEliminarPrivilegioPantalla.Click += new System.EventHandler(this.btnEliminarPrivilegioPantalla_Click);
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.Enabled = false;
            this.btnEliminarRol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.Location = new System.Drawing.Point(12, 204);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarRol.TabIndex = 2;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = true;
            this.btnEliminarRol.Click += new System.EventHandler(this.btnEliminarRol_Click);
            // 
            // lvPrivilegios
            // 
            this.lvPrivilegios.BackColor = System.Drawing.Color.SpringGreen;
            this.lvPrivilegios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvPantallaColumna,
            this.lvInsertarColumna,
            this.lvConsultarColumna,
            this.lvModificarColumna,
            this.lvEliminarColumna});
            this.lvPrivilegios.FullRowSelect = true;
            this.lvPrivilegios.GridLines = true;
            this.lvPrivilegios.Location = new System.Drawing.Point(106, 32);
            this.lvPrivilegios.Name = "lvPrivilegios";
            this.lvPrivilegios.Size = new System.Drawing.Size(410, 143);
            this.lvPrivilegios.TabIndex = 1;
            this.lvPrivilegios.UseCompatibleStateImageBehavior = false;
            this.lvPrivilegios.View = System.Windows.Forms.View.Details;
            // 
            // lvPantallaColumna
            // 
            this.lvPantallaColumna.Text = "Pantalla";
            this.lvPantallaColumna.Width = 159;
            // 
            // lvInsertarColumna
            // 
            this.lvInsertarColumna.Text = "Insertar";
            this.lvInsertarColumna.Width = 64;
            // 
            // lvConsultarColumna
            // 
            this.lvConsultarColumna.Text = "Consultar";
            this.lvConsultarColumna.Width = 65;
            // 
            // lvModificarColumna
            // 
            this.lvModificarColumna.Text = "Modificar";
            this.lvModificarColumna.Width = 63;
            // 
            // lvEliminarColumna
            // 
            this.lvEliminarColumna.Text = "Eliminar";
            this.lvEliminarColumna.Width = 55;
            // 
            // lvRoles
            // 
            this.lvRoles.BackColor = System.Drawing.Color.SpringGreen;
            this.lvRoles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvRolColumna});
            this.lvRoles.GridLines = true;
            this.lvRoles.Location = new System.Drawing.Point(12, 32);
            this.lvRoles.Name = "lvRoles";
            this.lvRoles.Size = new System.Drawing.Size(88, 143);
            this.lvRoles.TabIndex = 0;
            this.lvRoles.UseCompatibleStateImageBehavior = false;
            this.lvRoles.View = System.Windows.Forms.View.Details;
            // 
            // lvRolColumna
            // 
            this.lvRolColumna.Text = "Rol";
            this.lvRolColumna.Width = 84;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarRol);
            this.groupBox1.Controls.Add(this.btnAgregarPrivilegios);
            this.groupBox1.Controls.Add(this.chkEliminar);
            this.groupBox1.Controls.Add(this.chkModificar);
            this.groupBox1.Controls.Add(this.chkConsultar);
            this.groupBox1.Controls.Add(this.chkInsertar);
            this.groupBox1.Controls.Add(this.cbPantalla);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbRol);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(459, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 180);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarRol
            // 
            this.btnAgregarRol.Enabled = false;
            this.btnAgregarRol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRol.Location = new System.Drawing.Point(352, 16);
            this.btnAgregarRol.Name = "btnAgregarRol";
            this.btnAgregarRol.Size = new System.Drawing.Size(75, 37);
            this.btnAgregarRol.TabIndex = 11;
            this.btnAgregarRol.Text = "Agregar Rol";
            this.btnAgregarRol.UseVisualStyleBackColor = true;
            this.btnAgregarRol.Click += new System.EventHandler(this.btnAgregarRol_Click);
            // 
            // btnAgregarPrivilegios
            // 
            this.btnAgregarPrivilegios.Enabled = false;
            this.btnAgregarPrivilegios.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPrivilegios.Location = new System.Drawing.Point(352, 124);
            this.btnAgregarPrivilegios.Name = "btnAgregarPrivilegios";
            this.btnAgregarPrivilegios.Size = new System.Drawing.Size(75, 42);
            this.btnAgregarPrivilegios.TabIndex = 10;
            this.btnAgregarPrivilegios.Text = "Agregar Privilegios";
            this.btnAgregarPrivilegios.UseVisualStyleBackColor = true;
            this.btnAgregarPrivilegios.Click += new System.EventHandler(this.btnAgregarPrivilegios_Click);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Enabled = false;
            this.chkEliminar.Location = new System.Drawing.Point(242, 148);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(66, 18);
            this.chkEliminar.TabIndex = 9;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkModificar
            // 
            this.chkModificar.AutoSize = true;
            this.chkModificar.Enabled = false;
            this.chkModificar.Location = new System.Drawing.Point(242, 129);
            this.chkModificar.Name = "chkModificar";
            this.chkModificar.Size = new System.Drawing.Size(73, 18);
            this.chkModificar.TabIndex = 8;
            this.chkModificar.Text = "Modificar";
            this.chkModificar.UseVisualStyleBackColor = true;
            // 
            // chkConsultar
            // 
            this.chkConsultar.AutoSize = true;
            this.chkConsultar.Enabled = false;
            this.chkConsultar.Location = new System.Drawing.Point(242, 105);
            this.chkConsultar.Name = "chkConsultar";
            this.chkConsultar.Size = new System.Drawing.Size(76, 18);
            this.chkConsultar.TabIndex = 7;
            this.chkConsultar.Text = "Consultar";
            this.chkConsultar.UseVisualStyleBackColor = true;
            // 
            // chkInsertar
            // 
            this.chkInsertar.AutoSize = true;
            this.chkInsertar.Enabled = false;
            this.chkInsertar.Location = new System.Drawing.Point(242, 82);
            this.chkInsertar.Name = "chkInsertar";
            this.chkInsertar.Size = new System.Drawing.Size(68, 18);
            this.chkInsertar.TabIndex = 6;
            this.chkInsertar.Text = "Insertar";
            this.chkInsertar.UseVisualStyleBackColor = true;
            // 
            // cbPantalla
            // 
            this.cbPantalla.BackColor = System.Drawing.SystemColors.Window;
            this.cbPantalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPantalla.Enabled = false;
            this.cbPantalla.FormattingEnabled = true;
            this.cbPantalla.Location = new System.Drawing.Point(67, 103);
            this.cbPantalla.Name = "cbPantalla";
            this.cbPantalla.Size = new System.Drawing.Size(152, 22);
            this.cbPantalla.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pantalla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Privilegios de pantalla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol a asignar:";
            // 
            // cbRol
            // 
            this.cbRol.BackColor = System.Drawing.SystemColors.Window;
            this.cbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRol.Enabled = false;
            this.cbRol.FormattingEnabled = true;
            this.cbRol.Location = new System.Drawing.Point(84, 16);
            this.cbRol.Name = "cbRol";
            this.cbRol.Size = new System.Drawing.Size(135, 22);
            this.cbRol.TabIndex = 0;
            // 
            // chkRol
            // 
            this.chkRol.AutoSize = true;
            this.chkRol.Enabled = false;
            this.chkRol.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.chkPrivilegio.Enabled = false;
            this.chkPrivilegio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPrivilegio.Location = new System.Drawing.Point(435, 122);
            this.chkPrivilegio.Name = "chkPrivilegio";
            this.chkPrivilegio.Size = new System.Drawing.Size(15, 14);
            this.chkPrivilegio.TabIndex = 13;
            this.chkPrivilegio.UseVisualStyleBackColor = true;
            this.chkPrivilegio.CheckedChanged += new System.EventHandler(this.chkPrivilegio_CheckedChanged);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(947, 475);
            this.ControlBox = false;
            this.Controls.Add(this.chkPrivilegio);
            this.Controls.Add(this.chkRol);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxDatos);
            this.Controls.Add(this.gbxBotones);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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

        private System.Windows.Forms.Button btnAgregar;
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
        private System.Windows.Forms.CheckBox chkModificar;
        private System.Windows.Forms.CheckBox chkConsultar;
        private System.Windows.Forms.CheckBox chkInsertar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregarPrivilegios;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnAgregarRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}