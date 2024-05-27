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

namespace Ecop2.Vista
{
    public partial class BuscarProducto : Form
    {
        public BuscarProducto()
        {
            InitializeComponent();
        }
        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            ControlProducto pr = new ControlProducto();
            dgvBuscarProducto.DataSource = pr.ListarProducto();
        }
        public delegate void ProductoSeleccionadoHandler(string productoId, string codigo, string descripcion, string precio);
        public event ProductoSeleccionadoHandler ProductoSeleccionado;
        private void dgvBuscarProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1 || dgvBuscarProducto.SelectedCells[0].Value.ToString() == "")
            {

            }
            else
            {
                string productoId = dgvBuscarProducto.SelectedCells[0].Value.ToString();
                string codigo = dgvBuscarProducto.SelectedCells[1].Value.ToString();
                string descripcion = dgvBuscarProducto.SelectedCells[2].Value.ToString();
                string precio = dgvBuscarProducto.SelectedCells[4].Value.ToString();

                ProductoSeleccionado?.Invoke(productoId, codigo, descripcion, precio);
                this.Close();
            }
        }
        private void FiltrarProductos(string codigo, string descripcion)
        {
            string filtro = "";
            if (!string.IsNullOrEmpty(codigo))
            {
                filtro += $"CODIGO LIKE '%{codigo}%'";
            }
            if (!string.IsNullOrEmpty(descripcion))
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro += " OR ";
                }
                filtro += $"DESCRIPCION LIKE '%{descripcion}%'";
            }
            if (dgvBuscarProducto.DataSource != null)
            {
                List<PRODUCTO> prod = dgvBuscarProducto.DataSource as List<PRODUCTO>;

                if (prod != null)
                {
                    if (string.IsNullOrEmpty(codigo) && string.IsNullOrEmpty(descripcion))
                    {
                        ControlProducto pr = new ControlProducto();
                        dgvBuscarProducto.DataSource = pr.ListarProducto();
                    }
                    else
                    {
                        var prodFiltrados = prod.Where(c =>
                            (string.IsNullOrEmpty(codigo) || c.CODIGO.Contains(codigo)) &&
                            (string.IsNullOrEmpty(descripcion) || c.DESCRIPCION.Contains(descripcion))
                        ).ToList();
                        dgvBuscarProducto.DataSource = prodFiltrados;
                    }
                }
            }
        }
        private void RealizarBusqueda()
        {
            string codigo = txtCodigoBuscar.Text.Trim();
            string descripcion = txtProductoBuscar.Text.Trim();
            FiltrarProductos(codigo, descripcion);
        }
        private void txtProductoBuscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void txtCodigoBuscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }
    }
}
