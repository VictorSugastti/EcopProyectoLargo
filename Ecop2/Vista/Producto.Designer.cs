namespace Ecop2.Vista
{
    partial class Producto
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
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.cbUniMed = new System.Windows.Forms.ComboBox();
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.btnEliminarPro = new System.Windows.Forms.Button();
            this.btnModificarPro = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidadMedida = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProducto
            // 
            this.gbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gbProducto.Controls.Add(this.cbUniMed);
            this.gbProducto.Controls.Add(this.btnAgregarPro);
            this.gbProducto.Controls.Add(this.btnEliminarPro);
            this.gbProducto.Controls.Add(this.btnModificarPro);
            this.gbProducto.Controls.Add(this.txtCantidad);
            this.gbProducto.Controls.Add(this.lblCantidad);
            this.gbProducto.Controls.Add(this.lblUnidadMedida);
            this.gbProducto.Controls.Add(this.txtPrecio1);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.txtId);
            this.gbProducto.Controls.Add(this.lblIdProducto);
            this.gbProducto.Controls.Add(this.txtDescripcion);
            this.gbProducto.Controls.Add(this.txtCodigo);
            this.gbProducto.Controls.Add(this.lblDescripcion);
            this.gbProducto.Controls.Add(this.lblCodigo);
            this.gbProducto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProducto.Location = new System.Drawing.Point(12, 10);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(1093, 262);
            this.gbProducto.TabIndex = 0;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Carga de  Producto";
            this.gbProducto.Enter += new System.EventHandler(this.gbProducto_Enter);
            // 
            // cbUniMed
            // 
            this.cbUniMed.FormattingEnabled = true;
            this.cbUniMed.Location = new System.Drawing.Point(175, 77);
            this.cbUniMed.Name = "cbUniMed";
            this.cbUniMed.Size = new System.Drawing.Size(206, 27);
            this.cbUniMed.TabIndex = 24;
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.Location = new System.Drawing.Point(916, 197);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Size = new System.Drawing.Size(137, 45);
            this.btnAgregarPro.TabIndex = 23;
            this.btnAgregarPro.Text = "Agregar";
            this.btnAgregarPro.UseVisualStyleBackColor = true;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // btnEliminarPro
            // 
            this.btnEliminarPro.Enabled = false;
            this.btnEliminarPro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarPro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPro.Location = new System.Drawing.Point(580, 197);
            this.btnEliminarPro.Name = "btnEliminarPro";
            this.btnEliminarPro.Size = new System.Drawing.Size(137, 45);
            this.btnEliminarPro.TabIndex = 22;
            this.btnEliminarPro.Text = "Eliminar";
            this.btnEliminarPro.UseVisualStyleBackColor = true;
            this.btnEliminarPro.Click += new System.EventHandler(this.btnEliminarPro_Click);
            // 
            // btnModificarPro
            // 
            this.btnModificarPro.Enabled = false;
            this.btnModificarPro.Location = new System.Drawing.Point(747, 197);
            this.btnModificarPro.Name = "btnModificarPro";
            this.btnModificarPro.Size = new System.Drawing.Size(137, 45);
            this.btnModificarPro.TabIndex = 21;
            this.btnModificarPro.Text = "Modificar";
            this.btnModificarPro.UseVisualStyleBackColor = true;
            this.btnModificarPro.Click += new System.EventHandler(this.btnModificarPro_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(504, 82);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(256, 27);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(406, 85);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(79, 19);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.Location = new System.Drawing.Point(18, 85);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(124, 19);
            this.lblUnidadMedida.TabIndex = 17;
            this.lblUnidadMedida.Text = "Unidad Medida";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(116, 138);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(266, 27);
            this.txtPrecio1.TabIndex = 6;
            this.txtPrecio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio1_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(18, 141);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(59, 19);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(906, 82);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(134, 27);
            this.txtId.TabIndex = 5;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(783, 85);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(101, 19);
            this.lblIdProducto.TabIndex = 8;
            this.lblIdProducto.Text = "Id Producto";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(540, 33);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(513, 27);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(116, 33);
            this.txtCodigo.MaxLength = 50;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(256, 27);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(406, 36);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(102, 19);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(9, 280);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1093, 449);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 735);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.gbProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Producto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblUnidadMedida;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Button btnEliminarPro;
        private System.Windows.Forms.Button btnModificarPro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cbUniMed;
    }
}