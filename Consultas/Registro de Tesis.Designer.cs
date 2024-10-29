namespace WindowsFormsApp1.Consultas
{
    partial class Registro_de_Tesis
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
            this.btnEliminarTesis = new WindowsFormsApp1.PillButton();
            this.btnModificarTesis = new WindowsFormsApp1.PillButton();
            this.txtFiltroAño = new System.Windows.Forms.TextBox();
            this.lblFiltroAño = new System.Windows.Forms.Label();
            this.txtFiltroTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulodelaTesis = new System.Windows.Forms.Label();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodoTema = new System.Windows.Forms.Label();
            this.dgvTesis = new System.Windows.Forms.DataGridView();
            this.btnNuevaTesis = new WindowsFormsApp1.PillButton();
            this.btnBuscarTesis = new WindowsFormsApp1.PillButton();
            this.txtFiltroNombreApellidodelAutor = new System.Windows.Forms.TextBox();
            this.lblFiltroNombreApellidodelAutor = new System.Windows.Forms.Label();
            this.lblTesisRegistradas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnEliminarTesis);
            this.panel1.Controls.Add(this.btnModificarTesis);
            this.panel1.Controls.Add(this.txtFiltroAño);
            this.panel1.Controls.Add(this.lblFiltroAño);
            this.panel1.Controls.Add(this.txtFiltroTitulo);
            this.panel1.Controls.Add(this.lblTitulodelaTesis);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblPeriodoTema);
            this.panel1.Controls.Add(this.dgvTesis);
            this.panel1.Controls.Add(this.btnNuevaTesis);
            this.panel1.Controls.Add(this.btnBuscarTesis);
            this.panel1.Controls.Add(this.txtFiltroNombreApellidodelAutor);
            this.panel1.Controls.Add(this.lblFiltroNombreApellidodelAutor);
            this.panel1.Location = new System.Drawing.Point(36, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 641);
            this.panel1.TabIndex = 10;
            // 
            // btnEliminarTesis
            // 
            this.btnEliminarTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarTesis.FlatAppearance.BorderSize = 0;
            this.btnEliminarTesis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarTesis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTesis.Location = new System.Drawing.Point(644, 232);
            this.btnEliminarTesis.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarTesis.Name = "btnEliminarTesis";
            this.btnEliminarTesis.Size = new System.Drawing.Size(76, 31);
            this.btnEliminarTesis.TabIndex = 17;
            this.btnEliminarTesis.Text = "Eliminar";
            this.btnEliminarTesis.UseVisualStyleBackColor = false;
            this.btnEliminarTesis.Click += new System.EventHandler(this.btnEliminarTesis_Click);
            // 
            // btnModificarTesis
            // 
            this.btnModificarTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarTesis.FlatAppearance.BorderSize = 0;
            this.btnModificarTesis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarTesis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarTesis.Location = new System.Drawing.Point(557, 232);
            this.btnModificarTesis.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarTesis.Name = "btnModificarTesis";
            this.btnModificarTesis.Size = new System.Drawing.Size(82, 31);
            this.btnModificarTesis.TabIndex = 16;
            this.btnModificarTesis.Text = "Modificar";
            this.btnModificarTesis.UseVisualStyleBackColor = false;
            this.btnModificarTesis.Click += new System.EventHandler(this.btnModificarTesis_Click);
            // 
            // txtFiltroAño
            // 
            this.txtFiltroAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroAño.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroAño.Location = new System.Drawing.Point(451, 47);
            this.txtFiltroAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroAño.Multiline = true;
            this.txtFiltroAño.Name = "txtFiltroAño";
            this.txtFiltroAño.Size = new System.Drawing.Size(79, 34);
            this.txtFiltroAño.TabIndex = 15;
            // 
            // lblFiltroAño
            // 
            this.lblFiltroAño.AutoSize = true;
            this.lblFiltroAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroAño.Location = new System.Drawing.Point(454, 20);
            this.lblFiltroAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroAño.Name = "lblFiltroAño";
            this.lblFiltroAño.Size = new System.Drawing.Size(34, 18);
            this.lblFiltroAño.TabIndex = 14;
            this.lblFiltroAño.Text = "Año";
            this.lblFiltroAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFiltroTitulo
            // 
            this.txtFiltroTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroTitulo.Location = new System.Drawing.Point(40, 115);
            this.txtFiltroTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroTitulo.Multiline = true;
            this.txtFiltroTitulo.Name = "txtFiltroTitulo";
            this.txtFiltroTitulo.Size = new System.Drawing.Size(376, 34);
            this.txtFiltroTitulo.TabIndex = 13;
            // 
            // lblTitulodelaTesis
            // 
            this.lblTitulodelaTesis.AutoSize = true;
            this.lblTitulodelaTesis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulodelaTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitulodelaTesis.Location = new System.Drawing.Point(40, 88);
            this.lblTitulodelaTesis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulodelaTesis.Name = "lblTitulodelaTesis";
            this.lblTitulodelaTesis.Size = new System.Drawing.Size(119, 18);
            this.lblTitulodelaTesis.TabIndex = 12;
            this.lblTitulodelaTesis.Text = "Titulo de la Tesis";
            this.lblTitulodelaTesis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(40, 182);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroPeriodo.TabIndex = 10;
            // 
            // lblPeriodoTema
            // 
            this.lblPeriodoTema.AutoSize = true;
            this.lblPeriodoTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPeriodoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPeriodoTema.Location = new System.Drawing.Point(40, 155);
            this.lblPeriodoTema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodoTema.Name = "lblPeriodoTema";
            this.lblPeriodoTema.Size = new System.Drawing.Size(60, 18);
            this.lblPeriodoTema.TabIndex = 11;
            this.lblPeriodoTema.Text = "Periodo";
            this.lblPeriodoTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTesis
            // 
            this.dgvTesis.AllowUserToAddRows = false;
            this.dgvTesis.AllowUserToDeleteRows = false;
            this.dgvTesis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesis.Location = new System.Drawing.Point(34, 274);
            this.dgvTesis.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTesis.Name = "dgvTesis";
            this.dgvTesis.ReadOnly = true;
            this.dgvTesis.RowHeadersWidth = 51;
            this.dgvTesis.RowTemplate.Height = 24;
            this.dgvTesis.Size = new System.Drawing.Size(712, 347);
            this.dgvTesis.TabIndex = 7;
            // 
            // btnNuevaTesis
            // 
            this.btnNuevaTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevaTesis.FlatAppearance.BorderSize = 0;
            this.btnNuevaTesis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevaTesis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevaTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaTesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaTesis.Location = new System.Drawing.Point(124, 232);
            this.btnNuevaTesis.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevaTesis.Name = "btnNuevaTesis";
            this.btnNuevaTesis.Size = new System.Drawing.Size(134, 31);
            this.btnNuevaTesis.TabIndex = 6;
            this.btnNuevaTesis.Text = "+ Nueva Tesis";
            this.btnNuevaTesis.UseVisualStyleBackColor = false;
            this.btnNuevaTesis.Click += new System.EventHandler(this.btnNuevaTesis_Click);
            // 
            // btnBuscarTesis
            // 
            this.btnBuscarTesis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarTesis.FlatAppearance.BorderSize = 0;
            this.btnBuscarTesis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarTesis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarTesis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTesis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarTesis.Location = new System.Drawing.Point(44, 232);
            this.btnBuscarTesis.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarTesis.Name = "btnBuscarTesis";
            this.btnBuscarTesis.Size = new System.Drawing.Size(76, 31);
            this.btnBuscarTesis.TabIndex = 5;
            this.btnBuscarTesis.Text = "Buscar";
            this.btnBuscarTesis.UseVisualStyleBackColor = false;
            this.btnBuscarTesis.Click += new System.EventHandler(this.btnBuscarTesis_Click);
            // 
            // txtFiltroNombreApellidodelAutor
            // 
            this.txtFiltroNombreApellidodelAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNombreApellidodelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNombreApellidodelAutor.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroNombreApellidodelAutor.Location = new System.Drawing.Point(40, 47);
            this.txtFiltroNombreApellidodelAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroNombreApellidodelAutor.Multiline = true;
            this.txtFiltroNombreApellidodelAutor.Name = "txtFiltroNombreApellidodelAutor";
            this.txtFiltroNombreApellidodelAutor.Size = new System.Drawing.Size(376, 34);
            this.txtFiltroNombreApellidodelAutor.TabIndex = 4;
            // 
            // lblFiltroNombreApellidodelAutor
            // 
            this.lblFiltroNombreApellidodelAutor.AutoSize = true;
            this.lblFiltroNombreApellidodelAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreApellidodelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreApellidodelAutor.Location = new System.Drawing.Point(40, 20);
            this.lblFiltroNombreApellidodelAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroNombreApellidodelAutor.Name = "lblFiltroNombreApellidodelAutor";
            this.lblFiltroNombreApellidodelAutor.Size = new System.Drawing.Size(179, 18);
            this.lblFiltroNombreApellidodelAutor.TabIndex = 2;
            this.lblFiltroNombreApellidodelAutor.Text = "Nombre/Apellido del Autor";
            this.lblFiltroNombreApellidodelAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTesisRegistradas
            // 
            this.lblTesisRegistradas.AutoSize = true;
            this.lblTesisRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTesisRegistradas.Location = new System.Drawing.Point(75, 36);
            this.lblTesisRegistradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTesisRegistradas.Name = "lblTesisRegistradas";
            this.lblTesisRegistradas.Size = new System.Drawing.Size(185, 26);
            this.lblTesisRegistradas.TabIndex = 11;
            this.lblTesisRegistradas.Text = "Tesis Registradas";
            this.lblTesisRegistradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Tesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(903, 640);
            this.Controls.Add(this.lblTesisRegistradas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Tesis";
            this.Text = "Registro_de_Tesis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblPeriodoTema;
        private System.Windows.Forms.DataGridView dgvTesis;
        private PillButton btnNuevaTesis;
        private PillButton btnBuscarTesis;
        private System.Windows.Forms.TextBox txtFiltroNombreApellidodelAutor;
        private System.Windows.Forms.Label lblFiltroNombreApellidodelAutor;
        private System.Windows.Forms.Label lblTesisRegistradas;
        private System.Windows.Forms.TextBox txtFiltroAño;
        private System.Windows.Forms.Label lblFiltroAño;
        private System.Windows.Forms.TextBox txtFiltroTitulo;
        private System.Windows.Forms.Label lblTitulodelaTesis;
        private PillButton btnModificarTesis;
        private PillButton btnEliminarTesis;
    }
}