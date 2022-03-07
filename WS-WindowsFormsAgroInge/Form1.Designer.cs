namespace WS_WindowsFormsAgroInge
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
            this.btnMetodoGET = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMetodoPOST = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetodoGET
            // 
            this.btnMetodoGET.Location = new System.Drawing.Point(75, 90);
            this.btnMetodoGET.Name = "btnMetodoGET";
            this.btnMetodoGET.Size = new System.Drawing.Size(110, 40);
            this.btnMetodoGET.TabIndex = 0;
            this.btnMetodoGET.Text = "Método GET";
            this.btnMetodoGET.UseVisualStyleBackColor = true;
            this.btnMetodoGET.Click += new System.EventHandler(this.btnMetodoGET_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(75, 51);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(238, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // btnMetodoPOST
            // 
            this.btnMetodoPOST.Location = new System.Drawing.Point(203, 90);
            this.btnMetodoPOST.Name = "btnMetodoPOST";
            this.btnMetodoPOST.Size = new System.Drawing.Size(110, 40);
            this.btnMetodoPOST.TabIndex = 2;
            this.btnMetodoPOST.Text = "Método POST";
            this.btnMetodoPOST.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 172);
            this.Controls.Add(this.btnMetodoPOST);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnMetodoGET);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMetodoGET;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMetodoPOST;
    }
}

