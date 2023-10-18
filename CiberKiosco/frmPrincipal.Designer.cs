namespace CiberKiosco
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
            this.Ciberbutton = new System.Windows.Forms.Button();
            this.Productosbutton = new System.Windows.Forms.Button();
            this.SociosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ciberbutton
            // 
            this.Ciberbutton.BackColor = System.Drawing.Color.LavenderBlush;
            this.Ciberbutton.Location = new System.Drawing.Point(31, 52);
            this.Ciberbutton.Name = "Ciberbutton";
            this.Ciberbutton.Size = new System.Drawing.Size(75, 53);
            this.Ciberbutton.TabIndex = 0;
            this.Ciberbutton.Text = "Ciber";
            this.Ciberbutton.UseVisualStyleBackColor = false;
            this.Ciberbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Productosbutton
            // 
            this.Productosbutton.BackColor = System.Drawing.Color.LavenderBlush;
            this.Productosbutton.Location = new System.Drawing.Point(158, 52);
            this.Productosbutton.Name = "Productosbutton";
            this.Productosbutton.Size = new System.Drawing.Size(75, 53);
            this.Productosbutton.TabIndex = 1;
            this.Productosbutton.Text = "Productos";
            this.Productosbutton.UseVisualStyleBackColor = false;
            this.Productosbutton.Click += new System.EventHandler(this.Productosbutton_Click);
            // 
            // SociosButton
            // 
            this.SociosButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.SociosButton.Location = new System.Drawing.Point(281, 52);
            this.SociosButton.Name = "SociosButton";
            this.SociosButton.Size = new System.Drawing.Size(75, 53);
            this.SociosButton.TabIndex = 2;
            this.SociosButton.Text = "Socios";
            this.SociosButton.UseVisualStyleBackColor = false;
            this.SociosButton.Click += new System.EventHandler(this.SociosButton_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(405, 163);
            this.Controls.Add(this.SociosButton);
            this.Controls.Add(this.Productosbutton);
            this.Controls.Add(this.Ciberbutton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ciberbutton;
        private System.Windows.Forms.Button Productosbutton;
        private System.Windows.Forms.Button SociosButton;
    }
}

