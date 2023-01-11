namespace WinGrupo3B
{
    partial class Form1
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
            this.btnCrearTransporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearTransporte
            // 
            this.btnCrearTransporte.Location = new System.Drawing.Point(203, 128);
            this.btnCrearTransporte.Name = "btnCrearTransporte";
            this.btnCrearTransporte.Size = new System.Drawing.Size(147, 23);
            this.btnCrearTransporte.TabIndex = 0;
            this.btnCrearTransporte.Text = "Crear Transporte";
            this.btnCrearTransporte.UseVisualStyleBackColor = true;
            this.btnCrearTransporte.Click += new System.EventHandler(this.btnCrearTransporte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 303);
            this.Controls.Add(this.btnCrearTransporte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearTransporte;
    }
}

