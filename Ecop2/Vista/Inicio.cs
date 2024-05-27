using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecop2.Vista
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            SeleccionPedido pedido = new SeleccionPedido();
            pedido.Show();
        }
    }
}
