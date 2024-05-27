using Ecop2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecop2.Vista;

namespace Ecop2.Controlador
{
    public class ControlProducto
    {
        public string Codigo { set; get; }
        public string Descripcion { set; get; }
        public string Cantidad { set; get; }
        public string Precio1 { set; get; }
        public string Precio2 { set; get; }
        public string Precio3 { set; get; }
        public string UnidadMedida { set; get; }
        public ControlProducto() { }

        public List<PRODUCTO> ListarProducto()
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    var ListaProducto = db.PRODUCTO.ToList();
                    return ListaProducto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los productos, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<PRODUCTO>();
            }
        }
        public List<UNIDAD_MEDIDA> ListarUnidadMedida()
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    var ListaUnidadMedida = db.UNIDAD_MEDIDA.ToList();
                    return ListaUnidadMedida;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Unidades de Medida, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<UNIDAD_MEDIDA>();
            }
        }
        public string AgregarProducto(string Codigo, string Descripcion, string Cantidad, string Precio1, string UnidadMedida)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    bool ban = false;
                    PRODUCTO pr = new PRODUCTO();
                    pr.CODIGO = Codigo;
                    pr.DESCRIPCION = Descripcion;
                    pr.CANTIDAD = Convert.ToDouble(Cantidad);
                    pr.PRECIO1  = Convert.ToDecimal(Precio1);
                    pr.FECHA_INGRESO = DateTime.Now;
                    pr.UNIDAD_MEDIDA = UnidadMedida;

                    db.PRODUCTO.Add(pr);
                    db.SaveChanges();

                    ban = true;
                    if (ban)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "NOOK";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
        public string ModificarProducto(int Id, string Codigo, string Descripcion, string Cantidad, string Precio1, string UnidadMedida)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    bool ban = false;
                    var pr = db.PRODUCTO.Where(x => x.PRODUCTO_ID == Id).FirstOrDefault();
                    if (pr != null)
                    {
                        pr.CODIGO = Codigo;
                        pr.DESCRIPCION = Descripcion;
                        pr.CANTIDAD = Convert.ToDouble(Cantidad);
                        pr.PRECIO1 = Convert.ToDecimal(Precio1);
                        pr.FECHA_INGRESO = DateTime.Now;
                        pr.UNIDAD_MEDIDA = UnidadMedida;

                        db.SaveChanges();

                        ban = true;
                    }

                    if (ban)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "NOOK";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el producto, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
        public string EliminarProducto(int Id)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    bool ban = false;
                    var pr = db.PRODUCTO.Where(x => x.PRODUCTO_ID == Id).FirstOrDefault();
                    if (pr != null)
                    {
                        db.PRODUCTO.Remove(pr);
                        db.SaveChanges();

                        ban = true;
                    }

                    if (ban)
                    {
                        return "OK";
                    }
                    else
                    {
                        return "NOOK";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
    }
}
