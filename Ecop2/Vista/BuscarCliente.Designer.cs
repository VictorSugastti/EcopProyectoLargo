namespace Ecop2.Vista
{
    partial class BuscarCliente
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
            this.dgvBuscarCliente = new System.Windows.Forms.DataGridView();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.txtNroDocBuscar = new System.Windows.Forms.TextBox();
            this.lblNroDocBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarCliente
            // 
            this.dgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCliente.Location = new System.Drawing.Point(2, 63);
            this.dgvBuscarCliente.Name = "dgvBuscarCliente";
            this.dgvBuscarCliente.RowHeadersWidth = 51;
            this.dgvBuscarCliente.RowTemplate.Height = 24;
            this.dgvBuscarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarCliente.Size = new System.Drawing.Size(894, 418);
            this.dgvBuscarCliente.TabIndex = 0;
            this.dgvBuscarCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarCliente_CellClick);
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBuscar.Location = new System.Drawing.Point(378, 20);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(111, 19);
            this.lblNombreBuscar.TabIndex = 1;
            this.lblNombreBuscar.Text = "Razón Social";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(499, 13);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(396, 31);
            this.txtNombreBuscar.TabIndex = 2;
            this.txtNombreBuscar.TextChanged += new System.EventHandler(this.txtNombreBuscar_TextChanged);
            // 
            // txtNroDocBuscar
            // 
            this.txtNroDocBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocBuscar.Location = new System.Drawing.Point(157, 16);
            this.txtNroDocBuscar.Name = "txtNroDocBuscar";
            this.txtNroDocBuscar.Size = new System.Drawing.Size(212, 27);
            this.txtNroDocBuscar.TabIndex = 4;
            this.txtNroDocBuscar.TextChanged += new System.EventHandler(this.txtNroDocBuscar_TextChanged);
            // 
            // lblNroDocBuscar
            // 
            this.lblNroDocBuscar.AutoSize = true;
            this.lblNroDocBuscar.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroDocBuscar.Location = new System.Drawing.Point(6, 20);
            this.lblNroDocBuscar.Name = "lblNroDocBuscar";
            this.lblNroDocBuscar.Size = new System.Drawing.Size(138, 19);
            this.lblNroDocBuscar.TabIndex = 3;
            this.lblNroDocBuscar.Text = "Nro. Documento";
            // 
            // BuscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(907, 493);
            this.Controls.Add(this.txtNroDocBuscar);
            this.Controls.Add(this.lblNroDocBuscar);
            this.Controls.Add(this.txtNombreBuscar);
            this.Controls.Add(this.lblNombreBuscar);
            this.Controls.Add(this.dgvBuscarCliente);
            this.Name = "BuscarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCliente";
            this.Load += new System.EventHandler(this.BuscarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarCliente;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.TextBox txtNroDocBuscar;
        private System.Windows.Forms.Label lblNroDocBuscar;
    }
}