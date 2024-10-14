namespace WindowsFormsApp1.Consultas
{
    partial class Registro_de_Editoriales
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
            this.dgvEditoriales = new System.Windows.Forms.DataGridView();
            this.btnNuevaEditorial = new WindowsFormsApp1.PillButton();
            this.btnBuscarEditorial = new WindowsFormsApp1.PillButton();
            this.cmbFiltroPeriodo = new System.Windows.Forms.ComboBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblFiltroPeriodo = new System.Windows.Forms.Label();
            this.lblFiltroNombreEditorial = new System.Windows.Forms.Label();
            this.lblEditorialesRegistradas = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel.Controls.Add(this.dgvEditoriales);
            this.panel.Controls.Add(this.btnNuevaEditorial);
            this.panel.Controls.Add(this.btnBuscarEditorial);
            this.panel.Controls.Add(this.cmbFiltroPeriodo);
            this.panel.Controls.Add(this.txtFiltroNombre);
            this.panel.Controls.Add(this.lblFiltroPeriodo);
            this.panel.Controls.Add(this.lblFiltroNombreEditorial);
            this.panel.Location = new System.Drawing.Point(49, 103);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1129, 715);
            this.panel.TabIndex = 5;
            // 
            // dgvEditoriales
            // 
            this.dgvEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoriales.Location = new System.Drawing.Point(35, 262);
            this.dgvEditoriales.Name = "dgvEditoriales";
            this.dgvEditoriales.RowHeadersWidth = 51;
            this.dgvEditoriales.RowTemplate.Height = 24;
            this.dgvEditoriales.Size = new System.Drawing.Size(968, 415);
            this.dgvEditoriales.TabIndex = 7;
            // 
            // btnNuevaEditorial
            // 
            this.btnNuevaEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevaEditorial.FlatAppearance.BorderSize = 0;
            this.btnNuevaEditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(98)))), ((int)(((byte)(229)))));
            this.btnNuevaEditorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(76)))), ((int)(((byte)(201)))));
            this.btnNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEditorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaEditorial.Location = new System.Drawing.Point(167, 196);
            this.btnNuevaEditorial.Name = "btnNuevaEditorial";
            this.btnNuevaEditorial.Size = new System.Drawing.Size(165, 38);
            this.btnNuevaEditorial.TabIndex = 6;
            this.btnNuevaEditorial.Text = "+ Nueva Editorial";
            this.btnNuevaEditorial.UseVisualStyleBackColor = false;
            this.btnNuevaEditorial.Click += new System.EventHandler(this.btnNuevaEditorial_Click);
            // 
            // btnBuscarEditorial
            // 
            this.btnBuscarEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarEditorial.FlatAppearance.BorderSize = 0;
            this.btnBuscarEditorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnBuscarEditorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnBuscarEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEditorial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarEditorial.Location = new System.Drawing.Point(44, 196);
            this.btnBuscarEditorial.Name = "btnBuscarEditorial";
            this.btnBuscarEditorial.Size = new System.Drawing.Size(101, 38);
            this.btnBuscarEditorial.TabIndex = 5;
            this.btnBuscarEditorial.Text = "Buscar";
            this.btnBuscarEditorial.UseVisualStyleBackColor = false;
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
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFiltroNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltroNombre.Location = new System.Drawing.Point(35, 51);
            this.txtFiltroNombre.Multiline = true;
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(501, 41);
            this.txtFiltroNombre.TabIndex = 4;
            this.txtFiltroNombre.Text = "Ingrese el nombre de la editorial";
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
            // lblFiltroNombreEditorial
            // 
            this.lblFiltroNombreEditorial.AutoSize = true;
            this.lblFiltroNombreEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroNombreEditorial.Location = new System.Drawing.Point(40, 24);
            this.lblFiltroNombreEditorial.Name = "lblFiltroNombreEditorial";
            this.lblFiltroNombreEditorial.Size = new System.Drawing.Size(79, 24);
            this.lblFiltroNombreEditorial.TabIndex = 2;
            this.lblFiltroNombreEditorial.Text = "Nombre";
            this.lblFiltroNombreEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditorialesRegistradas
            // 
            this.lblEditorialesRegistradas.AutoSize = true;
            this.lblEditorialesRegistradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEditorialesRegistradas.Location = new System.Drawing.Point(104, 53);
            this.lblEditorialesRegistradas.Name = "lblEditorialesRegistradas";
            this.lblEditorialesRegistradas.Size = new System.Drawing.Size(294, 31);
            this.lblEditorialesRegistradas.TabIndex = 4;
            this.lblEditorialesRegistradas.Text = "Editoriales Registradas";
            this.lblEditorialesRegistradas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Registro_de_Editoriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 890);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblEditorialesRegistradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro_de_Editoriales";
            this.Text = "Registro_de_Editoriales";
            this.Load += new System.EventHandler(this.Registro_de_Editoriales_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dgvEditoriales;
        private PillButton btnNuevaEditorial;
        private PillButton btnBuscarEditorial;
        private System.Windows.Forms.ComboBox cmbFiltroPeriodo;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Label lblFiltroPeriodo;
        private System.Windows.Forms.Label lblFiltroNombreEditorial;
        private System.Windows.Forms.Label lblEditorialesRegistradas;
    }
}