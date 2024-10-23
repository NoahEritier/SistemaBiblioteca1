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
            this.txtFiltroAño = new System.Windows.Forms.TextBox();
            this.lblFiltroAño = new System.Windows.Forms.Label();
            this.txtFiltroTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulodelaTesis = new System.Windows.Forms.Label();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblPeriodoTema = new System.Windows.Forms.Label();
            this.dgvEnciclopedia = new System.Windows.Forms.DataGridView();
            this.btnNuevaTesis = new WindowsFormsApp1.PillButton();
            this.btnBuscarTesis = new WindowsFormsApp1.PillButton();
            this.txtFiltroNombreApellidodelAutor = new System.Windows.Forms.TextBox();
            this.lblFiltroNombreApellidodelAutor = new System.Windows.Forms.Label();
            this.lblTesisRegistradas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnciclopedia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtFiltroAño);
            this.panel1.Controls.Add(this.lblFiltroAño);
            this.panel1.Controls.Add(this.txtFiltroTitulo);
            this.panel1.Controls.Add(this.lblTitulodelaTesis);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblPeriodoTema);
            this.panel1.Controls.Add(this.dgvEnciclopedia);
            this.panel1.Controls.Add(this.btnNuevaTesis);
            this.panel1.Controls.Add(this.btnBuscarTesis);
            this.panel1.Controls.Add(this.txtFiltroNombreApellidodelAutor);
            this.panel1.Controls.Add(this.lblFiltroNombreApellidodelAutor);
            this.panel1.Location = new System.Drawing.Point(48, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 839);
            this.panel1.TabIndex = 10;
            // 
            // txtFiltroAño
            // 
            this.txtFiltroAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroAño.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroAño.Location = new System.Drawing.Point(29, 118);
            this.txtFiltroAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroAño.Multiline = true;
            this.txtFiltroAño.Name = "txtFiltroAño";
            this.txtFiltroAño.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroAño.TabIndex = 15;
            // 
            // lblFiltroAño
            // 
            this.lblFiltroAño.AutoSize = true;
            this.lblFiltroAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroAño.Location = new System.Drawing.Point(29, 89);
            this.lblFiltroAño.Name = "lblFiltroAño";
            this.lblFiltroAño.Size = new System.Drawing.Size(45, 24);
            this.lblFiltroAño.TabIndex = 14;
            this.lblFiltroAño.Text = "Año";
            this.lblFiltroAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFiltroTitulo
            // 
            this.txtFiltroTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroTitulo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroTitulo.Location = new System.Drawing.Point(29, 193);
            this.txtFiltroTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroTitulo.Multiline = true;
            this.txtFiltroTitulo.Name = "txtFiltroTitulo";
            this.txtFiltroTitulo.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroTitulo.TabIndex = 13;
            // 
            // lblTitulodelaTesis
            // 
            this.lblTitulodelaTesis.AutoSize = true;
            this.lblTitulodelaTesis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulodelaTesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitulodelaTesis.Location = new System.Drawing.Point(29, 164);
            this.lblTitulodelaTesis.Name = "lblTitulodelaTesis";
            this.lblTitulodelaTesis.Size = new System.Drawing.Size(152, 24);
            this.lblTitulodelaTesis.TabIndex = 12;
            this.lblTitulodelaTesis.Text = "Titulo de la Tesis";
            this.lblTitulodelaTesis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(29, 268);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(337, 33);
            this.cmbFiltroPeriodo.TabIndex = 10;
            // 
            // lblPeriodoTema
            // 
            this.lblPeriodoTema.AutoSize = true;
            this.lblPeriodoTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPeriodoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPeriodoTema.Location = new System.Drawing.Point(29, 239);
            this.lblPeriodoTema.Name = "lblPeriodoTema";
            this.lblPeriodoTema.Size = new System.Drawing.Size(76, 24);
            this.lblPeriodoTema.TabIndex = 11;
            this.lblPeriodoTema.Text = "Periodo";
            this.lblPeriodoTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvEnciclopedia
            // 
            this.dgvEnciclopedia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnciclopedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnciclopedia.Location = new System.Drawing.Point(29, 382);
            this.dgvEnciclopedia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEnciclopedia.Name = "dgvEnciclopedia";
            this.dgvEnciclopedia.RowHeadersWidth = 51;
            this.dgvEnciclopedia.RowTemplate.Height = 24;
            this.dgvEnciclopedia.Size = new System.Drawing.Size(949, 427);
            this.dgvEnciclopedia.TabIndex = 7;
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
            this.btnNuevaTesis.Location = new System.Drawing.Point(165, 321);
            this.btnNuevaTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevaTesis.Name = "btnNuevaTesis";
            this.btnNuevaTesis.Size = new System.Drawing.Size(243, 38);
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
            this.btnBuscarTesis.Location = new System.Drawing.Point(43, 321);
            this.btnBuscarTesis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarTesis.Name = "btnBuscarTesis";
            this.btnBuscarTesis.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarTesis.TabIndex = 5;
            this.btnBuscarTesis.Text = "Buscar";
            this.btnBuscarTesis.UseVisualStyleBackColor = false;
            // 
            // txtFiltroNombreApellidodelAutor
            // 
            this.txtFiltroNombreApellidodelAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNombreApellidodelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNombreApellidodelAutor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroNombreApellidodelAutor.Location = new System.Drawing.Point(29, 43);
            this.txtFiltroNombreApellidodelAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroNombreApellidodelAutor.Multiline = true;
            this.txtFiltroNombreApellidodelAutor.Name = "txtFiltroNombreApellidodelAutor";
            this.txtFiltroNombreApellidodelAutor.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroNombreApellidodelAutor.TabIndex = 4;
            // 
            // lblFiltroNombreApellidodelAutor
            // 
            this.lblFiltroNombreApellidodelAutor.AutoSize = true;
            this.lblFiltroNombreApellidodelAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreApellidodelAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreApellidodelAutor.Location = new System.Drawing.Point(29, 14);
            this.lblFiltroNombreApellidodelAutor.Name = "lblFiltroNombreApellidodelAutor";
            this.lblFiltroNombreApellidodelAutor.Size = new System.Drawing.Size(234, 24);
            this.lblFiltroNombreApellidodelAutor.TabIndex = 2;
            this.lblFiltroNombreApellidodelAutor.Text = "Nombre/Apellido del Autor";
            this.lblFiltroNombreApellidodelAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTesisRegistradas
            // 
            this.lblTesisRegistradas.AutoSize = true;
            this.lblTesisRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTesisRegistradas.Location = new System.Drawing.Point(100, 44);
            this.lblTesisRegistradas.Name = "lblTesisRegistradas";
            this.lblTesisRegistradas.Size = new System.Drawing.Size(233, 31);
            this.lblTesisRegistradas.TabIndex = 11;
            this.lblTesisRegistradas.Text = "Tesis Registradas";
            this.lblTesisRegistradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Tesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1204, 975);
            this.Controls.Add(this.lblTesisRegistradas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Registro_de_Tesis";
            this.Text = "Registro_de_Tesis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnciclopedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblPeriodoTema;
        private System.Windows.Forms.DataGridView dgvEnciclopedia;
        private PillButton btnNuevaTesis;
        private PillButton btnBuscarTesis;
        private System.Windows.Forms.TextBox txtFiltroNombreApellidodelAutor;
        private System.Windows.Forms.Label lblFiltroNombreApellidodelAutor;
        private System.Windows.Forms.Label lblTesisRegistradas;
        private System.Windows.Forms.TextBox txtFiltroAño;
        private System.Windows.Forms.Label lblFiltroAño;
        private System.Windows.Forms.TextBox txtFiltroTitulo;
        private System.Windows.Forms.Label lblTitulodelaTesis;
    }
}