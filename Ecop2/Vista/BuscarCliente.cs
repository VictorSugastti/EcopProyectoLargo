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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            ControlCliente cli = new ControlCliente();
            dgvBuscarCliente.DataSource = cli.ListarCliente();
        }
        public delegate void ClienteSeleccionadoHandler(string clienteId, string razonSocial, string nroDocumento, string direccion, string telefono);
        public event ClienteSeleccionadoHandler ClienteSeleccionado;
        private void dgvBuscarCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBuscarCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBuscarCliente.SelectedRows[0];
                if (selectedRow.Cells.Count >= 5)
                {
                    string clienteId = selectedRow.Cells[0].Value.ToString();
                    string razonSocial = selectedRow.Cells[3].Value.ToString();
                    string nroDocumento = selectedRow.Cells[1].Value.ToString();
                    string direccion = selectedRow.Cells[4].Value.ToString();
                    string telefono = selectedRow.Cells[5].Value.ToString();
                    ClienteSeleccionado?.Invoke(clienteId, razonSocial, nroDocumento, direccion, telefono);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La fila seleccionada no tiene suficientes celdas.");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }
        private void FiltrarClientes(string nrodocumento, string razonsocial)
        {
            string filtro = "";

            if (!string.IsNullOrEmpty(nrodocumento))
            {
                filtro += $"NRO_DOCUMENTO LIKE '%{nrodocumento}%'";
            }
            if (!string.IsNullOrEmpty(razonsocial))
            {
                if (!string.IsNullOrEmpty(filtro))
                {
                    filtro += " OR ";
                }
                filtro += $"RAZON_SOCIAL LIKE '%{razonsocial}%'";
            }

            if (dgvBuscarCliente.DataSource != null)
            {
                List<CLIENTE> clientes = dgvBuscarCliente.DataSource as List<CLIENTE>;

                if (clientes != null)
                {
                    if (string.IsNullOrEmpty(nrodocumento) && string.IsNullOrEmpty(razonsocial))
                    {
                        ControlCliente cli = new ControlCliente();
                        dgvBuscarCliente.DataSource = cli.ListarCliente();
                    }
                    else
                    {
                        var clientesFiltrados = clientes.Where(c =>
                            (string.IsNullOrEmpty(nrodocumento) || c.NRO_DOCUMENTO.Contains(nrodocumento)) &&
                            (string.IsNullOrEmpty(razonsocial) || c.RAZON_SOCIAL.Contains(razonsocial))
                        ).ToList();
                        dgvBuscarCliente.DataSource = clientesFiltrados;
                    }
                }
            }
        }

        private void RealizarBusqueda()
        {
            string nrodoc = txtNroDocBuscar.Text.Trim();
            string razonsocial = txtNombreBuscar.Text.Trim();
            FiltrarClientes(nrodoc, razonsocial);
        }

        private void txtNroDocBuscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void txtNombreBuscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }
    }
}
