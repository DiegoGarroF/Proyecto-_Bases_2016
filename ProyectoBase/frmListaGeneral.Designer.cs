namespace Vista
{
    partial class frmListaGeneral
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
            this.lvGeneral = new System.Windows.Forms.ListView();
            this.lvIdentificadorColumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNombreComlumna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvGeneral
            // 
            this.lvGeneral.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvGeneral.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvIdentificadorColumna,
            this.lvNombreComlumna});
            this.lvGeneral.FullRowSelect = true;
            this.lvGeneral.GridLines = true;
            this.lvGeneral.LabelEdit = true;
            this.lvGeneral.Location = new System.Drawing.Point(12, 12);
            this.lvGeneral.Name = "lvGeneral";
            this.lvGeneral.Size = new System.Drawing.Size(231, 193);
            this.lvGeneral.TabIndex = 0;
            this.lvGeneral.UseCompatibleStateImageBehavior = false;
            this.lvGeneral.View = System.Windows.Forms.View.Details;
            this.lvGeneral.SelectedIndexChanged += new System.EventHandler(this.lvGeneral_SelectedIndexChanged);
            this.lvGeneral.DoubleClick += new System.EventHandler(this.lvGeneral_DoubleClick);
            // 
            // lvIdentificadorColumna
            // 
            this.lvIdentificadorColumna.Text = "Identificador";
            this.lvIdentificadorColumna.Width = 97;
            // 
            // lvNombreComlumna
            // 
            this.lvNombreComlumna.Text = "Nombre";
            this.lvNombreComlumna.Width = 130;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(192, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 29);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmListaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 241);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lvGeneral);
            this.Name = "frmListaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista general";
            this.Load += new System.EventHandler(this.frmListaGeneral_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvGeneral;
        private System.Windows.Forms.ColumnHeader lvIdentificadorColumna;
        private System.Windows.Forms.ColumnHeader lvNombreComlumna;
        private System.Windows.Forms.Button btnSalir;
    }
}