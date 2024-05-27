namespace Ecop2.Vista
{
    partial class Pedido
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
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.txtProductoIdPed = new System.Windows.Forms.TextBox();
            this.dateFechaEnt = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEnt = new System.Windows.Forms.Label();
            this.dateFechaEmi = new System.Windows.Forms.DateTimePicker();
            this.txtNroPed = new System.Windows.Forms.TextBox();
            this.lblNroPed = new System.Windows.Forms.Label();
            this.lblPedido = new System.Windows.Forms.Label();
            this.txtNroTelPed = new System.Windows.Forms.TextBox();
            this.lblNroTelPed = new System.Windows.Forms.Label();
            this.lblFechaEmi = new System.Windows.Forms.Label();
            this.txtNroDocPed = new System.Windows.Forms.TextBox();
            this.lblNroDocPed = new System.Windows.Forms.Label();
            this.txtDireccionPed = new System.Windows.Forms.TextBox();
            this.lblDireccionPed = new System.Windows.Forms.Label();
            this.txtIdClientePed = new System.Windows.Forms.TextBox();
            this.txtNombrePed = new System.Windows.Forms.TextBox();
            this.lblNombrePed = new System.Windows.Forms.Label();
            this.gbProductoPed = new System.Windows.Forms.GroupBox();
            this.txtPrecioPed = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidadPed = new System.Windows.Forms.TextBox();
            this.lblCantidadPed = new System.Windows.Forms.Label();
            this.txtDescripcionPed = new System.Windows.Forms.TextBox();
            this.txtCodigoPed = new System.Windows.Forms.TextBox();
            this.lblDescripcionPed = new System.Windows.Forms.Label();
            this.lblCodigoPed = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.txtCantidadTotalPed = new System.Windows.Forms.TextBox();
            this.lblCantidadTotalPed = new System.Windows.Forms.Label();
            this.txtMontoTotalPed = new System.Windows.Forms.TextBox();
            this.lblMontoTotalPed = new System.Windows.Forms.Label();
            this.btnGuardarPed = new System.Windows.Forms.Button();
            this.btnCancelarPed = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gbPedido.SuspendLayout();
            this.gbProductoPed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPedido
            // 
            this.gbPedido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbPedido.Controls.Add(this.txtProductoIdPed);
            this.gbPedido.Controls.Add(this.dateFechaEnt);
            this.gbPedido.Controls.Add(this.lblFechaEnt);
            this.gbPedido.Controls.Add(this.dateFechaEmi);
            this.gbPedido.Controls.Add(this.txtNroPed);
            this.gbPedido.Controls.Add(this.lblNroPed);
            this.gbPedido.Controls.Add(this.lblPedido);
            this.gbPedido.Controls.Add(this.txtNroTelPed);
            this.gbPedido.Controls.Add(this.lblNroTelPed);
            this.gbPedido.Controls.Add(this.lblFechaEmi);
            this.gbPedido.Controls.Add(this.txtNroDocPed);
            this.gbPedido.Controls.Add(this.lblNroDocPed);
            this.gbPedido.Controls.Add(this.txtDireccionPed);
            this.gbPedido.Controls.Add(this.lblDireccionPed);
            this.gbPedido.Controls.Add(this.txtIdClientePed);
            this.gbPedido.Controls.Add(this.txtNombrePed);
            this.gbPedido.Controls.Add(this.lblNombrePed);
            this.gbPedido.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedido.Location = new System.Drawing.Point(15, 15);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(1456, 179);
            this.gbPedido.TabIndex = 2;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Datos Pedido";
            // 
            // txtProductoIdPed
            // 
            this.txtProductoIdPed.Enabled = false;
            this.txtProductoIdPed.Location = new System.Drawing.Point(1293, 128);
            this.txtProductoIdPed.Name = "txtProductoIdPed";
            this.txtProductoIdPed.ReadOnly = true;
            this.txtProductoIdPed.Size = new System.Drawing.Size(115, 27);
            this.txtProductoIdPed.TabIndex = 28;
            this.txtProductoIdPed.Visible = false;
            // 
            // dateFechaEnt
            // 
            this.dateFechaEnt.Location = new System.Drawing.Point(775, 128);
            this.dateFechaEnt.Name = "dateFechaEnt";
            this.dateFechaEnt.Size = new System.Drawing.Size(322, 27);
            this.dateFechaEnt.TabIndex = 27;
            // 
            // lblFechaEnt
            // 
            this.lblFechaEnt.AutoSize = true;
            this.lblFechaEnt.Location = new System.Drawing.Point(614, 134);
            this.lblFechaEnt.Name = "lblFechaEnt";
            this.lblFechaEnt.Size = new System.Drawing.Size(123, 19);
            this.lblFechaEnt.TabIndex = 26;
            this.lblFechaEnt.Text = "Fecha Entrega";
            // 
            // dateFechaEmi
            // 
            this.dateFechaEmi.Enabled = false;
            this.dateFechaEmi.Location = new System.Drawing.Point(179, 128);
            this.dateFechaEmi.Name = "dateFechaEmi";
            this.dateFechaEmi.Size = new System.Drawing.Size(365, 27);
            this.dateFechaEmi.TabIndex = 25;
            // 
            // txtNroPed
            // 
            this.txtNroPed.Enabled = false;
            this.txtNroPed.Location = new System.Drawing.Point(1197, 80);
            this.txtNroPed.Name = "txtNroPed";
            this.txtNroPed.ReadOnly = true;
            this.txtNroPed.Size = new System.Drawing.Size(115, 27);
            this.txtNroPed.TabIndex = 24;
            // 
            // lblNroPed
            // 
            this.lblNroPed.AutoSize = true;
            this.lblNroPed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroPed.Location = new System.Drawing.Point(1151, 80);
            this.lblNroPed.Name = "lblNroPed";
            this.lblNroPed.Size = new System.Drawing.Size(32, 24);
            this.lblNroPed.TabIndex = 23;
            this.lblNroPed.Text = "N°";
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPedido.Location = new System.Drawing.Point(1149, 30);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(219, 33);
            this.lblPedido.TabIndex = 22;
            this.lblPedido.Text = "Nota de Pedido";
            // 
            // txtNroTelPed
            // 
            this.txtNroTelPed.Location = new System.Drawing.Point(761, 77);
            this.txtNroTelPed.Name = "txtNroTelPed";
            this.txtNroTelPed.Size = new System.Drawing.Size(336, 27);
            this.txtNroTelPed.TabIndex = 20;
            // 
            // lblNroTelPed
            // 
            this.lblNroTelPed.AutoSize = true;
            this.lblNroTelPed.Location = new System.Drawing.Point(624, 80);
            this.lblNroTelPed.Name = "lblNroTelPed";
            this.lblNroTelPed.Size = new System.Drawing.Size(114, 19);
            this.lblNroTelPed.TabIndex = 21;
            this.lblNroTelPed.Text = "Nro. Teléfono";
            // 
            // lblFechaEmi
            // 
            this.lblFechaEmi.AutoSize = true;
            this.lblFechaEmi.Location = new System.Drawing.Point(18, 134);
            this.lblFechaEmi.Name = "lblFechaEmi";
            this.lblFechaEmi.Size = new System.Drawing.Size(123, 19);
            this.lblFechaEmi.TabIndex = 18;
            this.lblFechaEmi.Text = "Fecha Emisión";
            // 
            // txtNroDocPed
            // 
            this.txtNroDocPed.Location = new System.Drawing.Point(179, 30);
            this.txtNroDocPed.Name = "txtNroDocPed";
            this.txtNroDocPed.Size = new System.Drawing.Size(234, 27);
            this.txtNroDocPed.TabIndex = 4;
            this.txtNroDocPed.Click += new System.EventHandler(this.txtNroDocPed_Click);
            // 
            // lblNroDocPed
            // 
            this.lblNroDocPed.AutoSize = true;
            this.lblNroDocPed.Location = new System.Drawing.Point(18, 33);
            this.lblNroDocPed.Name = "lblNroDocPed";
            this.lblNroDocPed.Size = new System.Drawing.Size(138, 19);
            this.lblNroDocPed.TabIndex = 17;
            this.lblNroDocPed.Text = "Nro. Documento";
            // 
            // txtDireccionPed
            // 
            this.txtDireccionPed.Location = new System.Drawing.Point(125, 77);
            this.txtDireccionPed.Name = "txtDireccionPed";
            this.txtDireccionPed.Size = new System.Drawing.Size(447, 27);
            this.txtDireccionPed.TabIndex = 8;
            // 
            // lblDireccionPed
            // 
            this.lblDireccionPed.AutoSize = true;
            this.lblDireccionPed.Location = new System.Drawing.Point(18, 80);
            this.lblDireccionPed.Name = "lblDireccionPed";
            this.lblDireccionPed.Size = new System.Drawing.Size(83, 19);
            this.lblDireccionPed.TabIndex = 10;
            this.lblDireccionPed.Text = "Dirección";
            // 
            // txtIdClientePed
            // 
            this.txtIdClientePed.Enabled = false;
            this.txtIdClientePed.Location = new System.Drawing.Point(1144, 128);
            this.txtIdClientePed.Name = "txtIdClientePed";
            this.txtIdClientePed.ReadOnly = true;
            this.txtIdClientePed.Size = new System.Drawing.Size(115, 27);
            this.txtIdClientePed.TabIndex = 5;
            this.txtIdClientePed.Visible = false;
            // 
            // txtNombrePed
            // 
            this.txtNombrePed.Location = new System.Drawing.Point(610, 30);
            this.txtNombrePed.MaxLength = 200;
            this.txtNombrePed.Name = "txtNombrePed";
            this.txtNombrePed.Size = new System.Drawing.Size(487, 27);
            this.txtNombrePed.TabIndex = 6;
            // 
            // lblNombrePed
            // 
            this.lblNombrePed.AutoSize = true;
            this.lblNombrePed.Location = new System.Drawing.Point(461, 33);
            this.lblNombrePed.Name = "lblNombrePed";
            this.lblNombrePed.Size = new System.Drawing.Size(111, 19);
            this.lblNombrePed.TabIndex = 1;
            this.lblNombrePed.Text = "Razón Social";
            // 
            // gbProductoPed
            // 
            this.gbProductoPed.Controls.Add(this.txtPrecioPed);
            this.gbProductoPed.Controls.Add(this.lblPrecio);
            this.gbProductoPed.Controls.Add(this.txtCantidadPed);
            this.gbProductoPed.Controls.Add(this.lblCantidadPed);
            this.gbProductoPed.Controls.Add(this.txtDescripcionPed);
            this.gbProductoPed.Controls.Add(this.txtCodigoPed);
            this.gbProductoPed.Controls.Add(this.lblDescripcionPed);
            this.gbProductoPed.Controls.Add(this.lblCodigoPed);
            this.gbProductoPed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductoPed.Location = new System.Drawing.Point(15, 196);
            this.gbProductoPed.Name = "gbProductoPed";
            this.gbProductoPed.Size = new System.Drawing.Size(1456, 62);
            this.gbProductoPed.TabIndex = 3;
            this.gbProductoPed.TabStop = false;
            // 
            // txtPrecioPed
            // 
            this.txtPrecioPed.Location = new System.Drawing.Point(1220, 20);
            this.txtPrecioPed.MaxLength = 50;
            this.txtPrecioPed.Name = "txtPrecioPed";
            this.txtPrecioPed.Size = new System.Drawing.Size(213, 27);
            this.txtPrecioPed.TabIndex = 11;
            this.txtPrecioPed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioPed_KeyDown);
            this.txtPrecioPed.Leave += new System.EventHandler(this.txtPrecioPed_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(1137, 23);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 19);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // txtCantidadPed
            // 
            this.txtCantidadPed.Location = new System.Drawing.Point(956, 20);
            this.txtCantidadPed.MaxLength = 50;
            this.txtCantidadPed.Name = "txtCantidadPed";
            this.txtCantidadPed.Size = new System.Drawing.Size(155, 27);
            this.txtCantidadPed.TabIndex = 9;
            this.txtCantidadPed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPed_KeyPress);
            // 
            // lblCantidadPed
            // 
            this.lblCantidadPed.AutoSize = true;
            this.lblCantidadPed.Location = new System.Drawing.Point(857, 23);
            this.lblCantidadPed.Name = "lblCantidadPed";
            this.lblCantidadPed.Size = new System.Drawing.Size(79, 19);
            this.lblCantidadPed.TabIndex = 8;
            this.lblCantidadPed.Text = "Cantidad";
            // 
            // txtDescripcionPed
            // 
            this.txtDescripcionPed.Location = new System.Drawing.Point(443, 20);
            this.txtDescripcionPed.MaxLength = 200;
            this.txtDescripcionPed.Name = "txtDescripcionPed";
            this.txtDescripcionPed.Size = new System.Drawing.Size(383, 27);
            this.txtDescripcionPed.TabIndex = 7;
            // 
            // txtCodigoPed
            // 
            this.txtCodigoPed.Location = new System.Drawing.Point(101, 20);
            this.txtCodigoPed.MaxLength = 50;
            this.txtCodigoPed.Name = "txtCodigoPed";
            this.txtCodigoPed.Size = new System.Drawing.Size(191, 27);
            this.txtCodigoPed.TabIndex = 6;
            this.txtCodigoPed.Click += new System.EventHandler(this.txtCodigoPed_Click);
            // 
            // lblDescripcionPed
            // 
            this.lblDescripcionPed.AutoSize = true;
            this.lblDescripcionPed.Location = new System.Drawing.Point(319, 23);
            this.lblDescripcionPed.Name = "lblDescripcionPed";
            this.lblDescripcionPed.Size = new System.Drawing.Size(102, 19);
            this.lblDescripcionPed.TabIndex = 5;
            this.lblDescripcionPed.Text = "Descripción";
            // 
            // lblCodigoPed
            // 
            this.lblCodigoPed.AutoSize = true;
            this.lblCodigoPed.Location = new System.Drawing.Point(18, 23);
            this.lblCodigoPed.Name = "lblCodigoPed";
            this.lblCodigoPed.Size = new System.Drawing.Size(65, 19);
            this.lblCodigoPed.TabIndex = 4;
            this.lblCodigoPed.Text = "Código";
            // 
            // dgvPedido
            // 
            this.dgvPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(19, 265);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.RowTemplate.Height = 24;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(1452, 440);
            this.dgvPedido.TabIndex = 4;
            this.dgvPedido.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPedido_DataError);
            // 
            // txtCantidadTotalPed
            // 
            this.txtCantidadTotalPed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTotalPed.Location = new System.Drawing.Point(729, 736);
            this.txtCantidadTotalPed.Name = "txtCantidadTotalPed";
            this.txtCantidadTotalPed.Size = new System.Drawing.Size(191, 27);
            this.txtCantidadTotalPed.TabIndex = 18;
            // 
            // lblCantidadTotalPed
            // 
            this.lblCantidadTotalPed.AutoSize = true;
            this.lblCantidadTotalPed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTotalPed.Location = new System.Drawing.Point(463, 737);
            this.lblCantidadTotalPed.Name = "lblCantidadTotalPed";
            this.lblCantidadTotalPed.Size = new System.Drawing.Size(251, 24);
            this.lblCantidadTotalPed.TabIndex = 19;
            this.lblCantidadTotalPed.Text = "Cantidad Total Productos";
            // 
            // txtMontoTotalPed
            // 
            this.txtMontoTotalPed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotalPed.Location = new System.Drawing.Point(1111, 737);
            this.txtMontoTotalPed.Name = "txtMontoTotalPed";
            this.txtMontoTotalPed.Size = new System.Drawing.Size(327, 27);
            this.txtMontoTotalPed.TabIndex = 20;
            // 
            // lblMontoTotalPed
            // 
            this.lblMontoTotalPed.AutoSize = true;
            this.lblMontoTotalPed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotalPed.Location = new System.Drawing.Point(956, 737);
            this.lblMontoTotalPed.Name = "lblMontoTotalPed";
            this.lblMontoTotalPed.Size = new System.Drawing.Size(135, 24);
            this.lblMontoTotalPed.TabIndex = 21;
            this.lblMontoTotalPed.Text = "Total a Pagar";
            // 
            // btnGuardarPed
            // 
            this.btnGuardarPed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPed.Location = new System.Drawing.Point(1212, 788);
            this.btnGuardarPed.Name = "btnGuardarPed";
            this.btnGuardarPed.Size = new System.Drawing.Size(231, 45);
            this.btnGuardarPed.TabIndex = 26;
            this.btnGuardarPed.Text = "Guardar";
            this.btnGuardarPed.UseVisualStyleBackColor = true;
            this.btnGuardarPed.Click += new System.EventHandler(this.btnGuardarPed_Click);
            // 
            // btnCancelarPed
            // 
            this.btnCancelarPed.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPed.Location = new System.Drawing.Point(935, 788);
            this.btnCancelarPed.Name = "btnCancelarPed";
            this.btnCancelarPed.Size = new System.Drawing.Size(231, 45);
            this.btnCancelarPed.TabIndex = 27;
            this.btnCancelarPed.Text = "Cancelar";
            this.btnCancelarPed.UseVisualStyleBackColor = true;
            this.btnCancelarPed.Click += new System.EventHandler(this.btnCancelarPed_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::Ecop2.Properties.Resources.DeleteIco;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 700;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Editar";
            this.dataGridViewImageColumn2.Image = global::Ecop2.Properties.Resources.EditIco;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 699;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1486, 845);
            this.Controls.Add(this.btnCancelarPed);
            this.Controls.Add(this.btnGuardarPed);
            this.Controls.Add(this.txtMontoTotalPed);
            this.Controls.Add(this.lblMontoTotalPed);
            this.Controls.Add(this.txtCantidadTotalPed);
            this.Controls.Add(this.lblCantidadTotalPed);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.gbProductoPed);
            this.Controls.Add(this.gbPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pedido";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            this.gbProductoPed.ResumeLayout(false);
            this.gbProductoPed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox txtNroDocPed;
        private System.Windows.Forms.Label lblNroDocPed;
        private System.Windows.Forms.TextBox txtDireccionPed;
        private System.Windows.Forms.Label lblDireccionPed;
        private System.Windows.Forms.TextBox txtIdClientePed;
        private System.Windows.Forms.TextBox txtNombrePed;
        private System.Windows.Forms.Label lblNombrePed;
        private System.Windows.Forms.Label lblFechaEmi;
        private System.Windows.Forms.TextBox txtNroTelPed;
        private System.Windows.Forms.Label lblNroTelPed;
        private System.Windows.Forms.TextBox txtNroPed;
        private System.Windows.Forms.Label lblNroPed;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.DateTimePicker dateFechaEnt;
        private System.Windows.Forms.Label lblFechaEnt;
        private System.Windows.Forms.DateTimePicker dateFechaEmi;
        private System.Windows.Forms.GroupBox gbProductoPed;
        private System.Windows.Forms.TextBox txtPrecioPed;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidadPed;
        private System.Windows.Forms.Label lblCantidadPed;
        private System.Windows.Forms.TextBox txtDescripcionPed;
        private System.Windows.Forms.TextBox txtCodigoPed;
        private System.Windows.Forms.Label lblDescripcionPed;
        private System.Windows.Forms.Label lblCodigoPed;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.TextBox txtCantidadTotalPed;
        private System.Windows.Forms.Label lblCantidadTotalPed;
        private System.Windows.Forms.TextBox txtMontoTotalPed;
        private System.Windows.Forms.Label lblMontoTotalPed;
        private System.Windows.Forms.Button btnGuardarPed;
        private System.Windows.Forms.Button btnCancelarPed;
        private System.Windows.Forms.TextBox txtProductoIdPed;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}