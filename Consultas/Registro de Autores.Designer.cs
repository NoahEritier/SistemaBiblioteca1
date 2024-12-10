namespace WindowsFormsApp1
{
    partial class Registro_de_Autores
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
            this.btnEliminarAutores = new WindowsFormsApp1.PillButton();
            this.btnModificarAutores = new WindowsFormsApp1.PillButton();
            this.txtFiltroNacionalidad = new System.Windows.Forms.TextBox();
            this.lblFiltroNacionalidad = new System.Windows.Forms.Label();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.btnNuevoAutor = new WindowsFormsApp1.PillButton();
            this.btnBuscarAutor = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.txtFiltroAutor = new System.Windows.Forms.TextBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblFiltroNombreApellido = new System.Windows.Forms.Label();
            this.lblAutoresRegistrados = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.btnEliminarAutores);
            this.panel.Controls.Add(this.btnModificarAutores);
            this.panel.Controls.Add(this.txtFiltroNacionalidad);
            this.panel.Controls.Add(this.lblFiltroNacionalidad);
            this.panel.Controls.Add(this.dgvAutores);
            this.panel.Controls.Add(this.btnNuevoAutor);
            this.panel.Controls.Add(this.btnBuscarAutor);
            this.panel.Controls.Add(this.cmbFiltroPeriodo);
            this.panel.Controls.Add(this.txtFiltroAutor);
            this.panel.Controls.Add(this.lblFiltroPeriodo);
            this.panel.Controls.Add(this.lblFiltroNombreApellido);
            this.panel.Location = new System.Drawing.Point(48, 113);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1541, 809);
            this.panel.TabIndex = 3;
            // 
            // btnEliminarAutores
            // 
            this.btnEliminarAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarAutores.FlatAppearance.BorderSize = 0;
            this.btnEliminarAutores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAutores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAutores.Location = new System.Drawing.Point(1403, 196);
            this.btnEliminarAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAutores.Name = "btnEliminarAutores";
            this.btnEliminarAutores.Size = new System.Drawing.Size(101, 38);
            this.btnEliminarAutores.TabIndex = 11;
            this.btnEliminarAutores.Text = "Eliminar";
            this.btnEliminarAutores.UseVisualStyleBackColor = false;
            this.btnEliminarAutores.Click += new System.EventHandler(this.btnEliminarAutores_Click);
            // 
            // btnModificarAutores
            // 
            this.btnModificarAutores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarAutores.FlatAppearance.BorderSize = 0;
            this.btnModificarAutores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarAutores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarAutores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarAutores.Location = new System.Drawing.Point(1288, 196);
            this.btnModificarAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarAutores.Name = "btnModificarAutores";
            this.btnModificarAutores.Size = new System.Drawing.Size(109, 38);
            this.btnModificarAutores.TabIndex = 10;
            this.btnModificarAutores.Text = "Modificar";
            this.btnModificarAutores.UseVisualStyleBackColor = false;
            this.btnModificarAutores.Click += new System.EventHandler(this.btnModificarAutores_Click);
            // 
            // txtFiltroNacionalidad
            // 
            this.txtFiltroNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNacionalidad.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroNacionalidad.Location = new System.Drawing.Point(557, 50);
            this.txtFiltroNacionalidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroNacionalidad.Multiline = true;
            this.txtFiltroNacionalidad.Name = "txtFiltroNacionalidad";
            this.txtFiltroNacionalidad.Size = new System.Drawing.Size(446, 41);
            this.txtFiltroNacionalidad.TabIndex = 9;
            // 
            // lblFiltroNacionalidad
            // 
            this.lblFiltroNacionalidad.AutoSize = true;
            this.lblFiltroNacionalidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNacionalidad.Location = new System.Drawing.Point(563, 25);
            this.lblFiltroNacionalidad.Name = "lblFiltroNacionalidad";
            this.lblFiltroNacionalidad.Size = new System.Drawing.Size(120, 24);
            this.lblFiltroNacionalidad.TabIndex = 8;
            this.lblFiltroNacionalidad.Text = "Nacionalidad";
            this.lblFiltroNacionalidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.AllowUserToOrderColumns = true;
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Location = new System.Drawing.Point(35, 249);
            this.dgvAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersWidth = 51;
            this.dgvAutores.RowTemplate.Height = 24;
            this.dgvAutores.Size = new System.Drawing.Size(1479, 532);
            this.dgvAutores.TabIndex = 7;
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
            this.btnNuevoAutor.Location = new System.Drawing.Point(151, 196);
            this.btnNuevoAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoAutor.Name = "btnNuevoAutor";
            this.btnNuevoAutor.Size = new System.Drawing.Size(165, 38);
            this.btnNuevoAutor.TabIndex = 6;
            this.btnNuevoAutor.Text = "+ Nuevo Autor";
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
            this.btnBuscarAutor.Location = new System.Drawing.Point(44, 196);
            this.btnBuscarAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarAutor.TabIndex = 5;
            this.btnBuscarAutor.Text = "Buscar";
            this.btnBuscarAutor.UseVisualStyleBackColor = false;
            this.btnBuscarAutor.Click += new System.EventHandler(this.btnBuscarAutor_Click);
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(35, 139);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(337, 33);
            this.cmbFiltroPeriodo.TabIndex = 2;
            // 
            // txtFiltroAutor
            // 
            this.txtFiltroAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroAutor.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroAutor.Location = new System.Drawing.Point(35, 50);
            this.txtFiltroAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroAutor.Multiline = true;
            this.txtFiltroAutor.Name = "txtFiltroAutor";
            this.txtFiltroAutor.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroAutor.TabIndex = 4;
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
            // lblFiltroNombreApellido
            // 
            this.lblFiltroNombreApellido.AutoSize = true;
            this.lblFiltroNombreApellido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreApellido.Location = new System.Drawing.Point(40, 25);
            this.lblFiltroNombreApellido.Name = "lblFiltroNombreApellido";
            this.lblFiltroNombreApellido.Size = new System.Drawing.Size(163, 24);
            this.lblFiltroNombreApellido.TabIndex = 2;
            this.lblFiltroNombreApellido.Text = "Nombre / Apellido";
            this.lblFiltroNombreApellido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAutoresRegistrados
            // 
            this.lblAutoresRegistrados.AutoSize = true;
            this.lblAutoresRegistrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAutoresRegistrados.Location = new System.Drawing.Point(103, 63);
            this.lblAutoresRegistrados.Name = "lblAutoresRegistrados";
            this.lblAutoresRegistrados.Size = new System.Drawing.Size(261, 31);
            this.lblAutoresRegistrados.TabIndex = 2;
            this.lblAutoresRegistrados.Text = "Autores Registrados";
            this.lblAutoresRegistrados.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Autores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1639, 940);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblAutoresRegistrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registro_de_Autores";
            this.Text = "Registro_de_Autores";
            this.Load += new System.EventHandler(this.Registro_de_Autores_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvAutores;
        private PillButton btnNuevoAutor;
        private PillButton btnBuscarAutor;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.TextBox txtFiltroAutor;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroNombreApellido;
        private System.Windows.Forms.Label lblAutoresRegistrados;
        private System.Windows.Forms.TextBox txtFiltroNacionalidad;
        private System.Windows.Forms.Label lblFiltroNacionalidad;
        private PillButton btnModificarAutores;
        private PillButton btnEliminarAutores;
    }
}