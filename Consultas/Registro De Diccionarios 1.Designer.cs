﻿namespace WindowsFormsApp1.Consultas
{
    partial class Registro_De_Diccionarios_1
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
            this.txtFiltroAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnEliminarDiccionarios = new WindowsFormsApp1.PillButton();
            this.btnModificarDiccionarios = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodoTema = new System.Windows.Forms.Label();
            this.cmbFiltroIdiomas = new System.Windows.Forms.ComboBox();
            this.lblFiltroIdioma = new System.Windows.Forms.Label();
            this.dgvDiccionarios = new System.Windows.Forms.DataGridView();
            this.btnNuevoDiccionario = new WindowsFormsApp1.PillButton();
            this.btnBuscarDiccionario = new WindowsFormsApp1.PillButton();
            this.lblDiccionariosRegistrados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtFiltroAño);
            this.panel1.Controls.Add(this.lblAño);
            this.panel1.Controls.Add(this.btnEliminarDiccionarios);
            this.panel1.Controls.Add(this.btnModificarDiccionarios);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblPeriodoTema);
            this.panel1.Controls.Add(this.cmbFiltroIdiomas);
            this.panel1.Controls.Add(this.lblFiltroIdioma);
            this.panel1.Controls.Add(this.dgvDiccionarios);
            this.panel1.Controls.Add(this.btnNuevoDiccionario);
            this.panel1.Controls.Add(this.btnBuscarDiccionario);
            this.panel1.Location = new System.Drawing.Point(29, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 657);
            this.panel1.TabIndex = 5;
            // 
            // txtFiltroAño
            // 
            this.txtFiltroAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroAño.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroAño.Location = new System.Drawing.Point(26, 105);
            this.txtFiltroAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroAño.Multiline = true;
            this.txtFiltroAño.Name = "txtFiltroAño";
            this.txtFiltroAño.Size = new System.Drawing.Size(70, 34);
            this.txtFiltroAño.TabIndex = 36;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAño.Location = new System.Drawing.Point(26, 81);
            this.lblAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(34, 18);
            this.lblAño.TabIndex = 35;
            this.lblAño.Text = "Año";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminarDiccionarios
            // 
            this.btnEliminarDiccionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarDiccionarios.FlatAppearance.BorderSize = 0;
            this.btnEliminarDiccionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarDiccionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarDiccionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarDiccionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDiccionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarDiccionarios.Location = new System.Drawing.Point(1052, 159);
            this.btnEliminarDiccionarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarDiccionarios.Name = "btnEliminarDiccionarios";
            this.btnEliminarDiccionarios.Size = new System.Drawing.Size(76, 31);
            this.btnEliminarDiccionarios.TabIndex = 25;
            this.btnEliminarDiccionarios.Text = "Eliminar";
            this.btnEliminarDiccionarios.UseVisualStyleBackColor = false;
            this.btnEliminarDiccionarios.Click += new System.EventHandler(this.btnEliminarDiccionarios_Click);
            // 
            // btnModificarDiccionarios
            // 
            this.btnModificarDiccionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarDiccionarios.FlatAppearance.BorderSize = 0;
            this.btnModificarDiccionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarDiccionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarDiccionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDiccionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDiccionarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarDiccionarios.Location = new System.Drawing.Point(966, 159);
            this.btnModificarDiccionarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarDiccionarios.Name = "btnModificarDiccionarios";
            this.btnModificarDiccionarios.Size = new System.Drawing.Size(82, 31);
            this.btnModificarDiccionarios.TabIndex = 24;
            this.btnModificarDiccionarios.Text = "Modificar";
            this.btnModificarDiccionarios.UseVisualStyleBackColor = false;
            this.btnModificarDiccionarios.Click += new System.EventHandler(this.btnModificarDiccionarios_Click);
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(26, 166);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroPeriodo.TabIndex = 22;
            // 
            // lblPeriodoTema
            // 
            this.lblPeriodoTema.AutoSize = true;
            this.lblPeriodoTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPeriodoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPeriodoTema.Location = new System.Drawing.Point(26, 142);
            this.lblPeriodoTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodoTema.Name = "lblPeriodoTema";
            this.lblPeriodoTema.Size = new System.Drawing.Size(60, 18);
            this.lblPeriodoTema.TabIndex = 23;
            this.lblPeriodoTema.Text = "Periodo";
            this.lblPeriodoTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroIdiomas
            // 
            this.cmbFiltroIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroIdiomas.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroIdiomas.FormattingEnabled = true;
            this.cmbFiltroIdiomas.ItemHeight = 20;
            this.cmbFiltroIdiomas.Items.AddRange(new object[] {
            "Alemán",
            "Chino",
            "Español",
            "Francés",
            "Inglés",
            "Italiano"});
            this.cmbFiltroIdiomas.Location = new System.Drawing.Point(26, 50);
            this.cmbFiltroIdiomas.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroIdiomas.Name = "cmbFiltroIdiomas";
            this.cmbFiltroIdiomas.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroIdiomas.TabIndex = 21;
            // 
            // lblFiltroIdioma
            // 
            this.lblFiltroIdioma.AutoSize = true;
            this.lblFiltroIdioma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroIdioma.Location = new System.Drawing.Point(26, 27);
            this.lblFiltroIdioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroIdioma.Name = "lblFiltroIdioma";
            this.lblFiltroIdioma.Size = new System.Drawing.Size(52, 18);
            this.lblFiltroIdioma.TabIndex = 20;
            this.lblFiltroIdioma.Text = "Idioma";
            this.lblFiltroIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvDiccionarios
            // 
            this.dgvDiccionarios.AllowUserToAddRows = false;
            this.dgvDiccionarios.AllowUserToDeleteRows = false;
            this.dgvDiccionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiccionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiccionarios.Location = new System.Drawing.Point(26, 267);
            this.dgvDiccionarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDiccionarios.Name = "dgvDiccionarios";
            this.dgvDiccionarios.ReadOnly = true;
            this.dgvDiccionarios.RowHeadersWidth = 51;
            this.dgvDiccionarios.RowTemplate.Height = 24;
            this.dgvDiccionarios.Size = new System.Drawing.Size(1109, 432);
            this.dgvDiccionarios.TabIndex = 7;
            // 
            // btnNuevoDiccionario
            // 
            this.btnNuevoDiccionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoDiccionario.FlatAppearance.BorderSize = 0;
            this.btnNuevoDiccionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoDiccionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoDiccionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoDiccionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoDiccionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoDiccionario.Location = new System.Drawing.Point(113, 223);
            this.btnNuevoDiccionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoDiccionario.Name = "btnNuevoDiccionario";
            this.btnNuevoDiccionario.Size = new System.Drawing.Size(166, 31);
            this.btnNuevoDiccionario.TabIndex = 6;
            this.btnNuevoDiccionario.Text = "+ Nuevo Diccionario";
            this.btnNuevoDiccionario.UseVisualStyleBackColor = false;
            this.btnNuevoDiccionario.Click += new System.EventHandler(this.btnNuevoDiccionario_Click);
            // 
            // btnBuscarDiccionario
            // 
            this.btnBuscarDiccionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarDiccionario.FlatAppearance.BorderSize = 0;
            this.btnBuscarDiccionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarDiccionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarDiccionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDiccionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDiccionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarDiccionario.Location = new System.Drawing.Point(33, 223);
            this.btnBuscarDiccionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarDiccionario.Name = "btnBuscarDiccionario";
            this.btnBuscarDiccionario.Size = new System.Drawing.Size(76, 31);
            this.btnBuscarDiccionario.TabIndex = 5;
            this.btnBuscarDiccionario.Text = "Buscar";
            this.btnBuscarDiccionario.UseVisualStyleBackColor = false;
            this.btnBuscarDiccionario.Click += new System.EventHandler(this.btnBuscarDiccionario_Click);
            // 
            // lblDiccionariosRegistrados
            // 
            this.lblDiccionariosRegistrados.AutoSize = true;
            this.lblDiccionariosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDiccionariosRegistrados.Location = new System.Drawing.Point(70, 32);
            this.lblDiccionariosRegistrados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiccionariosRegistrados.Name = "lblDiccionariosRegistrados";
            this.lblDiccionariosRegistrados.Size = new System.Drawing.Size(253, 26);
            this.lblDiccionariosRegistrados.TabIndex = 4;
            this.lblDiccionariosRegistrados.Text = "Diccionarios Registrados";
            this.lblDiccionariosRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_De_Diccionarios_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1229, 748);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDiccionariosRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_De_Diccionarios_1";
            this.Text = "Registro_De_Diccionarios_1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblPeriodoTema;
        private System.Windows.Forms.ComboBox cmbFiltroIdiomas;
        private System.Windows.Forms.Label lblFiltroIdioma;
        private System.Windows.Forms.DataGridView dgvDiccionarios;
        private PillButton btnNuevoDiccionario;
        private PillButton btnBuscarDiccionario;
        private System.Windows.Forms.Label lblDiccionariosRegistrados;
        private PillButton btnModificarDiccionarios;
        private PillButton btnEliminarDiccionarios;
        private System.Windows.Forms.TextBox txtFiltroAño;
        private System.Windows.Forms.Label lblAño;
    }
}