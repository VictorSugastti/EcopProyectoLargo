namespace Ecop2.Vista
{
    partial class Cliente
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
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnAgregarCli = new System.Windows.Forms.Button();
            this.btnEliminarCli = new System.Windows.Forms.Button();
            this.btnModificarCli = new System.Windows.Forms.Button();
            this.txtNroTel = new System.Windows.Forms.TextBox();
            this.lblNroTel = new System.Windows.Forms.Label();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbCliente.Controls.Add(this.txtBarrio);
            this.gbCliente.Controls.Add(this.lblBarrio);
            this.gbCliente.Controls.Add(this.txtCiudad);
            this.gbCliente.Controls.Add(this.lblCiudad);
            this.gbCliente.Controls.Add(this.lblCorreo);
            this.gbCliente.Controls.Add(this.txtNroDoc);
            this.gbCliente.Controls.Add(this.cbTipoDoc);
            this.gbCliente.Controls.Add(this.btnAgregarCli);
            this.gbCliente.Controls.Add(this.btnEliminarCli);
            this.gbCliente.Controls.Add(this.btnModificarCli);
            this.gbCliente.Controls.Add(this.txtNroTel);
            this.gbCliente.Controls.Add(this.lblNroTel);
            this.gbCliente.Controls.Add(this.lblNroDoc);
            this.gbCliente.Controls.Add(this.txtDireccion);
            this.gbCliente.Controls.Add(this.lblDireccion);
            this.gbCliente.Controls.Add(this.txtIdCliente);
            this.gbCliente.Controls.Add(this.lblIdCliente);
            this.gbCliente.Controls.Add(this.txtNombre);
            this.gbCliente.Controls.Add(this.txtCorreo);
            this.gbCliente.Controls.Add(this.lblNombre);
            this.gbCliente.Controls.Add(this.lblTipoDoc);
            this.gbCliente.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(11, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(1095, 306);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Datos del Cliente";
            this.gbCliente.Enter += new System.EventHandler(this.gbCliente_Enter);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(673, 181);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(399, 27);
            this.txtBarrio.TabIndex = 11;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(586, 184);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(58, 19);
            this.lblBarrio.TabIndex = 30;
            this.lblBarrio.Text = "Barrio";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(125, 181);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(427, 27);
            this.txtCiudad.TabIndex = 10;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(18, 184);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(64, 19);
            this.lblCiudad.TabIndex = 29;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(596, 135);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(158, 19);
            this.lblCorreo.TabIndex = 26;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(548, 33);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(276, 27);
            this.txtNroDoc.TabIndex = 4;
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Location = new System.Drawing.Point(188, 33);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(168, 27);
            this.cbTipoDoc.TabIndex = 24;
            // 
            // btnAgregarCli
            // 
            this.btnAgregarCli.Location = new System.Drawing.Point(909, 243);
            this.btnAgregarCli.Name = "btnAgregarCli";
            this.btnAgregarCli.Size = new System.Drawing.Size(137, 45);
            this.btnAgregarCli.TabIndex = 12;
            this.btnAgregarCli.Text = "Agregar";
            this.btnAgregarCli.UseVisualStyleBackColor = true;
            this.btnAgregarCli.Click += new System.EventHandler(this.btnAgregarCli_Click);
            // 
            // btnEliminarCli
            // 
            this.btnEliminarCli.Enabled = false;
            this.btnEliminarCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarCli.Location = new System.Drawing.Point(573, 243);
            this.btnEliminarCli.Name = "btnEliminarCli";
            this.btnEliminarCli.Size = new System.Drawing.Size(137, 45);
            this.btnEliminarCli.TabIndex = 22;
            this.btnEliminarCli.Text = "Eliminar";
            this.btnEliminarCli.UseVisualStyleBackColor = true;
            this.btnEliminarCli.Click += new System.EventHandler(this.btnEliminarCli_Click);
            // 
            // btnModificarCli
            // 
            this.btnModificarCli.Enabled = false;
            this.btnModificarCli.Location = new System.Drawing.Point(740, 243);
            this.btnModificarCli.Name = "btnModificarCli";
            this.btnModificarCli.Size = new System.Drawing.Size(137, 45);
            this.btnModificarCli.TabIndex = 21;
            this.btnModificarCli.Text = "Modificar";
            this.btnModificarCli.UseVisualStyleBackColor = true;
            this.btnModificarCli.Click += new System.EventHandler(this.btnModificarCli_Click);
            // 
            // txtNroTel
            // 
            this.txtNroTel.Location = new System.Drawing.Point(833, 79);
            this.txtNroTel.Name = "txtNroTel";
            this.txtNroTel.Size = new System.Drawing.Size(239, 27);
            this.txtNroTel.TabIndex = 7;
            // 
            // lblNroTel
            // 
            this.lblNroTel.AutoSize = true;
            this.lblNroTel.Location = new System.Drawing.Point(696, 82);
            this.lblNroTel.Name = "lblNroTel";
            this.lblNroTel.Size = new System.Drawing.Size(114, 19);
            this.lblNroTel.TabIndex = 19;
            this.lblNroTel.Text = "Nro. Teléfono";
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(387, 36);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(138, 19);
            this.lblNroDoc.TabIndex = 17;
            this.lblNroDoc.Text = "Nro. Documento";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(125, 132);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(447, 27);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(18, 135);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(83, 19);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(954, 33);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(115, 27);
            this.txtIdCliente.TabIndex = 5;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(843, 36);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(82, 19);
            this.lblIdCliente.TabIndex = 8;
            this.lblIdCliente.Text = "Id Cliente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(167, 80);
            this.txtNombre.MaxLength = 200;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(487, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(787, 132);
            this.txtCorreo.MaxLength = 50;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(285, 27);
            this.txtCorreo.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(18, 83);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(111, 19);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Razón Social";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(18, 36);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(138, 19);
            this.lblTipoDoc.TabIndex = 0;
            this.lblTipoDoc.Text = "Tipo Documento";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 324);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1094, 449);
            this.dgvClientes.TabIndex = 2;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 782);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbCliente);
            this.Name = "Cliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.Button btnAgregarCli;
        private System.Windows.Forms.Button btnEliminarCli;
        private System.Windows.Forms.Button btnModificarCli;
        private System.Windows.Forms.TextBox txtNroTel;
        private System.Windows.Forms.Label lblNroTel;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.DataGridView dgvClientes;
    }
}