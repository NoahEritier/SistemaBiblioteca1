namespace WindowsFormsApp1.Consultas
{
    partial class Registros_de_Mapas
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
            this.btnEliminarMapas = new WindowsFormsApp1.PillButton();
            this.btnModificarMapas = new WindowsFormsApp1.PillButton();
            this.txtFiltroTema = new System.Windows.Forms.TextBox();
            this.cmbFiltroIlustraciones = new System.Windows.Forms.ComboBox();
            this.lblFiltroIlustraciones = new System.Windows.Forms.Label();
            this.lblFiltroTema = new System.Windows.Forms.Label();
            this.dgvMapas = new System.Windows.Forms.DataGridView();
            this.btnNuevoMapa = new WindowsFormsApp1.PillButton();
            this.btnBuscarMapa = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblMapasRegistrados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnEliminarMapas);
            this.panel1.Controls.Add(this.btnModificarMapas);
            this.panel1.Controls.Add(this.txtFiltroTema);
            this.panel1.Controls.Add(this.cmbFiltroIlustraciones);
            this.panel1.Controls.Add(this.lblFiltroIlustraciones);
            this.panel1.Controls.Add(this.lblFiltroTema);
            this.panel1.Controls.Add(this.dgvMapas);
            this.panel1.Controls.Add(this.btnNuevoMapa);
            this.panel1.Controls.Add(this.btnBuscarMapa);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Location = new System.Drawing.Point(39, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 706);
            this.panel1.TabIndex = 13;
            // 
            // btnEliminarMapas
            // 
            this.btnEliminarMapas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarMapas.FlatAppearance.BorderSize = 0;
            this.btnEliminarMapas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarMapas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarMapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMapas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarMapas.Location = new System.Drawing.Point(893, 259);
            this.btnEliminarMapas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMapas.Name = "btnEliminarMapas";
            this.btnEliminarMapas.Size = new System.Drawing.Size(101, 38);
            this.btnEliminarMapas.TabIndex = 38;
            this.btnEliminarMapas.Text = "Eliminar";
            this.btnEliminarMapas.UseVisualStyleBackColor = false;
            // 
            // btnModificarMapas
            // 
            this.btnModificarMapas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarMapas.FlatAppearance.BorderSize = 0;
            this.btnModificarMapas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarMapas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarMapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMapas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMapas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarMapas.Location = new System.Drawing.Point(778, 259);
            this.btnModificarMapas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMapas.Name = "btnModificarMapas";
            this.btnModificarMapas.Size = new System.Drawing.Size(109, 38);
            this.btnModificarMapas.TabIndex = 37;
            this.btnModificarMapas.Text = "Modificar";
            this.btnModificarMapas.UseVisualStyleBackColor = false;
            // 
            // txtFiltroTema
            // 
            this.txtFiltroTema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroTema.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroTema.Location = new System.Drawing.Point(56, 68);
            this.txtFiltroTema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroTema.Multiline = true;
            this.txtFiltroTema.Name = "txtFiltroTema";
            this.txtFiltroTema.Size = new System.Drawing.Size(403, 41);
            this.txtFiltroTema.TabIndex = 36;
            // 
            // cmbFiltroIlustraciones
            // 
            this.cmbFiltroIlustraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroIlustraciones.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroIlustraciones.FormattingEnabled = true;
            this.cmbFiltroIlustraciones.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbFiltroIlustraciones.Location = new System.Drawing.Point(56, 139);
            this.cmbFiltroIlustraciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroIlustraciones.Name = "cmbFiltroIlustraciones";
            this.cmbFiltroIlustraciones.Size = new System.Drawing.Size(84, 33);
            this.cmbFiltroIlustraciones.TabIndex = 10;
            // 
            // lblFiltroIlustraciones
            // 
            this.lblFiltroIlustraciones.AutoSize = true;
            this.lblFiltroIlustraciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroIlustraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroIlustraciones.Location = new System.Drawing.Point(56, 112);
            this.lblFiltroIlustraciones.Name = "lblFiltroIlustraciones";
            this.lblFiltroIlustraciones.Size = new System.Drawing.Size(114, 24);
            this.lblFiltroIlustraciones.TabIndex = 11;
            this.lblFiltroIlustraciones.Text = "Ilustraciones";
            this.lblFiltroIlustraciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFiltroTema
            // 
            this.lblFiltroTema.AutoSize = true;
            this.lblFiltroTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroTema.Location = new System.Drawing.Point(56, 41);
            this.lblFiltroTema.Name = "lblFiltroTema";
            this.lblFiltroTema.Size = new System.Drawing.Size(59, 24);
            this.lblFiltroTema.TabIndex = 9;
            this.lblFiltroTema.Text = "Tema";
            this.lblFiltroTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvMapas
            // 
            this.dgvMapas.AllowUserToAddRows = false;
            this.dgvMapas.AllowUserToDeleteRows = false;
            this.dgvMapas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapas.Location = new System.Drawing.Point(35, 314);
            this.dgvMapas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMapas.Name = "dgvMapas";
            this.dgvMapas.ReadOnly = true;
            this.dgvMapas.RowHeadersWidth = 51;
            this.dgvMapas.RowTemplate.Height = 24;
            this.dgvMapas.Size = new System.Drawing.Size(968, 363);
            this.dgvMapas.TabIndex = 7;
            // 
            // btnNuevoMapa
            // 
            this.btnNuevoMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoMapa.FlatAppearance.BorderSize = 0;
            this.btnNuevoMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoMapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoMapa.Location = new System.Drawing.Point(155, 259);
            this.btnNuevoMapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoMapa.Name = "btnNuevoMapa";
            this.btnNuevoMapa.Size = new System.Drawing.Size(165, 38);
            this.btnNuevoMapa.TabIndex = 6;
            this.btnNuevoMapa.Text = "+ Nuevo Mapa";
            this.btnNuevoMapa.UseVisualStyleBackColor = false;
            this.btnNuevoMapa.Click += new System.EventHandler(this.btnNuevoMapa_Click);
            // 
            // btnBuscarMapa
            // 
            this.btnBuscarMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarMapa.FlatAppearance.BorderSize = 0;
            this.btnBuscarMapa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarMapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMapa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarMapa.Location = new System.Drawing.Point(48, 259);
            this.btnBuscarMapa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarMapa.Name = "btnBuscarMapa";
            this.btnBuscarMapa.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarMapa.TabIndex = 5;
            this.btnBuscarMapa.Text = "Buscar";
            this.btnBuscarMapa.UseVisualStyleBackColor = false;
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(56, 202);
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
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(56, 175);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(76, 24);
            this.lblFiltroPeriodo.TabIndex = 3;
            this.lblFiltroPeriodo.Text = "Período";
            this.lblFiltroPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMapasRegistrados
            // 
            this.lblMapasRegistrados.AutoSize = true;
            this.lblMapasRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblMapasRegistrados.Location = new System.Drawing.Point(93, 39);
            this.lblMapasRegistrados.Name = "lblMapasRegistrados";
            this.lblMapasRegistrados.Size = new System.Drawing.Size(248, 31);
            this.lblMapasRegistrados.TabIndex = 12;
            this.lblMapasRegistrados.Text = "Mapas Registrados\r\n";
            this.lblMapasRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registros_de_Mapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1207, 806);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMapasRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registros_de_Mapas";
            this.Text = "Registros_de_Mapas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFiltroTema;
        private System.Windows.Forms.ComboBox cmbFiltroIlustraciones;
        private System.Windows.Forms.Label lblFiltroIlustraciones;
        private System.Windows.Forms.Label lblFiltroTema;
        private System.Windows.Forms.DataGridView dgvMapas;
        private PillButton btnNuevoMapa;
        private PillButton btnBuscarMapa;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblMapasRegistrados;
        private PillButton btnModificarMapas;
        private PillButton btnEliminarMapas;
    }
}