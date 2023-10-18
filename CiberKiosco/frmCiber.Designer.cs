namespace CiberKiosco
{
    partial class frmCiber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CiberdataGridView = new System.Windows.Forms.DataGridView();
            this.ComputadoraColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HoraInicioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFinColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoClienteColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CiberdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CiberdataGridView
            // 
            this.CiberdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CiberdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ComputadoraColumn,
            this.EstadoColumn,
            this.HoraInicioColumn,
            this.HoraFinColumn,
            this.PrecioColumn,
            this.TipoClienteColumn});
            this.CiberdataGridView.Location = new System.Drawing.Point(0, 12);
            this.CiberdataGridView.Name = "CiberdataGridView";
            this.CiberdataGridView.Size = new System.Drawing.Size(643, 350);
            this.CiberdataGridView.TabIndex = 0;
            this.CiberdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CiberdataGridView_CellContentClick);
            // 
            // ComputadoraColumn
            // 
            this.ComputadoraColumn.HeaderText = "Computadora";
            this.ComputadoraColumn.Name = "ComputadoraColumn";
            // 
            // EstadoColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EstadoColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.EstadoColumn.HeaderText = "Estado";
            this.EstadoColumn.Name = "EstadoColumn";
            this.EstadoColumn.Text = "Empezar";
            this.EstadoColumn.ToolTipText = "Empezar";
            this.EstadoColumn.UseColumnTextForButtonValue = true;
            // 
            // HoraInicioColumn
            // 
            this.HoraInicioColumn.HeaderText = "Hora Inicio";
            this.HoraInicioColumn.Name = "HoraInicioColumn";
            // 
            // HoraFinColumn
            // 
            this.HoraFinColumn.HeaderText = "Hora Fin";
            this.HoraFinColumn.Name = "HoraFinColumn";
            // 
            // PrecioColumn
            // 
            this.PrecioColumn.HeaderText = "Precio";
            this.PrecioColumn.Name = "PrecioColumn";
            this.PrecioColumn.ReadOnly = true;
            // 
            // TipoClienteColumn
            // 
            this.TipoClienteColumn.HeaderText = "TipoCliente";
            this.TipoClienteColumn.Name = "TipoClienteColumn";
            // 
            // frmCiber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 362);
            this.Controls.Add(this.CiberdataGridView);
            this.Name = "frmCiber";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CiberdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CiberdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComputadoraColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EstadoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicioColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFinColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoClienteColumn;
    }
}