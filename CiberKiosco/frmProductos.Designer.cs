namespace CiberKiosco
{
    partial class frmProductos
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
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProductoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(458, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregartoolStripLabel
            // 
            this.AgregartoolStripLabel.Name = "AgregartoolStripLabel";
            this.AgregartoolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.AgregartoolStripLabel.Text = "Agregar";
            this.AgregartoolStripLabel.Click += new System.EventHandler(this.AgregartoolStripLabel_Click);
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
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NombreProductoColumn,
            this.PrecioColumn,
            this.CantidadColumn});
            this.dataGridViewProductos.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(442, 410);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "IdProducto";
            this.IdColumn.Name = "IdColumn";
            // 
            // NombreProductoColumn
            // 
            this.NombreProductoColumn.HeaderText = "Nombre Producto";
            this.NombreProductoColumn.Name = "NombreProductoColumn";
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.HeaderText = "Precio";
            this.PrecioColumn.Name = "PrecioColumn";
            // 
            // CantidadColumn
            // 
            this.CantidadColumn.HeaderText = "Cantidad";
            this.CantidadColumn.Name = "CantidadColumn";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 440);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProductoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadColumn;
        private System.Windows.Forms.ToolStripLabel AgregartoolStripLabel;
        private System.Windows.Forms.ToolStripLabel EditartoolStripLabel;
        private System.Windows.Forms.ToolStripLabel BorrartoolStripLabel;
    }
}