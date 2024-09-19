namespace WindowsFormsApp1.Consultas
{
    partial class registro_de_temas
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
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.btnNuevoTema = new WindowsFormsApp1.PillButton();
            this.btnBuscarTema = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.txtFiltroNombreNroTema = new System.Windows.Forms.TextBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblFiltroNombreNroTema = new System.Windows.Forms.Label();
            this.lblTemasRegistrados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgvTemas);
            this.panel1.Controls.Add(this.btnNuevoTema);
            this.panel1.Controls.Add(this.btnBuscarTema);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.txtFiltroNombreNroTema);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroNombreNroTema);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 715);
            this.panel1.TabIndex = 7;
            // 
            // dgvTemas
            // 
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Location = new System.Drawing.Point(35, 262);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.RowHeadersWidth = 51;
            this.dgvTemas.RowTemplate.Height = 24;
            this.dgvTemas.Size = new System.Drawing.Size(968, 415);
            this.dgvTemas.TabIndex = 7;
            // 
            // btnNuevoTema
            // 
            this.btnNuevoTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoTema.FlatAppearance.BorderSize = 0;
            this.btnNuevoTema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoTema.Location = new System.Drawing.Point(167, 196);
            this.btnNuevoTema.Name = "btnNuevoTema";
            this.btnNuevoTema.Size = new System.Drawing.Size(165, 38);
            this.btnNuevoTema.TabIndex = 6;
            this.btnNuevoTema.Text = "+ Nueva Editorial";
            this.btnNuevoTema.UseVisualStyleBackColor = false;
            // 
            // btnBuscarTema
            // 
            this.btnBuscarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarTema.FlatAppearance.BorderSize = 0;
            this.btnBuscarTema.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarTema.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarTema.Location = new System.Drawing.Point(44, 196);
            this.btnBuscarTema.Name = "btnBuscarTema";
            this.btnBuscarTema.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarTema.TabIndex = 5;
            this.btnBuscarTema.Text = "Buscar";
            this.btnBuscarTema.UseVisualStyleBackColor = false;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(35, 139);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(338, 33);
            this.cmbFiltroPeriodo.TabIndex = 2;
            // 
            // txtFiltroNombreNroTema
            // 
            this.txtFiltroNombreNroTema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNombreNroTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNombreNroTema.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroNombreNroTema.Location = new System.Drawing.Point(35, 51);
            this.txtFiltroNombreNroTema.Multiline = true;
            this.txtFiltroNombreNroTema.Name = "txtFiltroNombreNroTema";
            this.txtFiltroNombreNroTema.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroNombreNroTema.TabIndex = 4;
            this.txtFiltroNombreNroTema.Text = "Ingrese el nombre de la editorial";
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(40, 112);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(76, 24);
            this.lblFiltroPeriodo.TabIndex = 3;
            this.lblFiltroPeriodo.Text = "Período";
            this.lblFiltroPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFiltroNombreNroTema
            // 
            this.lblFiltroNombreNroTema.AutoSize = true;
            this.lblFiltroNombreNroTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreNroTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreNroTema.Location = new System.Drawing.Point(40, 24);
            this.lblFiltroNombreNroTema.Name = "lblFiltroNombreNroTema";
            this.lblFiltroNombreNroTema.Size = new System.Drawing.Size(179, 24);
            this.lblFiltroNombreNroTema.TabIndex = 2;
            this.lblFiltroNombreNroTema.Text = "Nombre / Nro Tema";
            this.lblFiltroNombreNroTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTemasRegistrados
            // 
            this.lblTemasRegistrados.AutoSize = true;
            this.lblTemasRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTemasRegistrados.Location = new System.Drawing.Point(94, 39);
            this.lblTemasRegistrados.Name = "lblTemasRegistrados";
            this.lblTemasRegistrados.Size = new System.Drawing.Size(250, 31);
            this.lblTemasRegistrados.TabIndex = 6;
            this.lblTemasRegistrados.Text = "Temas Registrados";
            this.lblTemasRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registro_de_temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTemasRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registro_de_temas";
            this.Text = "registro_de_temas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTemas;
        private PillButton btnNuevoTema;
        private PillButton btnBuscarTema;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.TextBox txtFiltroNombreNroTema;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroNombreNroTema;
        private System.Windows.Forms.Label lblTemasRegistrados;
    }
}