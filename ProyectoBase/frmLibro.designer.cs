namespace Vista
{
    partial class frmLibro
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnMultiFuncion = new System.Windows.Forms.Button();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(265, 250);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 45);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ISBN";
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.btnConsultar);
            this.Datos.Controls.Add(this.textBox1);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.txtISBN);
            this.Datos.Controls.Add(this.txtNombre);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Location = new System.Drawing.Point(42, 12);
            this.Datos.Name = "Datos";
            this.Datos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Datos.Size = new System.Drawing.Size(300, 218);
            this.Datos.TabIndex = 4;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultar.Image = global::ProyectoBase.Properties.Resources.buscar;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnConsultar.Location = new System.Drawing.Point(249, 19);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(45, 39);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(81, 173);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(151, 20);
            this.txtISBN.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(81, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnMultiFuncion
            // 
            this.btnMultiFuncion.Location = new System.Drawing.Point(27, 250);
            this.btnMultiFuncion.Name = "btnMultiFuncion";
            this.btnMultiFuncion.Size = new System.Drawing.Size(75, 45);
            this.btnMultiFuncion.TabIndex = 5;
            this.btnMultiFuncion.Text = "button1";
            this.btnMultiFuncion.UseVisualStyleBackColor = true;
            this.btnMultiFuncion.Click += new System.EventHandler(this.btnMultiFuncion_Click);
            // 
            // frmLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnMultiFuncion);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Libros";
            this.Load += new System.EventHandler(this.frmLibro_Load);
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnMultiFuncion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}