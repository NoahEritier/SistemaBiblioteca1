namespace WindowsFormsApp1
{
    partial class NuevaEditorial
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
            this.pillButton1 = new WindowsFormsApp1.PillButton();
            this.btnConfirmarRegistro = new WindowsFormsApp1.PillButton();
            this.txtNombreEditorial = new System.Windows.Forms.TextBox();
            this.lblNombreEditorial = new System.Windows.Forms.Label();
            this.lblNuevaEditorial = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pillButton1);
            this.panel1.Controls.Add(this.btnConfirmarRegistro);
            this.panel1.Controls.Add(this.txtNombreEditorial);
            this.panel1.Controls.Add(this.lblNombreEditorial);
            this.panel1.Location = new System.Drawing.Point(48, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 715);
            this.panel1.TabIndex = 7;
            // 
            // pillButton1
            // 
            this.pillButton1.BackColor = System.Drawing.Color.LightGray;
            this.pillButton1.FlatAppearance.BorderSize = 0;
            this.pillButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.pillButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.pillButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pillButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pillButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pillButton1.Location = new System.Drawing.Point(40, 156);
            this.pillButton1.Name = "pillButton1";
            this.pillButton1.Size = new System.Drawing.Size(127, 38);
            this.pillButton1.TabIndex = 31;
            this.pillButton1.Text = "Cancelar";
            this.pillButton1.UseVisualStyleBackColor = false;
            this.pillButton1.Click += new System.EventHandler(this.pillButton1_Click);
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
            this.btnConfirmarRegistro.Location = new System.Drawing.Point(183, 156);
            this.btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            this.btnConfirmarRegistro.Size = new System.Drawing.Size(107, 38);
            this.btnConfirmarRegistro.TabIndex = 30;
            this.btnConfirmarRegistro.Text = "Aceptar";
            this.btnConfirmarRegistro.UseVisualStyleBackColor = false;
            this.btnConfirmarRegistro.Click += new System.EventHandler(this.btnConfirmarRegistro_Click);
            // 
            // txtNombreEditorial
            // 
            this.txtNombreEditorial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreEditorial.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNombreEditorial.Location = new System.Drawing.Point(35, 89);
            this.txtNombreEditorial.Multiline = true;
            this.txtNombreEditorial.Name = "txtNombreEditorial";
            this.txtNombreEditorial.Size = new System.Drawing.Size(403, 41);
            this.txtNombreEditorial.TabIndex = 4;
            // 
            // lblNombreEditorial
            // 
            this.lblNombreEditorial.AutoSize = true;
            this.lblNombreEditorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombreEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNombreEditorial.Location = new System.Drawing.Point(36, 52);
            this.lblNombreEditorial.Name = "lblNombreEditorial";
            this.lblNombreEditorial.Size = new System.Drawing.Size(91, 24);
            this.lblNombreEditorial.TabIndex = 2;
            this.lblNombreEditorial.Text = "* Nombre";
            this.lblNombreEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNuevaEditorial
            // 
            this.lblNuevaEditorial.AutoSize = true;
            this.lblNuevaEditorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNuevaEditorial.Location = new System.Drawing.Point(94, 39);
            this.lblNuevaEditorial.Name = "lblNuevaEditorial";
            this.lblNuevaEditorial.Size = new System.Drawing.Size(198, 31);
            this.lblNuevaEditorial.TabIndex = 6;
            this.lblNuevaEditorial.Text = "Nueva Editorial";
            this.lblNuevaEditorial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NuevaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1225, 852);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNuevaEditorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevaEditorial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private PillButton pillButton1;
        private PillButton btnConfirmarRegistro;
        private System.Windows.Forms.TextBox txtNombreEditorial;
        private System.Windows.Forms.Label lblNombreEditorial;
        private System.Windows.Forms.Label lblNuevaEditorial;
    }
}