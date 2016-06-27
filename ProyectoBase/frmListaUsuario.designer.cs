namespace Vista
{
    partial class frmListaUsuario
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
            this.lvListaUusario = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbUsuario = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvListaUusario
            // 
            this.lvListaUusario.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvListaUusario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvListaUusario.FullRowSelect = true;
            this.lvListaUusario.GridLines = true;
            this.lvListaUusario.Location = new System.Drawing.Point(12, 45);
            this.lvListaUusario.Name = "lvListaUusario";
            this.lvListaUusario.Size = new System.Drawing.Size(524, 362);
            this.lvListaUusario.TabIndex = 0;
            this.lvListaUusario.UseCompatibleStateImageBehavior = false;
            this.lvListaUusario.View = System.Windows.Forms.View.Details;
            this.lvListaUusario.SelectedIndexChanged += new System.EventHandler(this.lvListaUusario_SelectedIndexChanged_1);
            this.lvListaUusario.DoubleClick += new System.EventHandler(this.lvListaUusario_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellidos";
            this.columnHeader3.Width = 186;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tipo";
            this.columnHeader4.Width = 177;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(104, 15);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(121, 13);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Información de Usuarios";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(231, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 465);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lvListaUusario);
            this.Name = "frmListaUsuario";
            this.Text = "frmListaUsuario";
            this.Load += new System.EventHandler(this.frmListaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvListaUusario;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}