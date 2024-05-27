using Ecop2.Controlador;
using Ecop2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ecop2.Vista
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
            cargarNroPedido();
            DgvPedidoConf();

        }
        private void cargarNroPedido()
        {
            ControlPedido pd = new ControlPedido();
            int nropedido = pd.ObtenerNumeroPedido();
            if (nropedido > 0 )
            {
                txtNroPed.Text = nropedido.ToString();
            }
            else
            {
                MessageBox.Show("Error al cargar Formulario Pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void txtNroDocPed_Click(object sender, EventArgs e)
        {
            BuscarCliente cliente = new BuscarCliente();
            cliente.ClienteSeleccionado += ClienteSeleccionadoHandler;
            cliente.Show();
        }
        private void ClienteSeleccionadoHandler(string clienteId, string razonSocial, string nroDocumento, string direccion, string telefono)
        {
            txtIdClientePed.Text = clienteId;
            txtNroDocPed.Text = nroDocumento;
            txtNombrePed.Text = razonSocial;
            txtDireccionPed.Text = direccion;
            txtNroTelPed.Text = telefono;
        }

        private void txtCodigoPed_Click(object sender, EventArgs e)
        {
            BuscarProducto producto = new BuscarProducto();
            producto.ProductoSeleccionado += ProductoSeleccionadoHandler;
            producto.Show();
        }
        private void ProductoSeleccionadoHandler(string productoId, string codigo, string descripcion, string precio)
        {
            txtProductoIdPed.Text = productoId;
            txtCodigoPed.Text = codigo;
            txtDescripcionPed.Text = descripcion;
            txtPrecioPed.Text = precio;
        }

        private void txtPrecioPed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                VerificarCamposProducto();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void txtPrecioPed_Leave(object sender, EventArgs e)
        {
            VerificarCamposProducto();
        }
        private void VerificarCamposProducto()
        {
            string codigo = txtCodigoPed.Text;
            string cantidad = txtCantidadPed.Text;
            string precio = txtPrecioPed.Text;
            string descripcion = txtDescripcionPed.Text;
            int idproducto = Convert.ToInt32(txtProductoIdPed.Text);

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Debe ingresar un código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cantidad))
            {
                MessageBox.Show("Debe ingresar cantidad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(precio))
            {
                MessageBox.Show("Debe ingresar un precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal precioDecimal;
            int cantidadInt;
            if (!decimal.TryParse(precio, out precioDecimal))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            if (!int.TryParse(cantidad, out cantidadInt))
            {
                MessageBox.Show("La cantidad debe ser un número entero válido.");
                return;
            }

            decimal subtotal = Convert.ToDecimal(precio) * Convert.ToInt32(cantidad);
            dgvPedido.Rows.Add(idproducto, codigo, descripcion, precio, cantidad, subtotal);
            limpiarProducto();
            ActualizarTotales();
        }
        private void DgvPedidoConf()
        {
            dgvPedido.Columns.Add("ProductoId", "Producto Id");
            dgvPedido.Columns.Add("Codigo", "Código Producto");         
            dgvPedido.Columns.Add("Producto", "Descripcion");
            dgvPedido.Columns.Add("Precio", "Precio Unitario");
            dgvPedido.Columns.Add("Cantidad", "Cantidad");
            dgvPedido.Columns.Add("Sub_Total", "Sub Total");
        }
        private void limpiarProducto()
        {
            txtCodigoPed.Clear();
            txtDescripcionPed.Clear();
            txtCantidadPed.Clear();
            txtPrecioPed.Clear();
            txtProductoIdPed.Clear();
        }
        private void ActualizarTotales()
        {
            int totalCantidad = 0;
            decimal totalPrecio = 0;

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                int cantidad;
                if (int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad))
                {
                    decimal total = 0;
                    if (decimal.TryParse(row.Cells["Sub_Total"].Value?.ToString(), out decimal subTotal))
                    {
                        total = subTotal;
                    }
                    totalCantidad += cantidad;
                    totalPrecio += total;
                }
                else
                {
                    continue;
                }
            }

            txtCantidadTotalPed.Text = totalCantidad.ToString();
            txtMontoTotalPed.Text = totalPrecio.ToString("0.00");
        }
        private void btnCancelarPed_Click(object sender, EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Se vaciarán todos los campos, ¿esta seguro?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cancelar == DialogResult.OK)
            {               
                LimpiarCamposPedido();
            }
        }
        private void LimpiarCamposPedido()
        {
            txtIdClientePed.Clear();
            txtNroDocPed.Clear();
            txtNombrePed.Clear();
            txtDireccionPed.Clear();
            txtNroTelPed.Clear();
            dgvPedido.Rows.Clear();
            txtCantidadTotalPed.Clear();
            txtMontoTotalPed.Clear();
            limpiarProducto();
        }

        private void btnGuardarPed_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(txtIdClientePed.Text);
            string razonsocial = txtNombrePed.Text;
            string nrodoc = txtNroDocPed.Text;

            double cantidadtotal = Convert.ToDouble(txtCantidadTotalPed.Text);
            decimal preciototal = Convert.ToDecimal(txtMontoTotalPed.Text);

            DateTime fechaEntrega;
            if (!DateTime.TryParse(dateFechaEmi.Text, out fechaEntrega))
            {
                MessageBox.Show("La fecha de entrega debe ser una fecha válida.");
                return;
            }

            if (string.IsNullOrEmpty(nrodoc))
            {
                MessageBox.Show("Debe ingresar el Número de Documento del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(razonsocial))
            {
                MessageBox.Show("Debe ingresar la Razón Social del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cantidadtotal == 0 && preciototal == 0)
            {
                MessageBox.Show("Debe agregar un producto para poder registrar el Pedido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ControlPedido pedidoDAO = new ControlPedido();
            int pedidoId = pedidoDAO.AgregarPedidoCabecera(clienteId, cantidadtotal, preciototal, fechaEntrega);

            if (pedidoId == 0)
            {
                MessageBox.Show("No se ha podido insertar correctamente el pedido, verifique", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimpiarCamposPedido();
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        int productoId = Convert.ToInt32(row.Cells["ProductoId"].Value.ToString());
                        decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                        double cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        pedidoDAO.AgregarPedidoDetalle(pedidoId, productoId, precio, cantidad);
                    }
                }
                MessageBox.Show("Pedido registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposPedido();
                cargarNroPedido();
            }

        }

        private void txtCantidadPed_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlPedido cp = new ControlPedido();
            int id = Convert.ToInt32(txtProductoIdPed.Text);
            double cantidadActual = cp.ControlCantidad(id);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (!string.IsNullOrEmpty(txtCantidadPed.Text))
            {
                string nuevoValor = txtCantidadPed.Text + e.KeyChar;
                double nuevoValorNumeric = double.Parse(nuevoValor);

                if (nuevoValorNumeric > cantidadActual)
                {
                    MessageBox.Show("La cantidad ingresada supera la cantidad disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidadPed.Text = "";
                    e.Handled = true;
                }
            }
        }

        private void dgvPedido_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error en los datos: " + e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
