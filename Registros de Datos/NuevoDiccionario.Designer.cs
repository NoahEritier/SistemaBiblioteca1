namespace WindowsFormsApp1.Registros_de_Datos
{
    partial class NuevoDiccionario
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
            this.lblAño = new System.Windows.Forms.Label();
            this.txtTomos = new System.Windows.Forms.TextBox();
            this.lblTomos = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.cmbIdiomas = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbEditoriales = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevaEditorial = new System.Windows.Forms.Button();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblNuevoDiccionario = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.lblAño);
            this.panel1.Controls.Add(this.txtTomos);
            this.panel1.Controls.Add(this.lblTomos);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.cmbIdiomas);
            this.panel1.Controls.Add(this.lblIdioma);
            this.panel1.Controls.Add(this.cmbEditoriales);
            this.panel1.Controls.Add(this.btnAgregarNuevaEditorial);
            this.panel1.Controls.Add(this.lblEditorial);
            this.panel1.Location = new System.Drawing.Point(41, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 763);
            this.panel1.TabIndex = 5;
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAño.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAño.Location = new System.Drawing.Point(36, 285);
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(93, 41);
            this.txtAño.TabIndex = 34;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAño.Location = new System.Drawing.Point(37, 255);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(45, 24);
            this.lblAño.TabIndex = 33;
            this.lblAño.Text = "Año";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTomos
            // 
            this.txtTomos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTomos.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTomos.Location = new System.Drawing.Point(36, 211);
            this.txtTomos.Multiline = true;
            this.txtTomos.Name = "txtTomos";
            this.txtTomos.Size = new System.Drawing.Size(93, 41);
            this.txtTomos.TabIndex = 32;
            // 
            // lblTomos
            // 
            this.lblTomos.AutoSize = true;
            this.lblTomos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTomos.Location = new System.Drawing.Point(37, 181);
            this.lblTomos.Name = "lblTomos";
            this.lblTomos.Size = new System.Drawing.Size(69, 24);
            this.lblTomos.TabIndex = 31;
            this.lblTomos.Text = "Tomos";
            this.lblTomos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnConfirmarRegistro
            // 
            this.btnConfirmarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnConfirmarRegistro.FlatAppearance.BorderSize = 0;
            this.btnConfirmarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(146)))));
            this.btnConfirmarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(126)))));
            this.btnConfirmarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarRegistro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(184, 356);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(107, 38);
            this.btnConfirmarRegistro.TabIndex = 28;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            this.btnConfirmarRegistro.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelarRegistro.FlatAppearance.BorderSize = 0;
            this.btnCancelarRegistro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCancelarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(41, 356);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // cmbIdiomas
            // 
            this.cmbIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbIdiomas.FormattingEnabled = true;
            this.cmbIdiomas.ItemHeight = 25;
            this.cmbIdiomas.Location = new System.Drawing.Point(36, 145);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(403, 33);
            this.cmbIdiomas.TabIndex = 19;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdioma.Location = new System.Drawing.Point(37, 115);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(78, 24);
            this.lblIdioma.TabIndex = 17;
            this.lblIdioma.Text = "* Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEditoriales
            // 
            this.cmbEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEditoriales.FormattingEnabled = true;
            this.cmbEditoriales.ItemHeight = 25;
            this.cmbEditoriales.Location = new System.Drawing.Point(36, 79);
            this.cmbEditoriales.Name = "cmbEditoriales";
            this.cmbEditoriales.Size = new System.Drawing.Size(403, 33);
            this.cmbEditoriales.TabIndex = 13;
            // 
            // btnAgregarNuevaEditorial
            // 
            this.btnAgregarNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevaEditorial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevaEditorial.Location = new System.Drawing.Point(445, 79);
            this.btnAgregarNuevaEditorial.Name = "btnAgregarNuevaEditorial";
            this.btnAgregarNuevaEditorial.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarNuevaEditorial.TabIndex = 12;
            this.btnAgregarNuevaEditorial.Text = "+";
            this.btnAgregarNuevaEditorial.UseVisualStyleBackColor = true;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEditorial.Location = new System.Drawing.Point(37, 49);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(89, 24);
            this.lblEditorial.TabIndex = 11;
            this.lblEditorial.Text = "* Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNuevoDiccionario
            // 
            this.lblNuevoDiccionario.AutoSize = true;
            this.lblNuevoDiccionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNuevoDiccionario.Location = new System.Drawing.Point(96, 26);
            this.lblNuevoDiccionario.Name = "lblNuevoDiccionario";
            this.lblNuevoDiccionario.Size = new System.Drawing.Size(235, 31);
            this.lblNuevoDiccionario.TabIndex = 4;
            this.lblNuevoDiccionario.Text = "Nuevo Diccionario";
            this.lblNuevoDiccionario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoDiccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoDiccionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoDiccionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoDiccionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtTomos;
        private System.Windows.Forms.Label lblTomos;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelarRegistro;
        private System.Windows.Forms.ComboBox cmbIdiomas;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbEditoriales;
        private System.Windows.Forms.Button btnAgregarNuevaEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblNuevoDiccionario;
    }
}