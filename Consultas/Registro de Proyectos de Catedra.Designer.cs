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
            this.txtAño = new System.Windows.Forms.TextBox();
            this.cmbMaterias = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnEliminarProyectos = new WindowsFormsApp1.PillButton();
            this.btnModificarProyectos = new WindowsFormsApp1.PillButton();
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
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.cmbMaterias);
            this.panel1.Controls.Add(this.lblMateria);
            this.panel1.Controls.Add(this.btnEliminarProyectos);
            this.panel1.Controls.Add(this.btnModificarProyectos);
            this.panel1.Controls.Add(this.lblFiltroAño);
            this.panel1.Controls.Add(this.cmbFiltroCarrera);
            this.panel1.Controls.Add(this.lblFiltroCarrera);
            this.panel1.Controls.Add(this.dgvProyecto);
            this.panel1.Controls.Add(this.btnNuevoProyecto);
            this.panel1.Controls.Add(this.btnBuscarProyecto);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1541, 876);
            this.panel1.TabIndex = 9;
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAño.ForeColor = System.Drawing.Color.Black;
            this.txtAño.Location = new System.Drawing.Point(41, 124);
            this.txtAño.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(110, 41);
            this.txtAño.TabIndex = 40;
            // 
            // cmbMaterias
            // 
            this.cmbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbMaterias.ForeColor = System.Drawing.Color.Black;
            this.cmbMaterias.FormattingEnabled = true;
            this.cmbMaterias.Location = new System.Drawing.Point(416, 60);
            this.cmbMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaterias.Name = "cmbMaterias";
            this.cmbMaterias.Size = new System.Drawing.Size(337, 33);
            this.cmbMaterias.TabIndex = 14;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblMateria.Location = new System.Drawing.Point(416, 33);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(80, 24);
            this.lblMateria.TabIndex = 15;
            this.lblMateria.Text = "Materias";
            this.lblMateria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminarProyectos
            // 
            this.btnEliminarProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarProyectos.FlatAppearance.BorderSize = 0;
            this.btnEliminarProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarProyectos.Location = new System.Drawing.Point(1405, 249);
            this.btnEliminarProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProyectos.Name = "btnEliminarProyectos";
            this.btnEliminarProyectos.Size = new System.Drawing.Size(101, 38);
            this.btnEliminarProyectos.TabIndex = 13;
            this.btnEliminarProyectos.Text = "Eliminar";
            this.btnEliminarProyectos.UseVisualStyleBackColor = false;
            this.btnEliminarProyectos.Click += new System.EventHandler(this.btnEliminarProyectos_Click);
            // 
            // btnModificarProyectos
            // 
            this.btnModificarProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarProyectos.FlatAppearance.BorderSize = 0;
            this.btnModificarProyectos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarProyectos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarProyectos.Location = new System.Drawing.Point(1290, 249);
            this.btnModificarProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProyectos.Name = "btnModificarProyectos";
            this.btnModificarProyectos.Size = new System.Drawing.Size(109, 38);
            this.btnModificarProyectos.TabIndex = 12;
            this.btnModificarProyectos.Text = "Modificar";
            this.btnModificarProyectos.UseVisualStyleBackColor = false;
            this.btnModificarProyectos.Click += new System.EventHandler(this.btnModificarProyectos_Click);
            // 
            // lblFiltroAño
            // 
            this.lblFiltroAño.AutoSize = true;
            this.lblFiltroAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroAño.Location = new System.Drawing.Point(41, 98);
            this.lblFiltroAño.Name = "lblFiltroAño";
            this.lblFiltroAño.Size = new System.Drawing.Size(45, 24);
            this.lblFiltroAño.TabIndex = 11;
            this.lblFiltroAño.Text = "Año";
            this.lblFiltroAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbFiltroCarrera
            // 
            this.cmbFiltroCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroCarrera.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroCarrera.FormattingEnabled = true;
            this.cmbFiltroCarrera.Location = new System.Drawing.Point(41, 60);
            this.cmbFiltroCarrera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroCarrera.Name = "cmbFiltroCarrera";
            this.cmbFiltroCarrera.Size = new System.Drawing.Size(337, 33);
            this.cmbFiltroCarrera.TabIndex = 8;
            // 
            // lblFiltroCarrera
            // 
            this.lblFiltroCarrera.AutoSize = true;
            this.lblFiltroCarrera.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroCarrera.Location = new System.Drawing.Point(41, 33);
            this.lblFiltroCarrera.Name = "lblFiltroCarrera";
            this.lblFiltroCarrera.Size = new System.Drawing.Size(72, 24);
            this.lblFiltroCarrera.TabIndex = 9;
            this.lblFiltroCarrera.Text = "Carrera";
            this.lblFiltroCarrera.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvProyecto
            // 
            this.dgvProyecto.AllowUserToAddRows = false;
            this.dgvProyecto.AllowUserToDeleteRows = false;
            this.dgvProyecto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyecto.Location = new System.Drawing.Point(35, 305);
            this.dgvProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProyecto.Name = "dgvProyecto";
            this.dgvProyecto.ReadOnly = true;
            this.dgvProyecto.RowHeadersWidth = 51;
            this.dgvProyecto.RowTemplate.Height = 24;
            this.dgvProyecto.Size = new System.Drawing.Size(1479, 532);
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
            this.btnNuevoProyecto.Location = new System.Drawing.Point(152, 249);
            this.btnNuevoProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnBuscarProyecto.Location = new System.Drawing.Point(45, 249);
            this.btnBuscarProyecto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarProyecto.Name = "btnBuscarProyecto";
            this.btnBuscarProyecto.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarProyecto.TabIndex = 5;
            this.btnBuscarProyecto.Text = "Buscar";
            this.btnBuscarProyecto.UseVisualStyleBackColor = false;
            this.btnBuscarProyecto.Click += new System.EventHandler(this.btnBuscarProyecto_Click);
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(41, 194);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(337, 33);
            this.cmbFiltroPeriodo.TabIndex = 2;
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(41, 167);
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
            this.lblProyectosDeCatedraRegistrados.Location = new System.Drawing.Point(93, 39);
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
            this.ClientSize = new System.Drawing.Size(1639, 1001);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProyectosDeCatedraRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblFiltroAño;
        private PillButton btnModificarProyectos;
        private PillButton btnEliminarProyectos;
        private System.Windows.Forms.ComboBox cmbMaterias;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtAño;
    }
}