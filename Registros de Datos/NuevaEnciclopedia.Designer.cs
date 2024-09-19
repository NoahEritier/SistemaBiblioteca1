namespace WindowsFormsApp1.Registros_de_Datos
{
    partial class NuevaEnciclopedia
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
            this.txtTomos = new System.Windows.Forms.TextBox();
            this.lblTomos = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.cmbTemas = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevoTema = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.cmbIdiomas = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cmbAutores = new System.Windows.Forms.ComboBox();
            this.btnAgregarNuevaEditorial = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNuevoLibro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtTomos);
            this.panel1.Controls.Add(this.lblTomos);
            this.panel1.Controls.Add(this.txtAño);
            this.panel1.Controls.Add(this.lblAño);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.cmbTemas);
            this.panel1.Controls.Add(this.btnAgregarNuevoTema);
            this.panel1.Controls.Add(this.lblTema);
            this.panel1.Controls.Add(this.cmbIdiomas);
            this.panel1.Controls.Add(this.lblIdioma);
            this.panel1.Controls.Add(this.cmbAutores);
            this.panel1.Controls.Add(this.btnAgregarNuevaEditorial);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.lblEditorial);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(48, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 763);
            this.panel1.TabIndex = 5;
            // 
            // txtTomos
            // 
            this.txtTomos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTomos.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTomos.Location = new System.Drawing.Point(36, 421);
            this.txtTomos.Multiline = true;
            this.txtTomos.Name = "txtTomos";
            this.txtTomos.Size = new System.Drawing.Size(93, 41);
            this.txtTomos.TabIndex = 34;
            // 
            // lblTomos
            // 
            this.lblTomos.AutoSize = true;
            this.lblTomos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTomos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTomos.Location = new System.Drawing.Point(37, 390);
            this.lblTomos.Name = "lblTomos";
            this.lblTomos.Size = new System.Drawing.Size(81, 24);
            this.lblTomos.TabIndex = 33;
            this.lblTomos.Text = "* Tomos";
            this.lblTomos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAño
            // 
            this.txtAño.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAño.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAño.Location = new System.Drawing.Point(36, 271);
            this.txtAño.Multiline = true;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(93, 41);
            this.txtAño.TabIndex = 32;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAño.Location = new System.Drawing.Point(37, 240);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(57, 24);
            this.lblAño.TabIndex = 31;
            this.lblAño.Text = "* Año";
            this.lblAño.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(184, 483);
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
            this.btnCancelarRegistro.Location = new System.Drawing.Point(41, 483);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            // 
            // cmbTemas
            // 
            this.cmbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.ItemHeight = 25;
            this.cmbTemas.Location = new System.Drawing.Point(36, 350);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(403, 33);
            this.cmbTemas.TabIndex = 16;
            // 
            // btnAgregarNuevoTema
            // 
            this.btnAgregarNuevoTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoTema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoTema.Location = new System.Drawing.Point(445, 350);
            this.btnAgregarNuevoTema.Name = "btnAgregarNuevoTema";
            this.btnAgregarNuevoTema.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarNuevoTema.TabIndex = 15;
            this.btnAgregarNuevoTema.Text = "+";
            this.btnAgregarNuevoTema.UseVisualStyleBackColor = true;
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTema.Location = new System.Drawing.Point(37, 319);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(71, 24);
            this.lblTema.TabIndex = 14;
            this.lblTema.Text = "* Tema";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbIdiomas
            // 
            this.cmbIdiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbIdiomas.FormattingEnabled = true;
            this.cmbIdiomas.ItemHeight = 25;
            this.cmbIdiomas.Location = new System.Drawing.Point(35, 201);
            this.cmbIdiomas.Name = "cmbIdiomas";
            this.cmbIdiomas.Size = new System.Drawing.Size(403, 33);
            this.cmbIdiomas.TabIndex = 13;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdioma.Location = new System.Drawing.Point(36, 171);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(78, 24);
            this.lblIdioma.TabIndex = 11;
            this.lblIdioma.Text = "* Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // btnAgregarNuevaEditorial
            // 
            this.btnAgregarNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevaEditorial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevaEditorial.Location = new System.Drawing.Point(444, 132);
            this.btnAgregarNuevaEditorial.Name = "btnAgregarNuevaEditorial";
            this.btnAgregarNuevaEditorial.Size = new System.Drawing.Size(36, 33);
            this.btnAgregarNuevaEditorial.TabIndex = 9;
            this.btnAgregarNuevaEditorial.Text = "+";
            this.btnAgregarNuevaEditorial.UseVisualStyleBackColor = true;
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
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEditorial.Location = new System.Drawing.Point(36, 102);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(89, 24);
            this.lblEditorial.TabIndex = 3;
            this.lblEditorial.Text = "* Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblNuevoLibro.Location = new System.Drawing.Point(103, 36);
            this.lblNuevoLibro.Name = "lblNuevoLibro";
            this.lblNuevoLibro.Size = new System.Drawing.Size(254, 31);
            this.lblNuevoLibro.TabIndex = 4;
            this.lblNuevoLibro.Text = "Nueva Enciclopedia";
            this.lblNuevoLibro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevaEnciclopedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaEnciclopedia";
            this.Text = "NuevaEnciclopedia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTomos;
        private System.Windows.Forms.Label lblTomos;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label lblAño;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelarRegistro;
        private System.Windows.Forms.ComboBox cmbTemas;
        private System.Windows.Forms.Button btnAgregarNuevoTema;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cmbIdiomas;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cmbAutores;
        private System.Windows.Forms.Button btnAgregarNuevaEditorial;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNuevoLibro;
    }
}