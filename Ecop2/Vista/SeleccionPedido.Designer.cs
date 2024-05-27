namespace Ecop2.Vista
{
    partial class SeleccionPedido
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
            this.btnListaPedido = new System.Windows.Forms.Button();
            this.btnPedidoAltas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListaPedido
            // 
            this.btnListaPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPedido.Location = new System.Drawing.Point(86, 86);
            this.btnListaPedido.Name = "btnListaPedido";
            this.btnListaPedido.Size = new System.Drawing.Size(231, 82);
            this.btnListaPedido.TabIndex = 31;
            this.btnListaPedido.Text = "Lista de Pedidos";
            this.btnListaPedido.UseVisualStyleBackColor = true;
            this.btnListaPedido.Click += new System.EventHandler(this.btnListaPedido_Click);
            // 
            // btnPedidoAltas
            // 
            this.btnPedidoAltas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoAltas.Location = new System.Drawing.Point(353, 86);
            this.btnPedidoAltas.Name = "btnPedidoAltas";
            this.btnPedidoAltas.Size = new System.Drawing.Size(231, 82);
            this.btnPedidoAltas.TabIndex = 30;
            this.btnPedidoAltas.Text = "Cargar Pedido";
            this.btnPedidoAltas.UseVisualStyleBackColor = true;
            this.btnPedidoAltas.Click += new System.EventHandler(this.btnPedidoAltas_Click);
            // 
            // SeleccionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 249);
            this.Controls.Add(this.btnListaPedido);
            this.Controls.Add(this.btnPedidoAltas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SeleccionPedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionPedido";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListaPedido;
        private System.Windows.Forms.Button btnPedidoAltas;
    }
}