﻿namespace Vista
{
    partial class frmPrestamos
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
            this.txtIdLibro = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtIdUsuarioEstudiante = new System.Windows.Forms.TextBox();
            this.txtIdUsurio = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuarioEstudiante = new System.Windows.Forms.Button();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnFuncional = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarGeneral = new System.Windows.Forms.Button();
            this.txtIdPrestamo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdLibro
            // 
            this.txtIdLibro.Location = new System.Drawing.Point(129, 72);
            this.txtIdLibro.Name = "txtIdLibro";
            this.txtIdLibro.Size = new System.Drawing.Size(100, 20);
            this.txtIdLibro.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(205, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtIdUsuarioEstudiante
            // 
            this.txtIdUsuarioEstudiante.Location = new System.Drawing.Point(129, 166);
            this.txtIdUsuarioEstudiante.Name = "txtIdUsuarioEstudiante";
            this.txtIdUsuarioEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsuarioEstudiante.TabIndex = 8;
            // 
            // txtIdUsurio
            // 
            this.txtIdUsurio.Location = new System.Drawing.Point(129, 122);
            this.txtIdUsurio.Name = "txtIdUsurio";
            this.txtIdUsurio.Size = new System.Drawing.Size(100, 20);
            this.txtIdUsurio.TabIndex = 7;
            // 
            // btnBuscarUsuarioEstudiante
            // 
            this.btnBuscarUsuarioEstudiante.Location = new System.Drawing.Point(280, 162);
            this.btnBuscarUsuarioEstudiante.Name = "btnBuscarUsuarioEstudiante";
            this.btnBuscarUsuarioEstudiante.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarUsuarioEstudiante.TabIndex = 5;
            this.btnBuscarUsuarioEstudiante.Text = "Buscar";
            this.btnBuscarUsuarioEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarUsuarioEstudiante.Click += new System.EventHandler(this.btnBuscarUsuarioEstudiante_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(280, 67);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarLibro.TabIndex = 4;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(280, 119);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarUsuario.TabIndex = 3;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnFuncional
            // 
            this.btnFuncional.Location = new System.Drawing.Point(27, 282);
            this.btnFuncional.Name = "btnFuncional";
            this.btnFuncional.Size = new System.Drawing.Size(75, 35);
            this.btnFuncional.TabIndex = 4;
            this.btnFuncional.Text = "button1";
            this.btnFuncional.UseVisualStyleBackColor = true;
            this.btnFuncional.Click += new System.EventHandler(this.btnFuncional_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnBuscarGeneral);
            this.groupBox1.Controls.Add(this.txtIdPrestamo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIdUsuarioEstudiante);
            this.groupBox1.Controls.Add(this.txtIdUsurio);
            this.groupBox1.Controls.Add(this.txtIdLibro);
            this.groupBox1.Controls.Add(this.btnBuscarUsuarioEstudiante);
            this.groupBox1.Controls.Add(this.btnBuscarLibro);
            this.groupBox1.Controls.Add(this.btnBuscarUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Prestamo";

            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(129, 212);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha:";
            // 
            // btnBuscarGeneral
            // 
            this.btnBuscarGeneral.Location = new System.Drawing.Point(280, 16);
            this.btnBuscarGeneral.Name = "btnBuscarGeneral";
            this.btnBuscarGeneral.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarGeneral.TabIndex = 11;
            this.btnBuscarGeneral.Text = "Buscar";
            this.btnBuscarGeneral.UseVisualStyleBackColor = true;
            this.btnBuscarGeneral.Click += new System.EventHandler(this.btnBuscarGeneral_Click);
            // 
            // txtIdPrestamo
            // 
            this.txtIdPrestamo.Location = new System.Drawing.Point(129, 29);
            this.txtIdPrestamo.Name = "txtIdPrestamo";
            this.txtIdPrestamo.Size = new System.Drawing.Size(100, 20);
            this.txtIdPrestamo.TabIndex = 10;
            this.txtIdPrestamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdPrestamo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "idUsuarioCliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "idUsuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "idLibro:";
            // 
            // frmPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 329);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFuncional);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Prestamos";
            this.Load += new System.EventHandler(this.frmPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdLibro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtIdUsuarioEstudiante;
        private System.Windows.Forms.TextBox txtIdUsurio;
        private System.Windows.Forms.Button btnBuscarUsuarioEstudiante;
        private System.Windows.Forms.Button btnBuscarLibro;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnFuncional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarGeneral;
        private System.Windows.Forms.TextBox txtIdPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
    }
}