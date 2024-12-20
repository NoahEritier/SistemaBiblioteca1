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
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.btnNuevaEditorial = new System.Windows.Forms.Button();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cmbIlustraciones = new System.Windows.Forms.ComboBox();
            this.lblIlustraciones = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevoTema = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.lblProyectosDeCatedra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmbEditorial);
            this.panel1.Controls.Add(this.btnNuevaEditorial);
            this.panel1.Controls.Add(this.lblEditorial);
            this.panel1.Controls.Add(this.cmbIlustraciones);
            this.panel1.Controls.Add(this.lblIlustraciones);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.cmbTemas);
            this.panel1.Controls.Add(this.btnAgregarNuevoTema);
            this.panel1.Controls.Add(this.lblTema);
            this.panel1.Location = new System.Drawing.Point(48, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 680);
            this.panel1.TabIndex = 9;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEditorial.ForeColor = System.Drawing.Color.Black;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.ItemHeight = 25;
            this.cmbEditorial.Location = new System.Drawing.Point(36, 157);
            this.cmbEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(403, 33);
            this.cmbEditorial.TabIndex = 37;
            // 
            // btnNuevaEditorial
            // 
            this.btnNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnNuevaEditorial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNuevaEditorial.Location = new System.Drawing.Point(445, 157);
            this.btnNuevaEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaEditorial.Name = "btnNuevaEditorial";
            this.btnNuevaEditorial.Size = new System.Drawing.Size(36, 33);
            this.btnNuevaEditorial.TabIndex = 36;
            this.btnNuevaEditorial.Text = "+";
            this.btnNuevaEditorial.UseVisualStyleBackColor = true;
            this.btnNuevaEditorial.Click += new System.EventHandler(this.btnNuevaEditorial_Click);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEditorial.Location = new System.Drawing.Point(36, 124);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(77, 24);
            this.lblEditorial.TabIndex = 35;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbIlustraciones
            // 
            this.cmbIlustraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbIlustraciones.ForeColor = System.Drawing.Color.Black;
            this.cmbIlustraciones.FormattingEnabled = true;
            this.cmbIlustraciones.ItemHeight = 25;
            this.cmbIlustraciones.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbIlustraciones.Location = new System.Drawing.Point(36, 232);
            this.cmbIlustraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIlustraciones.Name = "cmbIlustraciones";
            this.cmbIlustraciones.Size = new System.Drawing.Size(81, 33);
            this.cmbIlustraciones.TabIndex = 34;
            // 
            // lblIlustraciones
            // 
            this.lblIlustraciones.AutoSize = true;
            this.lblIlustraciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIlustraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIlustraciones.Location = new System.Drawing.Point(36, 199);
            this.lblIlustraciones.Name = "lblIlustraciones";
            this.lblIlustraciones.Size = new System.Drawing.Size(114, 24);
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(193, 289);
            this.btnConfirmarRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(107, 38);
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
            this.btnCancelarRegistro.Location = new System.Drawing.Point(51, 289);
            this.btnCancelarRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // cmbTemas
            // 
            this.cmbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTemas.ForeColor = System.Drawing.Color.Black;
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.ItemHeight = 25;
            this.cmbTemas.Location = new System.Drawing.Point(36, 82);
            this.cmbTemas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(403, 33);
            this.cmbTemas.TabIndex = 13;
            // 
            // btnAgregarNuevoTema
            // 
            this.btnAgregarNuevoTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoTema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoTema.Location = new System.Drawing.Point(445, 82);
            this.btnAgregarNuevoTema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarNuevoTema.Name = "btnAgregarNuevoTema";
            this.btnAgregarNuevoTema.Size = new System.Drawing.Size(36, 33);
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
            this.lblTema.Location = new System.Drawing.Point(36, 49);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(59, 24);
            this.lblTema.TabIndex = 11;
            this.lblTema.Text = "Tema";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProyectosDeCatedra
            // 
            this.lblProyectosDeCatedra.AutoSize = true;
            this.lblProyectosDeCatedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProyectosDeCatedra.Location = new System.Drawing.Point(103, 36);
            this.lblProyectosDeCatedra.Name = "lblProyectosDeCatedra";
            this.lblProyectosDeCatedra.Size = new System.Drawing.Size(181, 31);
            this.lblProyectosDeCatedra.TabIndex = 8;
            this.lblProyectosDeCatedra.Text = "Nuevo Mapas";
            this.lblProyectosDeCatedra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoMapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProyectosDeCatedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Button btnAgregarNuevoTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label lblProyectosDeCatedra;
        private System.Windows.Forms.ComboBox cmbIlustraciones;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.Button btnNuevaEditorial;
        private System.Windows.Forms.Label lblEditorial;
    }
}