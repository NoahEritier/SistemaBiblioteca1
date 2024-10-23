namespace WindowsFormsApp1.Consultas
{
    partial class Registros_de_Juegos
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
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.cmbFiltroCantidad = new System.Windows.Forms.ComboBox();
            this.lblFiltroCantidad = new System.Windows.Forms.Label();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.btnNuevoJuego = new WindowsFormsApp1.PillButton();
            this.btnBuscarJuego = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblJuegosRegistrados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtFiltroNombre);
            this.panel1.Controls.Add(this.cmbFiltroCantidad);
            this.panel1.Controls.Add(this.lblFiltroCantidad);
            this.panel1.Controls.Add(this.lblFiltroNombre);
            this.panel1.Controls.Add(this.dgvJuegos);
            this.panel1.Controls.Add(this.btnNuevoJuego);
            this.panel1.Controls.Add(this.btnBuscarJuego);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 715);
            this.panel1.TabIndex = 11;
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroNombre.Location = new System.Drawing.Point(35, 59);
            this.txtFiltroNombre.Multiline = true;
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(403, 41);
            this.txtFiltroNombre.TabIndex = 36;
            // 
            // cmbFiltroCantidad
            // 
            this.cmbFiltroCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroCantidad.FormattingEnabled = true;
            this.cmbFiltroCantidad.Location = new System.Drawing.Point(35, 126);
            this.cmbFiltroCantidad.Name = "cmbFiltroCantidad";
            this.cmbFiltroCantidad.Size = new System.Drawing.Size(84, 33);
            this.cmbFiltroCantidad.TabIndex = 10;
            // 
            // lblFiltroCantidad
            // 
            this.lblFiltroCantidad.AutoSize = true;
            this.lblFiltroCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroCantidad.Location = new System.Drawing.Point(35, 99);
            this.lblFiltroCantidad.Name = "lblFiltroCantidad";
            this.lblFiltroCantidad.Size = new System.Drawing.Size(84, 24);
            this.lblFiltroCantidad.TabIndex = 11;
            this.lblFiltroCantidad.Text = "Cantidad";
            this.lblFiltroCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombre.Location = new System.Drawing.Point(35, 32);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(79, 24);
            this.lblFiltroNombre.TabIndex = 9;
            this.lblFiltroNombre.Text = "Nombre";
            this.lblFiltroNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Location = new System.Drawing.Point(35, 314);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.RowHeadersWidth = 51;
            this.dgvJuegos.RowTemplate.Height = 24;
            this.dgvJuegos.Size = new System.Drawing.Size(968, 363);
            this.dgvJuegos.TabIndex = 7;
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoJuego.FlatAppearance.BorderSize = 0;
            this.btnNuevoJuego.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoJuego.Location = new System.Drawing.Point(168, 248);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(190, 38);
            this.btnNuevoJuego.TabIndex = 6;
            this.btnNuevoJuego.Text = "+ Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = false;
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
            // 
            // btnBuscarJuego
            // 
            this.btnBuscarJuego.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarJuego.FlatAppearance.BorderSize = 0;
            this.btnBuscarJuego.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarJuego.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarJuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarJuego.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarJuego.Location = new System.Drawing.Point(45, 248);
            this.btnBuscarJuego.Name = "btnBuscarJuego";
            this.btnBuscarJuego.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarJuego.TabIndex = 5;
            this.btnBuscarJuego.Text = "Buscar";
            this.btnBuscarJuego.UseVisualStyleBackColor = false;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(35, 195);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(338, 33);
            this.cmbFiltroPeriodo.TabIndex = 2;
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(35, 168);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(76, 24);
            this.lblFiltroPeriodo.TabIndex = 3;
            this.lblFiltroPeriodo.Text = "Período";
            this.lblFiltroPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblJuegosRegistrados
            // 
            this.lblJuegosRegistrados.AutoSize = true;
            this.lblJuegosRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblJuegosRegistrados.Location = new System.Drawing.Point(94, 39);
            this.lblJuegosRegistrados.Name = "lblJuegosRegistrados";
            this.lblJuegosRegistrados.Size = new System.Drawing.Size(255, 31);
            this.lblJuegosRegistrados.TabIndex = 10;
            this.lblJuegosRegistrados.Text = "Juegos Registrados";
            this.lblJuegosRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registros_de_Juegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblJuegosRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registros_de_Juegos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros_de_Juegos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbFiltroCantidad;
        private System.Windows.Forms.Label lblFiltroCantidad;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.DataGridView dgvJuegos;
        private PillButton btnNuevoJuego;
        private PillButton btnBuscarJuego;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblJuegosRegistrados;
        private System.Windows.Forms.TextBox txtFiltroNombre;
    }
}