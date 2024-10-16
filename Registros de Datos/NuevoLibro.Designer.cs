namespace WindowsFormsApp1
{
    partial class NuevoLibro
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
            this.txtEdicion = new System.Windows.Forms.TextBox();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.txtPalabrasClave = new System.Windows.Forms.TextBox();
            this.lblPalabrasClave = new System.Windows.Forms.Label();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.lblResumen = new System.Windows.Forms.Label();
            this.cmbNiveles = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevoTema = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbEditoriales = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevaEditorial = new System.Windows.Forms.Button();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevoAutor = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNuevoLibro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtEdicion);
            this.panel1.Controls.Add(this.lblEdicion);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.txtPalabrasClave);
            this.panel1.Controls.Add(this.lblPalabrasClave);
            this.panel1.Controls.Add(this.txtResumen);
            this.panel1.Controls.Add(this.lblResumen);
            this.panel1.Controls.Add(this.cmbNiveles);
            this.panel1.Controls.Add(this.lblNivel);
            this.panel1.Controls.Add(this.cmbTemas);
            this.panel1.Controls.Add(this.btnAgregarNuevoTema);
            this.panel1.Controls.Add(this.lblTema);
            this.panel1.Controls.Add(this.cmbEditoriales);
            this.panel1.Controls.Add(this.btnAgregarNuevaEditorial);
            this.panel1.Controls.Add(this.lblEditorial);
            this.panel1.Controls.Add(this.cmbAutores);
            this.panel1.Controls.Add(this.btnAgregarNuevoAutor);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lblAutor);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(48, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 763);
            this.panel1.TabIndex = 3;
            // 
            // txtEdicion
            // 
            this.txtEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEdicion.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEdicion.Location = new System.Drawing.Point(36, 270);
            this.txtEdicion.Multiline = true;
            this.txtEdicion.Name = "txtEdicion";
            this.txtEdicion.Size = new System.Drawing.Size(93, 41);
            this.txtEdicion.TabIndex = 32;
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEdicion.Location = new System.Drawing.Point(37, 240);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(74, 24);
            this.lblEdicion.TabIndex = 31;
            this.lblEdicion.Text = "Edición";
            this.lblEdicion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(184, 695);
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
            this.btnCancelarRegistro.Location = new System.Drawing.Point(41, 695);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // txtPalabrasClave
            // 
            this.txtPalabrasClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPalabrasClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPalabrasClave.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPalabrasClave.Location = new System.Drawing.Point(36, 613);
            this.txtPalabrasClave.Multiline = true;
            this.txtPalabrasClave.Name = "txtPalabrasClave";
            this.txtPalabrasClave.Size = new System.Drawing.Size(793, 41);
            this.txtPalabrasClave.TabIndex = 26;
            // 
            // lblPalabrasClave
            // 
            this.lblPalabrasClave.AutoSize = true;
            this.lblPalabrasClave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPalabrasClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPalabrasClave.Location = new System.Drawing.Point(37, 583);
            this.lblPalabrasClave.Name = "lblPalabrasClave";
            this.lblPalabrasClave.Size = new System.Drawing.Size(131, 24);
            this.lblPalabrasClave.TabIndex = 25;
            this.lblPalabrasClave.Text = "Palabras clave";
            this.lblPalabrasClave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtResumen
            // 
            this.txtResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtResumen.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResumen.Location = new System.Drawing.Point(36, 485);
            this.txtResumen.Multiline = true;
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(1055, 92);
            this.txtResumen.TabIndex = 24;
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResumen.Location = new System.Drawing.Point(37, 455);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(92, 24);
            this.lblResumen.TabIndex = 23;
            this.lblResumen.Text = "Resumen";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbNiveles
            // 
            this.cmbNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNiveles.FormattingEnabled = true;
            this.cmbNiveles.ItemHeight = 25;
            this.cmbNiveles.Location = new System.Drawing.Point(36, 416);
            this.cmbNiveles.Name = "cmbNiveles";
            this.cmbNiveles.Size = new System.Drawing.Size(403, 33);
            this.cmbNiveles.TabIndex = 19;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNivel.Location = new System.Drawing.Point(37, 386);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(64, 24);
            this.lblNivel.TabIndex = 17;
            this.lblNivel.Text = "* Nivel";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTemas
            // 
            this.cmbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.ItemHeight = 25;
            this.cmbTemas.Location = new System.Drawing.Point(36, 347);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(403, 33);
            this.cmbTemas.TabIndex = 16;
            // 
            // btnAgregarNuevoTema
            // 
            this.btnAgregarNuevoTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoTema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoTema.Location = new System.Drawing.Point(444, 347);
            this.btnAgregarNuevoTema.Name = "btnAgregarNuevoTema";
            this.btnAgregarNuevoTema.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarNuevoTema.TabIndex = 15;
            this.btnAgregarNuevoTema.Text = "+";
            this.btnAgregarNuevoTema.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoTema.Click += new System.EventHandler(this.btnAgregarNuevoTema_Click);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTema.Location = new System.Drawing.Point(37, 317);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(71, 24);
            this.lblTema.TabIndex = 14;
            this.lblTema.Text = "* Tema";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEditoriales
            // 
            this.cmbEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEditoriales.FormattingEnabled = true;
            this.cmbEditoriales.ItemHeight = 25;
            this.cmbEditoriales.Location = new System.Drawing.Point(35, 201);
            this.cmbEditoriales.Name = "cmbEditoriales";
            this.cmbEditoriales.Size = new System.Drawing.Size(403, 33);
            this.cmbEditoriales.TabIndex = 13;
            // 
            // btnAgregarNuevaEditorial
            // 
            this.btnAgregarNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevaEditorial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevaEditorial.Location = new System.Drawing.Point(444, 201);
            this.btnAgregarNuevaEditorial.Name = "btnAgregarNuevaEditorial";
            this.btnAgregarNuevaEditorial.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarNuevaEditorial.TabIndex = 12;
            this.btnAgregarNuevaEditorial.Text = "+";
            this.btnAgregarNuevaEditorial.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaEditorial.Click += new System.EventHandler(this.btnAgregarNuevaEditorial_Click);
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEditorial.Location = new System.Drawing.Point(36, 171);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(89, 24);
            this.lblEditorial.TabIndex = 11;
            this.lblEditorial.Text = "* Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbAutores
            // 
            this.cmbAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.ItemHeight = 25;
            this.cmbAutores.Location = new System.Drawing.Point(35, 132);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(403, 33);
            this.cmbAutores.TabIndex = 10;
            // 
            // btnAgregarNuevoAutor
            // 
            this.btnAgregarNuevoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoAutor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoAutor.Location = new System.Drawing.Point(444, 132);
            this.btnAgregarNuevoAutor.Name = "btnAgregarNuevoAutor";
            this.btnAgregarNuevoAutor.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarNuevoAutor.TabIndex = 9;
            this.btnAgregarNuevoAutor.Text = "+";
            this.btnAgregarNuevoAutor.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoAutor.Click += new System.EventHandler(this.btnAgregarNuevoAutor_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTitulo.Location = new System.Drawing.Point(35, 55);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(793, 41);
            this.txtTitulo.TabIndex = 4;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAutor.Location = new System.Drawing.Point(36, 102);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(67, 24);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "* Autor";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTitulo.Location = new System.Drawing.Point(36, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(68, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "* Título";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNuevoLibro
            // 
            this.lblNuevoLibro.AutoSize = true;
            this.lblNuevoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNuevoLibro.Location = new System.Drawing.Point(103, 30);
            this.lblNuevoLibro.Name = "lblNuevoLibro";
            this.lblNuevoLibro.Size = new System.Drawing.Size(160, 31);
            this.lblNuevoLibro.TabIndex = 2;
            this.lblNuevoLibro.Text = "Nuevo Libro";
            this.lblNuevoLibro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoLibro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNuevoLibro;
        private System.Windows.Forms.Button btnAgregarNuevoAutor;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.ComboBox cmbNiveles;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Button btnAgregarNuevoTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cmbEditoriales;
        private System.Windows.Forms.Button btnAgregarNuevaEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.TextBox txtPalabrasClave;
        private System.Windows.Forms.Label lblPalabrasClave;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelarRegistro;
        private System.Windows.Forms.TextBox txtEdicion;
        private System.Windows.Forms.Label lblEdicion;
    }
}