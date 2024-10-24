﻿namespace WindowsFormsApp1
{
    partial class NuevaEditorial
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
            this.btnCancelar = new WindowsFormsApp1.PillButton();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.lblNuevaEditorial = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.txtNombreEditorial);
            this.panel1.Controls.Add(this.lblNombreEditorial);
            this.panel1.Location = new System.Drawing.Point(36, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 581);
            this.panel1.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(30, 127);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 31);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(137, 127);
            this.btnConfirmarRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(80, 31);
            this.btnConfirmarRegistro.TabIndex = 30;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            this.btnConfirmarRegistro.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreEditorial.ForeColor = System.Drawing.Color.Black;
            this.txtNombreEditorial.Location = new System.Drawing.Point(26, 72);
            this.txtNombreEditorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreEditorial.Multiline = true;
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(303, 34);
            this.txtNombreEditorial.TabIndex = 4;
            // 
            // lblNombreEditorial
            // 
            this.lblNombreEditorial.AutoSize = true;
            this.lblNombreEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreEditorial.Location = new System.Drawing.Point(27, 42);
            this.lblNombreEditorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEditorial.Name = "lblNombreEditorial";
            this.lblNombreEditorial.Size = new System.Drawing.Size(72, 18);
            this.lblNombreEditorial.TabIndex = 2;
            this.lblNombreEditorial.Text = "* Nombre";
            this.lblNombreEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNuevaEditorial
            // 
            this.lblNuevaEditorial.AutoSize = true;
            this.lblNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNuevaEditorial.Location = new System.Drawing.Point(70, 32);
            this.lblNuevaEditorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaEditorial.Name = "lblNuevaEditorial";
            this.lblNuevaEditorial.Size = new System.Drawing.Size(160, 26);
            this.lblNuevaEditorial.TabIndex = 6;
            this.lblNuevaEditorial.Text = "Nueva Editorial";
            this.lblNuevaEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(919, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevaEditorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NuevaEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaEditorial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PillButton btnCancelar;
        private PillButton btnConfirmarRegistro;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Label lblNombreEditorial;
        private System.Windows.Forms.Label lblNuevaEditorial;
    }
}