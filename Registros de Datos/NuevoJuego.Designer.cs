namespace WindowsFormsApp1.Registros_de_Datos
{
    partial class NuevoJuego
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.btnCancelarRegistro = new WindowsFormsApp1.PillButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProyectosDeCatedra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.cmbCantidad);
            this.panel1.Controls.Add(this.lblCantidad);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.btnCancelarRegistro);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(39, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 763);
            this.panel1.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombre.Location = new System.Drawing.Point(36, 76);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(403, 41);
            this.txtNombre.TabIndex = 35;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.ItemHeight = 25;
            this.cmbCantidad.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbCantidad.Location = new System.Drawing.Point(36, 147);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(82, 33);
            this.cmbCantidad.TabIndex = 34;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCantidad.Location = new System.Drawing.Point(37, 120);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(84, 24);
            this.lblCantidad.TabIndex = 31;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(193, 199);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(107, 38);
            this.btnConfirmarRegistro.TabIndex = 28;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
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
            this.btnCancelarRegistro.Location = new System.Drawing.Point(51, 199);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(127, 38);
            this.btnCancelarRegistro.TabIndex = 27;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombre.Location = new System.Drawing.Point(37, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 24);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblProyectosDeCatedra
            // 
            this.lblProyectosDeCatedra.AutoSize = true;
            this.lblProyectosDeCatedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblProyectosDeCatedra.Location = new System.Drawing.Point(94, 12);
            this.lblProyectosDeCatedra.Name = "lblProyectosDeCatedra";
            this.lblProyectosDeCatedra.Size = new System.Drawing.Size(174, 31);
            this.lblProyectosDeCatedra.TabIndex = 10;
            this.lblProyectosDeCatedra.Text = "Nuevo Juego";
            this.lblProyectosDeCatedra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblProyectosDeCatedra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoJuego";
            this.Text = "NuevoJuego";
            this.Load += new System.EventHandler(this.NuevoJuego_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelarRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProyectosDeCatedra;
        private System.Windows.Forms.TextBox txtNombre;
    }
}