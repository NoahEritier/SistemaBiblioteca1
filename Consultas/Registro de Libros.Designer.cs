namespace WindowsFormsApp1
{
    partial class Registro_de_Libros
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminarLibros = new WindowsFormsApp1.PillButton();
            this.btnModificarLibros = new WindowsFormsApp1.PillButton();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnNuevoLibro = new WindowsFormsApp1.PillButton();
            this.btnBuscarLibro = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.txtFiltroLibro = new System.Windows.Forms.TextBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblFiltroAutorTitulo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Libros Registrados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnEliminarLibros);
            this.panel1.Controls.Add(this.btnModificarLibros);
            this.panel1.Controls.Add(this.dgvLibros);
            this.panel1.Controls.Add(this.btnNuevoLibro);
            this.panel1.Controls.Add(this.btnBuscarLibro);
            this.panel1.Controls.Add(this.cmbFiltroPeriodo);
            this.panel1.Controls.Add(this.txtFiltroLibro);
            this.panel1.Controls.Add(this.lblFiltroPeriodo);
            this.panel1.Controls.Add(this.lblFiltroAutorTitulo);
            this.panel1.Location = new System.Drawing.Point(36, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 581);
            this.panel1.TabIndex = 1;
            // 
            // btnEliminarLibros
            // 
            this.btnEliminarLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarLibros.FlatAppearance.BorderSize = 0;
            this.btnEliminarLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btnEliminarLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnEliminarLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarLibros.Location = new System.Drawing.Point(665, 159);
            this.btnEliminarLibros.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarLibros.Name = "btnEliminarLibros";
            this.btnEliminarLibros.Size = new System.Drawing.Size(76, 31);
            this.btnEliminarLibros.TabIndex = 12;
            this.btnEliminarLibros.Text = "Eliminar";
            this.btnEliminarLibros.UseVisualStyleBackColor = false;
            this.btnEliminarLibros.Click += new System.EventHandler(this.btnEliminarLibros_Click);
            // 
            // btnModificarLibros
            // 
            this.btnModificarLibros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarLibros.FlatAppearance.BorderSize = 0;
            this.btnModificarLibros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(46)))), ((int)(((byte)(205)))));
            this.btnModificarLibros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnModificarLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarLibros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarLibros.Location = new System.Drawing.Point(579, 159);
            this.btnModificarLibros.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarLibros.Name = "btnModificarLibros";
            this.btnModificarLibros.Size = new System.Drawing.Size(82, 31);
            this.btnModificarLibros.TabIndex = 11;
            this.btnModificarLibros.Text = "Modificar";
            this.btnModificarLibros.UseVisualStyleBackColor = false;
            this.btnModificarLibros.Click += new System.EventHandler(this.btnModificarLibros_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Location = new System.Drawing.Point(26, 204);
            this.dgvLibros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersWidth = 51;
            this.dgvLibros.RowTemplate.Height = 24;
            this.dgvLibros.Size = new System.Drawing.Size(726, 346);
            this.dgvLibros.TabIndex = 7;
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoLibro.FlatAppearance.BorderSize = 0;
            this.btnNuevoLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevoLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoLibro.Location = new System.Drawing.Point(113, 159);
            this.btnNuevoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Size = new System.Drawing.Size(124, 31);
            this.btnNuevoLibro.TabIndex = 6;
            this.btnNuevoLibro.Text = "+ Nuevo Libro";
            this.btnNuevoLibro.UseVisualStyleBackColor = false;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarLibro.FlatAppearance.BorderSize = 0;
            this.btnBuscarLibro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarLibro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLibro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarLibro.Location = new System.Drawing.Point(33, 159);
            this.btnBuscarLibro.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(76, 31);
            this.btnBuscarLibro.TabIndex = 5;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = false;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // cmbFiltroPeriodo
            // 
            this.cmbFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbFiltroPeriodo.ForeColor = System.Drawing.Color.Black;
            this.cmbFiltroPeriodo.FormattingEnabled = true;
            this.cmbFiltroPeriodo.Location = new System.Drawing.Point(26, 112);
            this.cmbFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFiltroPeriodo.Name = "cmbFiltroPeriodo";
            this.cmbFiltroPeriodo.Size = new System.Drawing.Size(254, 28);
            this.cmbFiltroPeriodo.TabIndex = 2;
            // 
            // txtFiltroLibro
            // 
            this.txtFiltroLibro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroLibro.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroLibro.Location = new System.Drawing.Point(26, 46);
            this.txtFiltroLibro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroLibro.Multiline = true;
            this.txtFiltroLibro.Name = "txtFiltroLibro";
            this.txtFiltroLibro.Size = new System.Drawing.Size(546, 34);
            this.txtFiltroLibro.TabIndex = 4;
            // 
            // lblFiltroPeriodo
            // 
            this.lblFiltroPeriodo.AutoSize = true;
            this.lblFiltroPeriodo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroPeriodo.Location = new System.Drawing.Point(30, 86);
            this.lblFiltroPeriodo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroPeriodo.Name = "lblFiltroPeriodo";
            this.lblFiltroPeriodo.Size = new System.Drawing.Size(60, 18);
            this.lblFiltroPeriodo.TabIndex = 3;
            this.lblFiltroPeriodo.Text = "Período";
            this.lblFiltroPeriodo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFiltroAutorTitulo
            // 
            this.lblFiltroAutorTitulo.AutoSize = true;
            this.lblFiltroAutorTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroAutorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroAutorTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblFiltroAutorTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltroAutorTitulo.Name = "lblFiltroAutorTitulo";
            this.lblFiltroAutorTitulo.Size = new System.Drawing.Size(91, 18);
            this.lblFiltroAutorTitulo.TabIndex = 2;
            this.lblFiltroAutorTitulo.Text = "Autor / Título";
            this.lblFiltroAutorTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Libros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(919, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro_de_Libros";
            this.Text = "Registro_de_Libros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFiltroAutorTitulo;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.TextBox txtFiltroLibro;
        private PillButton btnBuscarLibro;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private PillButton btnNuevoLibro;
        private System.Windows.Forms.DataGridView dgvLibros;
        private PillButton btnModificarLibros;
        private PillButton btnEliminarLibros;
    }
}