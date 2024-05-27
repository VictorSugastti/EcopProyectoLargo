using Ecop2.Controlador;
using Ecop2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecop2.Vista
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void txtPrecio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            Actualizardgv();
            CargarComboBox();
        }

        private void Actualizardgv()
        {
            ControlProducto pro = new ControlProducto();
            dgvProductos.DataSource = pro.ListarProducto();
        }

        private void CargarComboBox()
        {
            List<UNIDAD_MEDIDA> unidades = new List<UNIDAD_MEDIDA>();
            unidades.Add(new UNIDAD_MEDIDA { ID = 0, CODIGO = "Seleccione", DESCRIPCION = "" });

            ControlProducto pr = new ControlProducto();
            List<UNIDAD_MEDIDA> um = pr.ListarUnidadMedida();

            unidades.AddRange(um);

            cbUniMed.DataSource = unidades;
            cbUniMed.DisplayMember = "Codigo"; 
            cbUniMed.ValueMember = "Id";
            cbUniMed.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            string Descripcion = txtDescripcion.Text;
            string Cantidad = txtCantidad.Text;
            string Precio1 = txtPrecio1.Text;

            string unidadmedida = "";

            if (string.IsNullOrEmpty(Codigo))
            {
                MessageBox.Show("Debe ingresar un Código para el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Descripcion))
            {
                MessageBox.Show("Debe ingresar una Descripción del Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbUniMed.SelectedIndex > 0)
            {
                UNIDAD_MEDIDA unidadSeleccionada = (UNIDAD_MEDIDA)cbUniMed.SelectedItem;
                unidadmedida = unidadSeleccionada.CODIGO;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Unidad de Medida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Cantidad) || Convert.ToDouble(Cantidad) == 0)
            {
                MessageBox.Show("Debe ingresar una Cantidad para el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Precio1))
            {
                MessageBox.Show("Debe ingresar un Precio para el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ControlProducto cp = new ControlProducto();
            string add = cp.AgregarProducto(Codigo, Descripcion, Cantidad, Precio1, unidadmedida);

            if (add == "OK")
            {
                MessageBox.Show("El Producto se agrego correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
                Actualizardgv();
            }
            else
            {
                MessageBox.Show("El Producto no se pudo agregar, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposProducto();
            }
        }

        public void LimpiarCamposProducto()
        {
            txtId.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtPrecio1.Clear();
            cbUniMed.SelectedIndex = 0;

            btnAgregarPro.Enabled = true;
            btnModificarPro.Enabled = false;
            btnEliminarPro.Enabled = false;

            txtCodigo.Focus();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i == -1 || dgvProductos.SelectedCells[1].Value.ToString() == "")
            {
                LimpiarCamposProducto();
            }
            else
            {
                txtId.Text = dgvProductos.SelectedCells[0].Value.ToString();
                txtCodigo.Text = dgvProductos.SelectedCells[1].Value.ToString();
                txtDescripcion.Text = dgvProductos.SelectedCells[2].Value.ToString();
                txtCantidad.Text = dgvProductos.SelectedCells[3].Value.ToString();

                if (dgvProductos.SelectedCells.Count > 4)
                {
                    txtPrecio1.Text = dgvProductos.SelectedCells[4].Value?.ToString() ?? "0";
                }
                else
                {
                    txtPrecio1.Text = "0";
                }

                string codigo = dgvProductos.SelectedCells[8].Value.ToString();
                for (int j = 0; j < cbUniMed.Items.Count; j++)
                {
                    UNIDAD_MEDIDA unidad = (UNIDAD_MEDIDA)cbUniMed.Items[j];
                    if (unidad.CODIGO == codigo)
                    {
                        cbUniMed.SelectedIndex = j;
                    }
                }

                btnAgregarPro.Enabled = false;
                btnModificarPro.Enabled = true;
                btnEliminarPro.Enabled = true;
            }
        }
        private void btnModificarPro_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            string Codigo = txtCodigo.Text;
            string Descripcion = txtDescripcion.Text;
            string Cantidad = txtCantidad.Text;
            string Precio1 = txtPrecio1.Text;
            string unidadmedida = "";
            if (string.IsNullOrEmpty(Codigo))
            {
                MessageBox.Show("Debe ingresar un Código para el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Descripcion))
            {
                MessageBox.Show("Debe ingresar una Descripción del Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(Cantidad) || Convert.ToDouble(Cantidad) == 0)
            {
                MessageBox.Show("Debe ingresar una Cantidad para el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbUniMed.SelectedIndex > 0)
            {
                UNIDAD_MEDIDA unidadSeleccionada = (UNIDAD_MEDIDA)cbUniMed.SelectedItem;
                unidadmedida = unidadSeleccionada.CODIGO;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Unidad de Medida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Precio1))
            {
                MessageBox.Show("Debe ingresar al menos un Precio para el Producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ControlProducto cp = new ControlProducto();
            string edit = cp.ModificarProducto(Id, Codigo, Descripcion, Cantidad, Precio1, unidadmedida);

            if (edit == "OK")
            {
                MessageBox.Show("El Producto se modifico correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
                Actualizardgv();
            }
            else
            {
                MessageBox.Show("El Producto no se pudo modificar, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposProducto();
            }
        }

        private void btnEliminarPro_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            ControlProducto cp = new ControlProducto();
            string del = cp.EliminarProducto(Id);

            if (del == "OK")
            {
                MessageBox.Show("El Producto se elimino correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCamposProducto();
                Actualizardgv();
            }
            else
            {
                MessageBox.Show("El Producto no se pudo eliminar, verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarCamposProducto();
            }
        }

        private void gbProducto_Enter(object sender, EventArgs e)
        {

        }
    }


}
