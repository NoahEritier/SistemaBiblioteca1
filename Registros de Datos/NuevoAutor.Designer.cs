namespace WindowsFormsApp1
{
    partial class NuevoAutor
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
            this.txtNacionalidadAutor = new System.Windows.Forms.TextBox();
            this.lblNacionalidadAutor = new System.Windows.Forms.Label();
            this.txtApellidoAutor = new System.Windows.Forms.TextBox();
            this.lblApellidoAutor = new System.Windows.Forms.Label();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.lblNuevoAutor = new System.Windows.Forms.Label();
            this.btnCancelar = new WindowsFormsApp1.PillButton();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.txtNacionalidadAutor);
            this.panel1.Controls.Add(this.lblNacionalidadAutor);
            this.panel1.Controls.Add(this.txtApellidoAutor);
            this.panel1.Controls.Add(this.lblApellidoAutor);
            this.panel1.Controls.Add(this.txtNombreAutor);
            this.panel1.Controls.Add(this.lblNombreAutor);
            this.panel1.Location = new System.Drawing.Point(47, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 715);
            this.panel1.TabIndex = 5;
            // 
            // txtNacionalidadAutor
            // 
            this.txtNacionalidadAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidadAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNacionalidadAutor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNacionalidadAutor.Location = new System.Drawing.Point(35, 271);
            this.txtNacionalidadAutor.Multiline = true;
            this.txtNacionalidadAutor.Name = "txtNacionalidadAutor";
            this.txtNacionalidadAutor.Size = new System.Drawing.Size(403, 41);
            this.txtNacionalidadAutor.TabIndex = 8;
            // 
            // lblNacionalidadAutor
            // 
            this.lblNacionalidadAutor.AutoSize = true;
            this.lblNacionalidadAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNacionalidadAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNacionalidadAutor.Location = new System.Drawing.Point(36, 234);
            this.lblNacionalidadAutor.Name = "lblNacionalidadAutor";
            this.lblNacionalidadAutor.Size = new System.Drawing.Size(120, 24);
            this.lblNacionalidadAutor.TabIndex = 7;
            this.lblNacionalidadAutor.Text = "Nacionalidad";
            this.lblNacionalidadAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellidoAutor
            // 
            this.txtApellidoAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtApellidoAutor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtApellidoAutor.Location = new System.Drawing.Point(35, 180);
            this.txtApellidoAutor.Multiline = true;
            this.txtApellidoAutor.Name = "txtApellidoAutor";
            this.txtApellidoAutor.Size = new System.Drawing.Size(403, 41);
            this.txtApellidoAutor.TabIndex = 6;
            // 
            // lblApellidoAutor
            // 
            this.lblApellidoAutor.AutoSize = true;
            this.lblApellidoAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellidoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblApellidoAutor.Location = new System.Drawing.Point(36, 143);
            this.lblApellidoAutor.Name = "lblApellidoAutor";
            this.lblApellidoAutor.Size = new System.Drawing.Size(91, 24);
            this.lblApellidoAutor.TabIndex = 5;
            this.lblApellidoAutor.Text = "* Apellido";
            this.lblApellidoAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreAutor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtNombreAutor.Location = new System.Drawing.Point(35, 89);
            this.txtNombreAutor.Multiline = true;
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(403, 41);
            this.txtNombreAutor.TabIndex = 4;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreAutor.Location = new System.Drawing.Point(36, 52);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(91, 24);
            this.lblNombreAutor.TabIndex = 2;
            this.lblNombreAutor.Text = "* Nombre";
            this.lblNombreAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNuevoAutor
            // 
            this.lblNuevoAutor.AutoSize = true;
            this.lblNuevoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNuevoAutor.Location = new System.Drawing.Point(93, 32);
            this.lblNuevoAutor.Name = "lblNuevoAutor";
            this.lblNuevoAutor.Size = new System.Drawing.Size(165, 31);
            this.lblNuevoAutor.TabIndex = 4;
            this.lblNuevoAutor.Text = "Nuevo Autor";
            this.lblNuevoAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(41, 347);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 38);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(184, 347);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(107, 38);
            this.btnConfirmarRegistro.TabIndex = 30;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            this.btnConfirmarRegistro.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // NuevoAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 854);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoAutor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreAutor;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.Label lblNuevoAutor;
        private System.Windows.Forms.TextBox txtApellidoAutor;
        private System.Windows.Forms.Label lblApellidoAutor;
        private System.Windows.Forms.TextBox txtNacionalidadAutor;
        private System.Windows.Forms.Label lblNacionalidadAutor;
        private PillButton btnConfirmarRegistro;
        private PillButton btnCancelar;
    }
}