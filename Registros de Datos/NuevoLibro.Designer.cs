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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnPasarAGrilla = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtISBN);
            this.panel1.Controls.Add(this.lblISBN);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.btnPasarAGrilla);
            this.panel1.Controls.Add(this.dgvAutores);
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
            this.panel1.Location = new System.Drawing.Point(48, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 800);
            this.panel1.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtISBN.ForeColor = System.Drawing.Color.Black;
            this.txtISBN.Location = new System.Drawing.Point(41, 39);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Multiline = true;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(390, 41);
            this.txtISBN.TabIndex = 37;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblISBN.Location = new System.Drawing.Point(39, 14);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(69, 24);
            this.lblISBN.TabIndex = 36;
            this.lblISBN.Text = " * ISBN";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEliminar.Location = new System.Drawing.Point(958, 193);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 33);
            this.btnEliminar.TabIndex = 35;
            this.btnEliminar.Text = "B";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(1021, 14);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(93, 41);
            this.txtId.TabIndex = 34;
            this.txtId.Visible = false;
            // 
            // btnPasarAGrilla
            // 
            this.btnPasarAGrilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasarAGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnPasarAGrilla.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPasarAGrilla.Location = new System.Drawing.Point(493, 193);
            this.btnPasarAGrilla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPasarAGrilla.Name = "btnPasarAGrilla";
            this.btnPasarAGrilla.Size = new System.Drawing.Size(36, 33);
            this.btnPasarAGrilla.TabIndex = 33;
            this.btnPasarAGrilla.Text = "A";
            this.btnPasarAGrilla.UseVisualStyleBackColor = true;
            this.btnPasarAGrilla.Click += new System.EventHandler(this.btnPasarAGrilla_Click);
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.AllowUserToOrderColumns = true;
            this.dgvAutores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAutores.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgvAutores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutores.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutores.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAutores.Location = new System.Drawing.Point(535, 193);
            this.dgvAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersWidth = 51;
            this.dgvAutores.RowTemplate.Height = 24;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(421, 210);
            this.dgvAutores.TabIndex = 4;
            // 
            // txtEdicion
            // 
            this.txtEdicion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEdicion.ForeColor = System.Drawing.Color.Black;
            this.txtEdicion.Location = new System.Drawing.Point(43, 327);
            this.txtEdicion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblEdicion.Location = new System.Drawing.Point(43, 298);
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(184, 734);
            this.btnConfirmarRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnCancelarRegistro.Location = new System.Drawing.Point(41, 734);
            this.btnCancelarRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtPalabrasClave.ForeColor = System.Drawing.Color.Black;
            this.txtPalabrasClave.Location = new System.Drawing.Point(43, 662);
            this.txtPalabrasClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblPalabrasClave.Location = new System.Drawing.Point(43, 633);
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
            this.txtResumen.ForeColor = System.Drawing.Color.Black;
            this.txtResumen.Location = new System.Drawing.Point(43, 537);
            this.txtResumen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblResumen.Location = new System.Drawing.Point(43, 507);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(92, 24);
            this.lblResumen.TabIndex = 23;
            this.lblResumen.Text = "Resumen";
            this.lblResumen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbNiveles
            // 
            this.cmbNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbNiveles.ForeColor = System.Drawing.Color.Black;
            this.cmbNiveles.FormattingEnabled = true;
            this.cmbNiveles.ItemHeight = 25;
            this.cmbNiveles.Location = new System.Drawing.Point(43, 469);
            this.cmbNiveles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNiveles.Name = "cmbNiveles";
            this.cmbNiveles.Size = new System.Drawing.Size(403, 33);
            this.cmbNiveles.TabIndex = 19;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNivel.Location = new System.Drawing.Point(43, 441);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(64, 24);
            this.lblNivel.TabIndex = 17;
            this.lblNivel.Text = "* Nivel";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTemas
            // 
            this.cmbTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTemas.ForeColor = System.Drawing.Color.Black;
            this.cmbTemas.FormattingEnabled = true;
            this.cmbTemas.ItemHeight = 25;
            this.cmbTemas.Location = new System.Drawing.Point(43, 402);
            this.cmbTemas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTemas.Name = "cmbTemas";
            this.cmbTemas.Size = new System.Drawing.Size(403, 33);
            this.cmbTemas.TabIndex = 16;
            // 
            // btnAgregarNuevoTema
            // 
            this.btnAgregarNuevoTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoTema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoTema.Location = new System.Drawing.Point(452, 402);
            this.btnAgregarNuevoTema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblTema.Location = new System.Drawing.Point(43, 373);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(71, 24);
            this.lblTema.TabIndex = 14;
            this.lblTema.Text = "* Tema";
            this.lblTema.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbEditoriales
            // 
            this.cmbEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbEditoriales.ForeColor = System.Drawing.Color.Black;
            this.cmbEditoriales.FormattingEnabled = true;
            this.cmbEditoriales.ItemHeight = 25;
            this.cmbEditoriales.Location = new System.Drawing.Point(41, 260);
            this.cmbEditoriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEditoriales.Name = "cmbEditoriales";
            this.cmbEditoriales.Size = new System.Drawing.Size(403, 33);
            this.cmbEditoriales.TabIndex = 13;
            // 
            // btnAgregarNuevaEditorial
            // 
            this.btnAgregarNuevaEditorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevaEditorial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevaEditorial.Location = new System.Drawing.Point(450, 260);
            this.btnAgregarNuevaEditorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblEditorial.Location = new System.Drawing.Point(43, 231);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(89, 24);
            this.lblEditorial.TabIndex = 11;
            this.lblEditorial.Text = "* Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbAutores
            // 
            this.cmbAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbAutores.ForeColor = System.Drawing.Color.Black;
            this.cmbAutores.FormattingEnabled = true;
            this.cmbAutores.ItemHeight = 25;
            this.cmbAutores.Location = new System.Drawing.Point(41, 193);
            this.cmbAutores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbAutores.Name = "cmbAutores";
            this.cmbAutores.Size = new System.Drawing.Size(403, 33);
            this.cmbAutores.TabIndex = 10;
            // 
            // btnAgregarNuevoAutor
            // 
            this.btnAgregarNuevoAutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarNuevoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnAgregarNuevoAutor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregarNuevoAutor.Location = new System.Drawing.Point(451, 193);
            this.btnAgregarNuevoAutor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(41, 118);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblAutor.Location = new System.Drawing.Point(43, 164);
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
            this.lblTitulo.Location = new System.Drawing.Point(43, 89);
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
            this.ClientSize = new System.Drawing.Size(1225, 904);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NuevoLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoLibro";
            this.Load += new System.EventHandler(this.NuevoLibro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.Button btnPasarAGrilla;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtId;
    }
}