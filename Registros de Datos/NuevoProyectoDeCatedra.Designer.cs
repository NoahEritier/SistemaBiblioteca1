﻿namespace WindowsFormsApp1.Registros_de_Datos
{
    partial class NuevoProyectoDeCatedra
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
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtTomos = new System.Windows.Forms.TextBox();
            this.lblDocente = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblProyectosDeCatedra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.lblAño);
            this.panel1.Controls.Add(this.txtTomos);
            this.panel1.Controls.Add(this.lblDocente);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.cmbCarreras);
            this.panel1.Controls.Add(this.lblCarrera);
            this.panel1.Location = new System.Drawing.Point(48, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 763);
            this.panel1.TabIndex = 7;
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAño.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAño.Location = new System.Drawing.Point(36, 213);
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(93, 41);
            this.txtAño.TabIndex = 34;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAño.Location = new System.Drawing.Point(37, 186);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(45, 24);
            this.lblAño.TabIndex = 33;
            this.lblAño.Text = "Año";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTomos
            // 
            this.txtTomos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTomos.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTomos.Location = new System.Drawing.Point(36, 142);
            this.txtTomos.Multiline = true;
            this.txtTomos.Name = "txtTomos";
            this.txtTomos.Size = new System.Drawing.Size(403, 41);
            this.txtTomos.TabIndex = 32;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDocente.Location = new System.Drawing.Point(37, 115);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(81, 24);
            this.lblDocente.TabIndex = 31;
            this.lblDocente.Text = "Docente";
            this.lblDocente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(183, 299);
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
            this.btnCancelarRegistro.Location = new System.Drawing.Point(41, 299);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.ItemHeight = 25;
            this.cmbCarreras.Location = new System.Drawing.Point(36, 79);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(403, 33);
            this.cmbCarreras.TabIndex = 13;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCarrera.Location = new System.Drawing.Point(37, 49);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(84, 24);
            this.lblCarrera.TabIndex = 11;
            this.lblCarrera.Text = "* Carrera";
            this.lblCarrera.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProyectosDeCatedra
            // 
            this.lblProyectosDeCatedra.AutoSize = true;
            this.lblProyectosDeCatedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProyectosDeCatedra.Location = new System.Drawing.Point(103, 36);
            this.lblProyectosDeCatedra.Name = "lblProyectosDeCatedra";
            this.lblProyectosDeCatedra.Size = new System.Drawing.Size(282, 31);
            this.lblProyectosDeCatedra.TabIndex = 6;
            this.lblProyectosDeCatedra.Text = "Proyectos De Catedra";
            this.lblProyectosDeCatedra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoProyectoDeCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProyectosDeCatedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoProyectoDeCatedra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoProyectoDeCatedra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtTomos;
        private System.Windows.Forms.Label lblDocente;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelarRegistro;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblProyectosDeCatedra;
    }
}