namespace WindowsFormsApp1.Consultas
{
    partial class Registro_de_Proyecto_de_Catedra
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
            this.cmbFiltroAño = new System.Windows.Forms.ComboBox();
            this.lblFiltroAño = new System.Windows.Forms.Label();
            this.cmbFiltroCarrera = new System.Windows.Forms.ComboBox();
            this.lblFiltroCarrera = new System.Windows.Forms.Label();
            this.dgvProyecto = new System.Windows.Forms.DataGridView();
            this.btnNuevoProyecto = new WindowsFormsApp1.PillButton();
            this.btnBuscarProyecto = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblProyectosDeCatedraRegistrados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cmbFiltroAño);
            this.panel1.Controls.Add(this.lblFiltroAño);
            this.panel1.Controls.Add(this.cmbFiltroCarrera);
            this.panel1.Controls.Add(this.lblFiltroCarrera);
            this.panel1.Controls.Add(this.dgvProyecto);
            this.panel1.Controls.Add(this.btnNuevoProyecto);
            this.panel1.Controls.Add(this.btnBuscarProyecto);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 715);
            this.panel1.TabIndex = 9;
            // 
            // cmbFiltroAño
            // 
            this.cmbFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroAño.FormattingEnabled = true;
            this.cmbFiltroAño.Location = new System.Drawing.Point(35, 126);
            this.cmbFiltroAño.Name = "cmbFiltroAño";
            this.cmbFiltroAño.Size = new System.Drawing.Size(338, 33);
            this.cmbFiltroAño.TabIndex = 10;
            // 
            // lblFiltroAño
            // 
            this.lblFiltroAño.AutoSize = true;
            this.lblFiltroAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroAño.Location = new System.Drawing.Point(35, 99);
            this.lblFiltroAño.Name = "lblFiltroAño";
            this.lblFiltroAño.Size = new System.Drawing.Size(45, 24);
            this.lblFiltroAño.TabIndex = 11;
            this.lblFiltroAño.Text = "Año";
            this.lblFiltroAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroCarrera
            // 
            this.cmbFiltroCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroCarrera.FormattingEnabled = true;
            this.cmbFiltroCarrera.Location = new System.Drawing.Point(35, 59);
            this.cmbFiltroCarrera.Name = "cmbFiltroCarrera";
            this.cmbFiltroCarrera.Size = new System.Drawing.Size(338, 33);
            this.cmbFiltroCarrera.TabIndex = 8;
            // 
            // lblFiltroCarrera
            // 
            this.lblFiltroCarrera.AutoSize = true;
            this.lblFiltroCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroCarrera.Location = new System.Drawing.Point(35, 32);
            this.lblFiltroCarrera.Name = "lblFiltroCarrera";
            this.lblFiltroCarrera.Size = new System.Drawing.Size(72, 24);
            this.lblFiltroCarrera.TabIndex = 9;
            this.lblFiltroCarrera.Text = "Carrera";
            this.lblFiltroCarrera.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Location = new System.Drawing.Point(35, 314);
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.RowHeadersWidth = 51;
            this.dgvProyecto.RowTemplate.Height = 24;
            this.dgvProyecto.Size = new System.Drawing.Size(968, 363);
            this.dgvProyecto.TabIndex = 7;
            // 
            // btnNuevoProyecto
            // 
            this.btnNuevoProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoProyecto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoProyecto.Location = new System.Drawing.Point(168, 248);
            this.btnNuevoProyecto.Name = "btnNuevoProyecto";
            this.btnNuevoProyecto.Size = new System.Drawing.Size(205, 38);
            this.btnNuevoProyecto.TabIndex = 6;
            this.btnNuevoProyecto.Text = "+ Nuevo Proyecto";
            this.btnNuevoProyecto.UseVisualStyleBackColor = false;
            this.btnNuevoProyecto.Click += new System.EventHandler(this.btnNuevoProyecto_Click);
            // 
            // btnBuscarProyecto
            // 
            this.btnBuscarProyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarProyecto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProyecto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarProyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarProyecto.Location = new System.Drawing.Point(45, 248);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarProyecto.TabIndex = 5;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
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
            // lblProyectosDeCatedraRegistrados
            // 
            this.lblProyectosDeCatedraRegistrados.AutoSize = true;
            this.lblProyectosDeCatedraRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProyectosDeCatedraRegistrados.Location = new System.Drawing.Point(94, 39);
            this.lblProyectosDeCatedraRegistrados.Name = "lblProyectosDeCatedraRegistrados";
            this.lblProyectosDeCatedraRegistrados.Size = new System.Drawing.Size(430, 31);
            this.lblProyectosDeCatedraRegistrados.TabIndex = 8;
            this.lblProyectosDeCatedraRegistrados.Text = "Proyectos de Catedra Registrados";
            this.lblProyectosDeCatedraRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Proyecto_de_Catedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProyectosDeCatedraRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Proyecto_de_Catedra";
            this.Text = "Registro_de_Proyecto_de_Catedra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProyecto;
        private PillButton btnNuevoProyecto;
        private PillButton btnBuscarProyecto;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblProyectosDeCatedraRegistrados;
        private System.Windows.Forms.ComboBox cmbFiltroCarrera;
        private System.Windows.Forms.Label lblFiltroCarrera;
        private System.Windows.Forms.ComboBox cmbFiltroAño;
        private System.Windows.Forms.Label lblFiltroAño;
    }
}