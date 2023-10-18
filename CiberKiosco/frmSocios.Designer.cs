namespace CiberKiosco
{
    partial class frmSocios
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregartoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.EditartoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.BorrartoolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroSocioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregartoolStripLabel,
            this.EditartoolStripLabel,
            this.BorrartoolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(445, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregartoolStripLabel
            // 
            this.AgregartoolStripLabel.Name = "AgregartoolStripLabel";
            this.AgregartoolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.AgregartoolStripLabel.Text = "Agregar";
            // 
            // EditartoolStripLabel
            // 
            this.EditartoolStripLabel.Name = "EditartoolStripLabel";
            this.EditartoolStripLabel.Size = new System.Drawing.Size(37, 22);
            this.EditartoolStripLabel.Text = "Editar";
            // 
            // BorrartoolStripLabel
            // 
            this.BorrartoolStripLabel.Name = "BorrartoolStripLabel";
            this.BorrartoolStripLabel.Size = new System.Drawing.Size(39, 22);
            this.BorrartoolStripLabel.Text = "Borrar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreColumn,
            this.ApellidoColumn,
            this.NroSocioColumn,
            this.DniColumn});
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            this.NombreColumn.ReadOnly = true;
            // 
            // ApellidoColumn
            // 
            this.ApellidoColumn.HeaderText = "Apellido";
            this.ApellidoColumn.Name = "ApellidoColumn";
            this.ApellidoColumn.ReadOnly = true;
            // 
            // NroSocioColumn
            // 
            this.NroSocioColumn.HeaderText = "NroSocio";
            this.NroSocioColumn.Name = "NroSocioColumn";
            this.NroSocioColumn.ReadOnly = true;
            // 
            // DniColumn
            // 
            this.DniColumn.HeaderText = "Documento";
            this.DniColumn.Name = "DniColumn";
            this.DniColumn.ReadOnly = true;
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 191);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSocios";
            this.Text = "frmSocios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel AgregartoolStripLabel;
        private System.Windows.Forms.ToolStripLabel EditartoolStripLabel;
        private System.Windows.Forms.ToolStripLabel BorrartoolStripLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroSocioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniColumn;
    }
}