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
            this.panel = new System.Windows.Forms.Panel();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtFiltroAño = new System.Windows.Forms.TextBox();
            this.lblFiltroAño = new System.Windows.Forms.Label();
            this.dgvTesis = new System.Windows.Forms.DataGridView();
            this.btnNuevoAutor = new WindowsFormsApp1.PillButton();
            this.btnBuscarAutor = new WindowsFormsApp1.PillButton();
            this.txtFiltroNombreApellidoAutor = new System.Windows.Forms.TextBox();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.lblFiltroNombreApellido = new System.Windows.Forms.Label();
            this.lblTesisRegistradas = new System.Windows.Forms.Label();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.cmbFiltroPeriodo);
            this.panel.Controls.Add(this.lblFiltroPeriodo);
            this.panel.Controls.Add(this.txtTitulo);
            this.panel.Controls.Add(this.txtFiltroAño);
            this.panel.Controls.Add(this.lblFiltroAño);
            this.panel.Controls.Add(this.dgvTesis);
            this.panel.Controls.Add(this.btnNuevoAutor);
            this.panel.Controls.Add(this.btnBuscarAutor);
            this.panel.Controls.Add(this.txtFiltroNombreApellidoAutor);
            this.panel.Controls.Add(this.lblFiltroTitulo);
            this.panel.Controls.Add(this.lblFiltroNombreApellido);
            this.panel.Location = new System.Drawing.Point(36, 92);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(847, 581);
            this.panel.TabIndex = 4;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTitulo.Location = new System.Drawing.Point(26, 111);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(376, 34);
            this.txtTitulo.TabIndex = 10;
            this.txtTitulo.Text = "Ingrese el Titulo de la Tesis";
            // 
            // txtFiltroAño
            // 
            this.txtFiltroAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroAño.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFiltroAño.Location = new System.Drawing.Point(418, 41);
            this.txtFiltroAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroAño.Multiline = true;
            this.txtFiltroAño.Name = "txtFiltroAño";
            this.txtFiltroAño.Size = new System.Drawing.Size(335, 34);
            this.txtFiltroAño.TabIndex = 9;
            this.txtFiltroAño.Text = "Ingrese el Año";
            // 
            // lblFiltroAño
            // 
            this.lblFiltroAño.AutoSize = true;
            this.lblFiltroAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroAño.Location = new System.Drawing.Point(422, 20);
            this.lblFiltroAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroAño.Name = "lblFiltroAño";
            this.lblFiltroAño.Size = new System.Drawing.Size(34, 18);
            this.lblFiltroAño.TabIndex = 8;
            this.lblFiltroAño.Text = "Año";
            this.lblFiltroAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvTesis
            // 
            this.dgvTesis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTesis.Location = new System.Drawing.Point(26, 213);
            this.dgvTesis.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTesis.Name = "dgvTesis";
            this.dgvTesis.RowHeadersWidth = 51;
            this.dgvTesis.RowTemplate.Height = 24;
            this.dgvTesis.Size = new System.Drawing.Size(726, 337);
            this.dgvTesis.TabIndex = 7;
            // 
            // btnNuevoAutor
            // 
            this.btnNuevoAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoAutor.FlatAppearance.BorderSize = 0;
            this.btnNuevoAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoAutor.Location = new System.Drawing.Point(125, 159);
            this.btnNuevoAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoAutor.Name = "btnNuevoAutor";
            this.btnNuevoAutor.Size = new System.Drawing.Size(124, 31);
            this.btnNuevoAutor.TabIndex = 6;
            this.btnNuevoAutor.Text = "+ Nueva Tesis";
            this.btnNuevoAutor.UseVisualStyleBackColor = false;
            this.btnNuevoAutor.Click += new System.EventHandler(this.btnNuevoAutor_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarAutor.FlatAppearance.BorderSize = 0;
            this.btnBuscarAutor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarAutor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarAutor.Location = new System.Drawing.Point(33, 159);
            this.btnBuscarAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(76, 31);
            this.btnBuscarAutor.TabIndex = 5;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            // 
            // txtFiltroNombreApellidoAutor
            // 
            this.txtFiltroNombreApellidoAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNombreApellidoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNombreApellidoAutor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFiltroNombreApellidoAutor.Location = new System.Drawing.Point(26, 41);
            this.txtFiltroNombreApellidoAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroNombreApellidoAutor.Multiline = true;
            this.txtFiltroNombreApellidoAutor.Name = "txtFiltroNombreApellidoAutor";
            this.txtFiltroNombreApellidoAutor.Size = new System.Drawing.Size(376, 34);
            this.txtFiltroNombreApellidoAutor.TabIndex = 4;
            this.txtFiltroNombreApellidoAutor.Text = "Ingrese el nombre o apellido del autor";
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroTitulo.Location = new System.Drawing.Point(30, 91);
            this.lblFiltroTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(44, 18);
            this.lblFiltroTitulo.TabIndex = 3;
            this.lblFiltroTitulo.Text = "Titulo";
            this.lblFiltroTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFiltroTitulo.Click += new System.EventHandler(this.lblFiltroPeriodo_Click);
            // 
            // lblFiltroNombreApellido
            // 
            this.lblFiltroNombreApellido.AutoSize = true;
            this.lblFiltroNombreApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreApellido.Location = new System.Drawing.Point(30, 20);
            this.lblFiltroNombreApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroNombreApellido.Name = "lblFiltroNombreApellido";
            this.lblFiltroNombreApellido.Size = new System.Drawing.Size(179, 18);
            this.lblFiltroNombreApellido.TabIndex = 2;
            this.lblFiltroNombreApellido.Text = "Nombre/Apellido del Autor";
            this.lblFiltroNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTesisRegistradas
            // 
            this.lblTesisRegistradas.AutoSize = true;
            this.lblTesisRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTesisRegistradas.Location = new System.Drawing.Point(77, 51);
            this.lblTesisRegistradas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTesisRegistradas.Name = "lblTesisRegistradas";
            this.lblTesisRegistradas.Size = new System.Drawing.Size(185, 26);
            this.lblTesisRegistradas.TabIndex = 5;
            this.lblTesisRegistradas.Text = "Tesis Registradas";
            this.lblTesisRegistradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(418, 117);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroPeriodo.TabIndex = 11;
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(422, 95);
            this.lblFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(60, 18);
            this.lblFiltroPeriodo.TabIndex = 12;
            this.lblFiltroPeriodo.Text = "Período";
            this.lblFiltroPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Tesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(919, 640);
            this.Controls.Add(this.lblTesisRegistradas);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Tesis";
            this.Text = "Registro_de_Tesis";
            this.Load += new System.EventHandler(this.Registro_de_Tesis_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTesis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txtFiltroAño;
        private System.Windows.Forms.Label lblFiltroAño;
        private System.Windows.Forms.DataGridView dgvTesis;
        private PillButton btnNuevoAutor;
        private PillButton btnBuscarAutor;
        private System.Windows.Forms.TextBox txtFiltroNombreApellidoAutor;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.Label lblFiltroNombreApellido;
        private System.Windows.Forms.Label lblTesisRegistradas;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroPeriodo;
    }
}