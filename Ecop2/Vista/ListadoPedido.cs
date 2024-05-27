using Ecop2.Controlador;
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
    public partial class ListadoPedido : Form
    {
        public ListadoPedido()
        {
            InitializeComponent();
        }

        private void ListadoPedido_Load(object sender, EventArgs e)
        {
            ControlPedido controlPedido = new ControlPedido();
            dgvListaPedidos.DataSource = controlPedido.ListarPedido();
        }
    }
}
