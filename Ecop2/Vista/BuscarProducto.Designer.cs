namespace Ecop2.Vista
{
    partial class BuscarProducto
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
            this.txtCodigoBuscar = new System.Windows.Forms.TextBox();
            this.lblCodigoBuscar = new System.Windows.Forms.Label();
            this.txtProductoBuscar = new System.Windows.Forms.TextBox();
            this.lblProductoBuscar = new System.Windows.Forms.Label();
            this.dgvBuscarProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoBuscar
            // 
            this.txtCodigoBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBuscar.Location = new System.Drawing.Point(94, 17);
            this.txtCodigoBuscar.Name = "txtCodigoBuscar";
            this.txtCodigoBuscar.Size = new System.Drawing.Size(237, 27);
            this.txtCodigoBuscar.TabIndex = 9;
            this.txtCodigoBuscar.TextChanged += new System.EventHandler(this.txtCodigoBuscar_TextChanged);
            // 
            // lblCodigoBuscar
            // 
            this.lblCodigoBuscar.AutoSize = true;
            this.lblCodigoBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoBuscar.Location = new System.Drawing.Point(8, 20);
            this.lblCodigoBuscar.Name = "lblCodigoBuscar";
            this.lblCodigoBuscar.Size = new System.Drawing.Size(65, 19);
            this.lblCodigoBuscar.TabIndex = 8;
            this.lblCodigoBuscar.Text = "Código";
            // 
            // txtProductoBuscar
            // 
            this.txtProductoBuscar.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoBuscar.Location = new System.Drawing.Point(461, 13);
            this.txtProductoBuscar.Name = "txtProductoBuscar";
            this.txtProductoBuscar.Size = new System.Drawing.Size(355, 31);
            this.txtProductoBuscar.TabIndex = 7;
            this.txtProductoBuscar.TextChanged += new System.EventHandler(this.txtProductoBuscar_TextChanged);
            // 
            // lblProductoBuscar
            // 
            this.lblProductoBuscar.AutoSize = true;
            this.lblProductoBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoBuscar.Location = new System.Drawing.Point(337, 19);
            this.lblProductoBuscar.Name = "lblProductoBuscar";
            this.lblProductoBuscar.Size = new System.Drawing.Size(102, 19);
            this.lblProductoBuscar.TabIndex = 6;
            this.lblProductoBuscar.Text = "Descripción";
            // 
            // dgvBuscarProducto
            // 
            this.dgvBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProducto.Location = new System.Drawing.Point(7, 56);
            this.dgvBuscarProducto.Name = "dgvBuscarProducto";
            this.dgvBuscarProducto.RowHeadersWidth = 51;
            this.dgvBuscarProducto.RowTemplate.Height = 24;
            this.dgvBuscarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarProducto.Size = new System.Drawing.Size(810, 431);
            this.dgvBuscarProducto.TabIndex = 5;
            this.dgvBuscarProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProducto_CellClick);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 490);
            this.Controls.Add(this.txtCodigoBuscar);
            this.Controls.Add(this.lblCodigoBuscar);
            this.Controls.Add(this.txtProductoBuscar);
            this.Controls.Add(this.lblProductoBuscar);
            this.Controls.Add(this.dgvBuscarProducto);
            this.Name = "BuscarProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProducto";
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoBuscar;
        private System.Windows.Forms.Label lblCodigoBuscar;
        private System.Windows.Forms.TextBox txtProductoBuscar;
        private System.Windows.Forms.Label lblProductoBuscar;
        private System.Windows.Forms.DataGridView dgvBuscarProducto;
    }
}