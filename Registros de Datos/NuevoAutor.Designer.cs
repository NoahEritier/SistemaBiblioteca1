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
            this.btnCancelar = new WindowsFormsApp1.PillButton();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.txtNacionalidadAutor = new System.Windows.Forms.TextBox();
            this.lblNacionalidadAutor = new System.Windows.Forms.Label();
            this.txtApellidoAutor = new System.Windows.Forms.TextBox();
            this.lblApellidoAutor = new System.Windows.Forms.Label();
            this.txtNombreAutor = new System.Windows.Forms.TextBox();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.lblNuevoAutor = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(35, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 581);
            this.panel1.TabIndex = 5;
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
            this.btnCancelar.Location = new System.Drawing.Point(31, 282);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 31);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(138, 282);
            this.btnConfirmarRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(80, 31);
            this.btnConfirmarRegistro.TabIndex = 30;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            this.btnConfirmarRegistro.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // txtNacionalidadAutor
            // 
            this.txtNacionalidadAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidadAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNacionalidadAutor.ForeColor = System.Drawing.Color.Black;
            this.txtNacionalidadAutor.Location = new System.Drawing.Point(26, 220);
            this.txtNacionalidadAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNacionalidadAutor.Multiline = true;
            this.txtNacionalidadAutor.Name = "txtNacionalidadAutor";
            this.txtNacionalidadAutor.Size = new System.Drawing.Size(303, 34);
            this.txtNacionalidadAutor.TabIndex = 8;
            // 
            // lblNacionalidadAutor
            // 
            this.lblNacionalidadAutor.AutoSize = true;
            this.lblNacionalidadAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNacionalidadAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNacionalidadAutor.Location = new System.Drawing.Point(27, 190);
            this.lblNacionalidadAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacionalidadAutor.Name = "lblNacionalidadAutor";
            this.lblNacionalidadAutor.Size = new System.Drawing.Size(93, 18);
            this.lblNacionalidadAutor.TabIndex = 7;
            this.lblNacionalidadAutor.Text = "Nacionalidad";
            this.lblNacionalidadAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtApellidoAutor
            // 
            this.txtApellidoAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtApellidoAutor.ForeColor = System.Drawing.Color.Black;
            this.txtApellidoAutor.Location = new System.Drawing.Point(26, 146);
            this.txtApellidoAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidoAutor.Multiline = true;
            this.txtApellidoAutor.Name = "txtApellidoAutor";
            this.txtApellidoAutor.Size = new System.Drawing.Size(303, 34);
            this.txtApellidoAutor.TabIndex = 6;
            // 
            // lblApellidoAutor
            // 
            this.lblApellidoAutor.AutoSize = true;
            this.lblApellidoAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellidoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblApellidoAutor.Location = new System.Drawing.Point(27, 116);
            this.lblApellidoAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoAutor.Name = "lblApellidoAutor";
            this.lblApellidoAutor.Size = new System.Drawing.Size(69, 18);
            this.lblApellidoAutor.TabIndex = 5;
            this.lblApellidoAutor.Text = "* Apellido";
            this.lblApellidoAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombreAutor
            // 
            this.txtNombreAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreAutor.ForeColor = System.Drawing.Color.Black;
            this.txtNombreAutor.Location = new System.Drawing.Point(26, 72);
            this.txtNombreAutor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreAutor.Multiline = true;
            this.txtNombreAutor.Name = "txtNombreAutor";
            this.txtNombreAutor.Size = new System.Drawing.Size(303, 34);
            this.txtNombreAutor.TabIndex = 4;
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.AutoSize = true;
            this.lblNombreAutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreAutor.Location = new System.Drawing.Point(27, 42);
            this.lblNombreAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(72, 18);
            this.lblNombreAutor.TabIndex = 2;
            this.lblNombreAutor.Text = "* Nombre";
            this.lblNombreAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNuevoAutor
            // 
            this.lblNuevoAutor.AutoSize = true;
            this.lblNuevoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNuevoAutor.Location = new System.Drawing.Point(70, 26);
            this.lblNuevoAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevoAutor.Name = "lblNuevoAutor";
            this.lblNuevoAutor.Size = new System.Drawing.Size(133, 26);
            this.lblNuevoAutor.TabIndex = 4;
            this.lblNuevoAutor.Text = "Nuevo Autor";
            this.lblNuevoAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevoAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(919, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevoAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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