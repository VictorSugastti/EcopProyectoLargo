using Ecop2.Controlador;
using Ecop2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecop2.Vista
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ActualizardgvCli();
            CargarComboBoxCli();
        }
        private void ActualizardgvCli()
        {
            ControlCliente cli = new ControlCliente();
            dgvClientes.DataSource = cli.ListarCliente();
        }
        private bool ValidarCorreoElectronico(string correo)
        {
            string patronCorreo = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.IsMatch(correo, patronCorreo);
        }
        private void CargarComboBoxCli()
        {
            List<TIPO_DOCUMENTO> tipodoc = new List<TIPO_DOCUMENTO>();
            tipodoc.Add(new TIPO_DOCUMENTO { ID = 0, CODIGO = "Seleccione", DESCRIPCION = "" });

            ControlCliente cli = new ControlCliente();
            List<TIPO_DOCUMENTO> um = cli.ListarTipoDocumento();

            tipodoc.AddRange(um);

            cbTipoDoc.DataSource = tipodoc;
            cbTipoDoc.DisplayMember = "Codigo";
            cbTipoDoc.ValueMember = "Id";
            cbTipoDoc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarCli_Click(object sender, EventArgs e)
        {
            string nro_documento = txtNroDoc.Text;
            string razon_social = txtNombre.Text;            
            string direccion = txtDireccion.Text;
            string telefono = txtNroTel.Text;
            string correo = txtCorreo.Text;
            string ciudad = txtCiudad.Text;
            string barrio = txtBarrio.Text;
            string tipodoc = "";

            if (string.IsNullOrEmpty(nro_documento))
            {
                MessageBox.Show("Debe ingresar el Número de Documento del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTipoDoc.SelectedIndex > 0)
            {
                TIPO_DOCUMENTO tipoSeleccionada = (TIPO_DOCUMENTO)cbTipoDoc.SelectedItem;
                tipodoc = tipoSeleccionada.CODIGO;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(razon_social))
            {
                MessageBox.Show("Debe ingresar la Razón Social del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(correo))
            {
                if (!ValidarCorreoElectronico(correo))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ControlCliente cli = new ControlCliente();
            string add = cli.AgregarCliente(nro_documento, tipodoc, razon_social, direccion, telefono, correo, ciudad, barrio);

            if (add == "OK")
            {
                MessageBox.Show("El Cliente se agrego correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposCliente();
                ActualizardgvCli();
            }
            else
            {
                MessageBox.Show("El Cliente no se pudo agregar, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposCliente();
            }
        }
        public void LimpiarCamposCliente()
        {
            txtNroDoc.Clear();
            cbTipoDoc.SelectedIndex = 0;
            txtNombre.Clear();
            txtNroTel.Clear();
            txtIdCliente.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtCiudad.Clear();
            txtBarrio.Clear();

            btnAgregarCli.Enabled = true;
            btnModificarCli.Enabled = false;
            btnEliminarCli.Enabled = false;

            txtNroDoc.Focus();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == -1 || dgvClientes.SelectedCells[1].Value.ToString() == "")
            {
                LimpiarCamposCliente();
            }
            else
            {
                txtIdCliente.Text = dgvClientes.SelectedCells[0].Value.ToString();
                txtNroDoc.Text = dgvClientes.SelectedCells[1].Value.ToString();
                txtNombre.Text = dgvClientes.SelectedCells[3].Value.ToString();
                txtIdCliente.Text = dgvClientes.SelectedCells[4].Value.ToString();
                txtNroTel.Text = dgvClientes.SelectedCells[5].Value.ToString();
                txtCorreo.Text = dgvClientes.SelectedCells[6].Value.ToString();
                txtCiudad.Text = dgvClientes.SelectedCells[7].Value.ToString();
                txtBarrio.Text = dgvClientes.SelectedCells[8].Value.ToString();

                string tipodoc = dgvClientes.SelectedCells[2].Value.ToString();
                for (int j = 0; j < cbTipoDoc.Items.Count; j++)
                {
                    TIPO_DOCUMENTO tipo = (TIPO_DOCUMENTO)cbTipoDoc.Items[j];
                    if (tipo.CODIGO == tipodoc)
                    {
                        cbTipoDoc.SelectedIndex = j;
                    }
                }

                btnAgregarCli.Enabled = false;
                btnModificarCli.Enabled = true;
                btnEliminarCli.Enabled = true;
            }
        }

        private void btnModificarCli_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(txtIdCliente.Text);
            string nro_documento = txtNroDoc.Text;
            string razon_social = txtNombre.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtNroTel.Text;
            string correo = txtCorreo.Text;
            string ciudad = txtCiudad.Text;
            string barrio = txtBarrio.Text;
            string tipodoc = "";

            if (string.IsNullOrEmpty(nro_documento))
            {
                MessageBox.Show("Debe ingresar el Número de Documento del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTipoDoc.SelectedIndex > 0)
            {
                TIPO_DOCUMENTO tipoSeleccionada = (TIPO_DOCUMENTO)cbTipoDoc.SelectedItem;
                tipodoc = tipoSeleccionada.CODIGO;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Tipo de Documento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(razon_social))
            {
                MessageBox.Show("Debe ingresar la Razón Social del Cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!string.IsNullOrEmpty(correo))
            {
                if (!ValidarCorreoElectronico(correo))
                {
                    MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ControlCliente cli = new ControlCliente();
            string edit = cli.ModificarCliente(clienteId, nro_documento, tipodoc, razon_social, direccion, telefono, correo, ciudad, barrio);

            if (edit == "OK")
            {
                MessageBox.Show("El Cliente se modifico correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposCliente();
                ActualizardgvCli();
            }
            else
            {
                MessageBox.Show("El Cliente no se pudo modificar, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposCliente();
            }
        }

        private void btnEliminarCli_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtIdCliente.Text);
            ControlCliente cl = new ControlCliente();
            string del = cl.EliminarCliente(Id);

            if (del == "OK")
            {
                MessageBox.Show("El Cliente se elimino correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposCliente();
                ActualizardgvCli();
            }
            else
            {
                MessageBox.Show("El Cliente no se pudo eliminar, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposCliente();
            }
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
