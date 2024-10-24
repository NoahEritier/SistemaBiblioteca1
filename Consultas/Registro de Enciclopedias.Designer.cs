﻿namespace WindowsFormsApp1.Consultas
{
    partial class Registro_de_Diccionarios
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
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodoTema = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbFiltroIdioma = new System.Windows.Forms.ComboBox();
            this.dgvEnciclopedia = new System.Windows.Forms.DataGridView();
            this.btnNuevaEnciclopedia = new WindowsFormsApp1.PillButton();
            this.btnBuscarEnciclopedia = new WindowsFormsApp1.PillButton();
            this.cmbFiltroTema = new System.Windows.Forms.ComboBox();
            this.txtFiltroTituloEnciclopedia = new System.Windows.Forms.TextBox();
            this.lblFiltroTema = new System.Windows.Forms.Label();
            this.lblFiltroTituloEnciclopedia = new System.Windows.Forms.Label();
            this.lblEnciclopediasRegistradas = new System.Windows.Forms.Label();
            this.btnModificarEnciclopedias = new WindowsFormsApp1.PillButton();
            this.btnEliminarEnciclopedias = new WindowsFormsApp1.PillButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnciclopedia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnEliminarEnciclopedias);
            this.panel1.Controls.Add(this.btnModificarEnciclopedias);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblPeriodoTema);
            this.panel1.Controls.Add(this.lblIdioma);
            this.panel1.Controls.Add(this.cmbFiltroIdioma);
            this.panel1.Controls.Add(this.dgvEnciclopedia);
            this.panel1.Controls.Add(this.btnNuevaEnciclopedia);
            this.panel1.Controls.Add(this.btnBuscarEnciclopedia);
            this.panel1.Controls.Add(this.cmbFiltroTema);
            this.panel1.Controls.Add(this.txtFiltroTituloEnciclopedia);
            this.panel1.Controls.Add(this.lblFiltroTema);
            this.panel1.Controls.Add(this.lblFiltroTituloEnciclopedia);
            this.panel1.Location = new System.Drawing.Point(36, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 592);
            this.panel1.TabIndex = 9;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(22, 211);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroPeriodo.TabIndex = 10;
            // 
            // lblPeriodoTema
            // 
            this.lblPeriodoTema.AutoSize = true;
            this.lblPeriodoTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPeriodoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPeriodoTema.Location = new System.Drawing.Point(22, 190);
            this.lblPeriodoTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodoTema.Name = "lblPeriodoTema";
            this.lblPeriodoTema.Size = new System.Drawing.Size(60, 18);
            this.lblPeriodoTema.TabIndex = 11;
            this.lblPeriodoTema.Text = "Periodo";
            this.lblPeriodoTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdioma.Location = new System.Drawing.Point(22, 86);
            this.lblIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(52, 18);
            this.lblIdioma.TabIndex = 9;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroIdioma
            // 
            this.cmbFiltroIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroIdioma.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroIdioma.FormattingEnabled = true;
            this.cmbFiltroIdioma.Location = new System.Drawing.Point(22, 107);
            this.cmbFiltroIdioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroIdioma.Name = "cmbFiltroIdioma";
            this.cmbFiltroIdioma.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroIdioma.TabIndex = 8;
            // 
            // dgvEnciclopedia
            // 
            this.dgvEnciclopedia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnciclopedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnciclopedia.Location = new System.Drawing.Point(22, 310);
            this.dgvEnciclopedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEnciclopedia.Name = "dgvEnciclopedia";
            this.dgvEnciclopedia.RowHeadersWidth = 51;
            this.dgvEnciclopedia.RowTemplate.Height = 24;
            this.dgvEnciclopedia.Size = new System.Drawing.Size(726, 337);
            this.dgvEnciclopedia.TabIndex = 7;
            // 
            // btnNuevaEnciclopedia
            // 
            this.btnNuevaEnciclopedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevaEnciclopedia.FlatAppearance.BorderSize = 0;
            this.btnNuevaEnciclopedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevaEnciclopedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevaEnciclopedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEnciclopedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEnciclopedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaEnciclopedia.Location = new System.Drawing.Point(124, 250);
            this.btnNuevaEnciclopedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevaEnciclopedia.Name = "btnNuevaEnciclopedia";
            this.btnNuevaEnciclopedia.Size = new System.Drawing.Size(182, 31);
            this.btnNuevaEnciclopedia.TabIndex = 6;
            this.btnNuevaEnciclopedia.Text = "+ Nueva Enciclopedia";
            this.btnNuevaEnciclopedia.UseVisualStyleBackColor = false;
            this.btnNuevaEnciclopedia.Click += new System.EventHandler(this.btnNuevaEnciclopedia_Click);
            // 
            // btnBuscarEnciclopedia
            // 
            this.btnBuscarEnciclopedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarEnciclopedia.FlatAppearance.BorderSize = 0;
            this.btnBuscarEnciclopedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarEnciclopedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarEnciclopedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEnciclopedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEnciclopedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEnciclopedia.Location = new System.Drawing.Point(32, 250);
            this.btnBuscarEnciclopedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarEnciclopedia.Name = "btnBuscarEnciclopedia";
            this.btnBuscarEnciclopedia.Size = new System.Drawing.Size(76, 31);
            this.btnBuscarEnciclopedia.TabIndex = 5;
            this.btnBuscarEnciclopedia.Text = "Buscar";
            this.btnBuscarEnciclopedia.UseVisualStyleBackColor = false;
            this.btnBuscarEnciclopedia.Click += new System.EventHandler(this.btnBuscarEnciclopedia_Click);
            // 
            // cmbFiltroTema
            // 
            this.cmbFiltroTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroTema.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroTema.FormattingEnabled = true;
            this.cmbFiltroTema.Location = new System.Drawing.Point(22, 158);
            this.cmbFiltroTema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltroTema.Name = "cmbFiltroTema";
            this.cmbFiltroTema.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroTema.TabIndex = 2;
            // 
            // txtFiltroTituloEnciclopedia
            // 
            this.txtFiltroTituloEnciclopedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroTituloEnciclopedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroTituloEnciclopedia.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroTituloEnciclopedia.Location = new System.Drawing.Point(22, 46);
            this.txtFiltroTituloEnciclopedia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroTituloEnciclopedia.Multiline = true;
            this.txtFiltroTituloEnciclopedia.Name = "txtFiltroTituloEnciclopedia";
            this.txtFiltroTituloEnciclopedia.Size = new System.Drawing.Size(376, 34);
            this.txtFiltroTituloEnciclopedia.TabIndex = 4;
            // 
            // lblFiltroTema
            // 
            this.lblFiltroTema.AutoSize = true;
            this.lblFiltroTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroTema.Location = new System.Drawing.Point(22, 136);
            this.lblFiltroTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroTema.Name = "lblFiltroTema";
            this.lblFiltroTema.Size = new System.Drawing.Size(46, 18);
            this.lblFiltroTema.TabIndex = 3;
            this.lblFiltroTema.Text = "Tema";
            this.lblFiltroTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFiltroTituloEnciclopedia
            // 
            this.lblFiltroTituloEnciclopedia.AutoSize = true;
            this.lblFiltroTituloEnciclopedia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroTituloEnciclopedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroTituloEnciclopedia.Location = new System.Drawing.Point(22, 24);
            this.lblFiltroTituloEnciclopedia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroTituloEnciclopedia.Name = "lblFiltroTituloEnciclopedia";
            this.lblFiltroTituloEnciclopedia.Size = new System.Drawing.Size(44, 18);
            this.lblFiltroTituloEnciclopedia.TabIndex = 2;
            this.lblFiltroTituloEnciclopedia.Text = "Titulo";
            this.lblFiltroTituloEnciclopedia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnciclopediasRegistradas
            // 
            this.lblEnciclopediasRegistradas.AutoSize = true;
            this.lblEnciclopediasRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEnciclopediasRegistradas.Location = new System.Drawing.Point(75, 36);
            this.lblEnciclopediasRegistradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnciclopediasRegistradas.Name = "lblEnciclopediasRegistradas";
            this.lblEnciclopediasRegistradas.Size = new System.Drawing.Size(269, 26);
            this.lblEnciclopediasRegistradas.TabIndex = 8;
            this.lblEnciclopediasRegistradas.Text = "Enciclopedias Registradas";
            this.lblEnciclopediasRegistradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnModificarEnciclopedias
            // 
            this.btnModificarEnciclopedias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarEnciclopedias.FlatAppearance.BorderSize = 0;
            this.btnModificarEnciclopedias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarEnciclopedias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarEnciclopedias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarEnciclopedias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEnciclopedias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarEnciclopedias.Location = new System.Drawing.Point(325, 250);
            this.btnModificarEnciclopedias.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarEnciclopedias.Name = "btnModificarEnciclopedias";
            this.btnModificarEnciclopedias.Size = new System.Drawing.Size(82, 31);
            this.btnModificarEnciclopedias.TabIndex = 12;
            this.btnModificarEnciclopedias.Text = "Modificar";
            this.btnModificarEnciclopedias.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEnciclopedias
            // 
            this.btnEliminarEnciclopedias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarEnciclopedias.FlatAppearance.BorderSize = 0;
            this.btnEliminarEnciclopedias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarEnciclopedias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarEnciclopedias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEnciclopedias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEnciclopedias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarEnciclopedias.Location = new System.Drawing.Point(426, 250);
            this.btnEliminarEnciclopedias.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEnciclopedias.Name = "btnEliminarEnciclopedias";
            this.btnEliminarEnciclopedias.Size = new System.Drawing.Size(76, 31);
            this.btnEliminarEnciclopedias.TabIndex = 13;
            this.btnEliminarEnciclopedias.Text = "Eliminar";
            this.btnEliminarEnciclopedias.UseVisualStyleBackColor = false;
            // 
            // Registro_de_Diccionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(919, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEnciclopediasRegistradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Registro_de_Diccionarios";
            this.Text = "Registro_de_Diccionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnciclopedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEnciclopedia;
        private PillButton btnNuevaEnciclopedia;
        private PillButton btnBuscarEnciclopedia;
        private System.Windows.Forms.ComboBox cmbFiltroTema;
        private System.Windows.Forms.TextBox txtFiltroTituloEnciclopedia;
        private System.Windows.Forms.Label lblFiltroTema;
        private System.Windows.Forms.Label lblFiltroTituloEnciclopedia;
        private System.Windows.Forms.Label lblEnciclopediasRegistradas;
        private System.Windows.Forms.ComboBox cmbFiltroIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblPeriodoTema;
        private PillButton btnModificarEnciclopedias;
        private PillButton btnEliminarEnciclopedias;
    }
}