﻿namespace WindowsFormsApp1.Registros_de_Datos
{
    partial class NuevoMapas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbIlustraciones = new System.Windows.Forms.ComboBox();
            this.lblIlustraciones = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.cmbTema = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevoTema = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblProyectosDeCatedra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmbIlustraciones);
            this.panel1.Controls.Add(this.lblIlustraciones);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.cmbTema);
            this.panel1.Controls.Add(this.btnAgregarNuevoTema);
            this.panel1.Controls.Add(this.lblTema);
            this.panel1.Location = new System.Drawing.Point(36, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 620);
            this.panel1.TabIndex = 9;
            // 
            // cmbIlustraciones
            // 
            this.cmbIlustraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbIlustraciones.ForeColor = System.Drawing.Color.Black;
            this.cmbIlustraciones.FormattingEnabled = true;
            this.cmbIlustraciones.ItemHeight = 20;
            this.cmbIlustraciones.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbIlustraciones.Location = new System.Drawing.Point(27, 115);
            this.cmbIlustraciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbIlustraciones.Name = "cmbIlustraciones";
            this.cmbIlustraciones.Size = new System.Drawing.Size(62, 28);
            this.cmbIlustraciones.TabIndex = 34;
            // 
            // lblIlustraciones
            // 
            this.lblIlustraciones.AutoSize = true;
            this.lblIlustraciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIlustraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIlustraciones.Location = new System.Drawing.Point(28, 93);
            this.lblIlustraciones.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIlustraciones.Name = "lblIlustraciones";
            this.lblIlustraciones.Size = new System.Drawing.Size(91, 18);
            this.lblIlustraciones.TabIndex = 31;
            this.lblIlustraciones.Text = "Ilustraciones";
            this.lblIlustraciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfirmarRegistro
            // 
            this.btnConfirmarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnConfirmarRegistro.FlatAppearance.BorderSize = 0;
            this.btnConfirmarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnConfirmarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnConfirmarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(145, 162);
            this.btnConfirmarRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(80, 31);
            this.btnConfirmarRegistro.TabIndex = 28;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            this.btnConfirmarRegistro.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelarRegistro.FlatAppearance.BorderSize = 0;
            this.btnCancelarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCancelarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(38, 162);
            this.btnCancelarRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(95, 31);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // cmbTema
            // 
            this.cmbTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTema.ForeColor = System.Drawing.Color.Black;
            this.cmbTema.FormattingEnabled = true;
            this.cmbTema.ItemHeight = 20;
            this.cmbTema.Location = new System.Drawing.Point(27, 64);
            this.cmbTema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTema.Name = "cmbTema";
            this.cmbTema.Size = new System.Drawing.Size(303, 28);
            this.cmbTema.TabIndex = 13;
            // 
            // btnAgregarNuevoTema
            // 
            this.btnAgregarNuevoTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoTema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoTema.Location = new System.Drawing.Point(334, 64);
            this.btnAgregarNuevoTema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarNuevoTema.Name = "btnAgregarNuevoTema";
            this.btnAgregarNuevoTema.Size = new System.Drawing.Size(27, 27);
            this.btnAgregarNuevoTema.TabIndex = 12;
            this.btnAgregarNuevoTema.Text = "+";
            this.btnAgregarNuevoTema.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoTema.Click += new System.EventHandler(this.btnAgregarNuevoTema_Click);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTema.Location = new System.Drawing.Point(28, 40);
            this.lblTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(46, 18);
            this.lblTema.TabIndex = 11;
            this.lblTema.Text = "Tema";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProyectosDeCatedra
            // 
            this.lblProyectosDeCatedra.AutoSize = true;
            this.lblProyectosDeCatedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProyectosDeCatedra.Location = new System.Drawing.Point(77, 29);
            this.lblProyectosDeCatedra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProyectosDeCatedra.Name = "lblProyectosDeCatedra";
            this.lblProyectosDeCatedra.Size = new System.Drawing.Size(146, 26);
            this.lblProyectosDeCatedra.TabIndex = 8;
            this.lblProyectosDeCatedra.Text = "Nuevo Mapas";
            this.lblProyectosDeCatedra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoMapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(919, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProyectosDeCatedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevoMapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoMapas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIlustraciones;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelarRegistro;
        private System.Windows.Forms.ComboBox cmbTema;
        private System.Windows.Forms.Button btnAgregarNuevoTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblProyectosDeCatedra;
        private System.Windows.Forms.ComboBox cmbIlustraciones;
    }
}