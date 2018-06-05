namespace Ejemplo1
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnholamundo = new System.Windows.Forms.Button();
            this.lblholamundo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnholamundo
            // 
            this.btnholamundo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnholamundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnholamundo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnholamundo.Location = new System.Drawing.Point(187, 185);
            this.btnholamundo.Name = "btnholamundo";
            this.btnholamundo.Size = new System.Drawing.Size(188, 64);
            this.btnholamundo.TabIndex = 0;
            this.btnholamundo.Text = "Hola Mundo!";
            this.btnholamundo.UseVisualStyleBackColor = false;
            this.btnholamundo.Click += new System.EventHandler(this.btnholamundo_Click);
            // 
            // lblholamundo
            // 
            this.lblholamundo.AutoSize = true;
            this.lblholamundo.Font = new System.Drawing.Font("Source Code Pro", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblholamundo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblholamundo.Location = new System.Drawing.Point(99, 22);
            this.lblholamundo.Name = "lblholamundo";
            this.lblholamundo.Size = new System.Drawing.Size(0, 46);
            this.lblholamundo.TabIndex = 1;
            this.lblholamundo.Click += new System.EventHandler(this.lblholamundo_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 261);
            this.Controls.Add(this.lblholamundo);
            this.Controls.Add(this.btnholamundo);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnholamundo;
        private System.Windows.Forms.Label lblholamundo;
    }
}

