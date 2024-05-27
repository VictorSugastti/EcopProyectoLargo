namespace Ecop2.Vista
{
    partial class ListadoPedido
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
            this.lblListaPedido = new System.Windows.Forms.Label();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaPedido
            // 
            this.lblListaPedido.AutoSize = true;
            this.lblListaPedido.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPedido.Location = new System.Drawing.Point(430, 20);
            this.lblListaPedido.Name = "lblListaPedido";
            this.lblListaPedido.Size = new System.Drawing.Size(270, 40);
            this.lblListaPedido.TabIndex = 0;
            this.lblListaPedido.Text = "Lista de Pedidos";
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Location = new System.Drawing.Point(18, 78);
            this.dgvListaPedidos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.RowHeadersWidth = 51;
            this.dgvListaPedidos.RowTemplate.Height = 24;
            this.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPedidos.Size = new System.Drawing.Size(1148, 573);
            this.dgvListaPedidos.TabIndex = 1;
            // 
            // ListadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1178, 678);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.lblListaPedido);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ListadoPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListadoPedido";
            this.Load += new System.EventHandler(this.ListadoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaPedido;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
    }
}