namespace Vista
{
    partial class frmMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionNuevoLibro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.librosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.salirToolStripMenuItem.Text = "Auditoría";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeUsuariosToolStripMenuItem,
            this.mantenimientoDeRolesToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.usuariosToolStripMenuItem.Text = "Seguridad";
            // 
            // mantenimientoDeUsuariosToolStripMenuItem
            // 
            this.mantenimientoDeUsuariosToolStripMenuItem.Name = "mantenimientoDeUsuariosToolStripMenuItem";
            this.mantenimientoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mantenimientoDeUsuariosToolStripMenuItem.Text = "Mantenimiento de Usuarios";
            this.mantenimientoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeUsuariosToolStripMenuItem_Click);
            // 
            // mantenimientoDeRolesToolStripMenuItem
            // 
            this.mantenimientoDeRolesToolStripMenuItem.Name = "mantenimientoDeRolesToolStripMenuItem";
            this.mantenimientoDeRolesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mantenimientoDeRolesToolStripMenuItem.Text = "Mantenimiento de Roles";
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoPrestamoToolStripMenuItem});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // mantenimientoPrestamoToolStripMenuItem
            // 
            this.mantenimientoPrestamoToolStripMenuItem.Name = "mantenimientoPrestamoToolStripMenuItem";
            this.mantenimientoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mantenimientoPrestamoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoPrestamoToolStripMenuItem_Click);
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionNuevoLibro});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // opcionNuevoLibro
            // 
            this.opcionNuevoLibro.Name = "opcionNuevoLibro";
            this.opcionNuevoLibro.Size = new System.Drawing.Size(156, 22);
            this.opcionNuevoLibro.Text = "Mantenimiento";
            this.opcionNuevoLibro.Click += new System.EventHandler(this.opcionMantenimientoLibros);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionNuevoLibro;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeRolesToolStripMenuItem;
    }
}



