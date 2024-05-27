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
    public partial class SeleccionPedido : Form
    {
        public SeleccionPedido()
        {
            InitializeComponent();
        }

        private void btnPedidoAltas_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Close();
        }

        private void btnListaPedido_Click(object sender, EventArgs e)
        {
            ListadoPedido pedido = new ListadoPedido();
            pedido.Show();
            this.Close();
        }
    }
}
