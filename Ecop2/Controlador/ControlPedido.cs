using Ecop2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecop2.Vista;
using System.Windows.Forms;

namespace Ecop2.Controlador
{
    public class ControlPedido
    {
        public List<PEDIDO_CABECERA> ListarPedido()
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    var ListaPedido = db.PEDIDO_CABECERA.ToList();
                    return ListaPedido;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Pedidos, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<PEDIDO_CABECERA>();
            }
        }
        public int ObtenerNumeroPedido()
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    int nroPedido = db.PEDIDO_CABECERA.Select(pc => pc.PEDIDO_ID).DefaultIfEmpty(0).Max();
                    return nroPedido + 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los Pedidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public int AgregarPedidoCabecera(int ClienteId, double CantidadTotal, decimal MontoTotal, DateTime FechaEntrega)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    var estadoPedido = db.ESTADO_PEDIDO.Where(p =>p.CODIGO == "PENDIENTE").Select(p => p.CODIGO).FirstOrDefault();
                    if (estadoPedido.Any())
                    {
                        PEDIDO_CABECERA cl = new PEDIDO_CABECERA();
                        cl.CLIENTE_ID = ClienteId;
                        cl.CANTIDAD_TOTAL = CantidadTotal;
                        cl.PRECIO_TOTAL = MontoTotal;
                        cl.ESTADO = estadoPedido;
                        cl.FECHA_INGRESO = DateTime.Now;
                        cl.FECHA_ENTREGA = FechaEntrega;

                        db.PEDIDO_CABECERA.Add(cl);
                        db.SaveChanges();

                        return cl.PEDIDO_ID;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Cliente, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        public void AgregarPedidoDetalle(int pedidoId, int productoId, decimal precio, double cantidad)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    PEDIDO_DETALLE cl = new PEDIDO_DETALLE();
                    cl.PEDIDO_ID = pedidoId;
                    cl.PRODUCTO_ID = productoId;
                    cl.PRECIO = precio;
                    cl.CANTIDAD = cantidad;

                    db.PEDIDO_DETALLE.Add(cl);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el Cliente, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double ControlCantidad(int productoId)
        {
            using (PruebaEcopEntities db = new PruebaEcopEntities())
            {
                var cant = (double)db.PRODUCTO.Where(p => p.PRODUCTO_ID == productoId).Select(s =>s.CANTIDAD).FirstOrDefault();
                return cant;
            }
        }
    }
}
