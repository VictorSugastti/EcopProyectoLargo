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
    public class ControlCliente
    {
        public ControlCliente() { }
        public List<CLIENTE> ListarCliente()
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    var ListaCliente = db.CLIENTE.ToList();
                    return ListaCliente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Clientes, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<CLIENTE>();
            }
        }
        public List<TIPO_DOCUMENTO> ListarTipoDocumento()
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    var ListaTipoDocumento = db.TIPO_DOCUMENTO.ToList();
                    return ListaTipoDocumento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los Tipos de Documentos, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<TIPO_DOCUMENTO>();
            }
        }
        public string AgregarCliente(string NroDocumento, string TipoDocumento, string RazonSocial, string Direccion, string NroTelefono, string Correo, string Ciudad, string Barrio)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    bool ban = false;
                    CLIENTE cl = new CLIENTE();
                    cl.NRO_DOCUMENTO = NroDocumento;
                    cl.TIPO_DOCUMENTO = TipoDocumento;
                    cl.RAZON_SOCIAL = RazonSocial;
                    cl.DIRECCION = Direccion;
                    cl.NRO_TELEFONO = NroTelefono;
                    cl.FECHA_INGRESO = DateTime.Now;
                    cl.CORREO = Correo;
                    cl.CIUDAD = Ciudad;
                    cl.BARRIO = Barrio;

                    db.CLIENTE.Add(cl);
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
                MessageBox.Show("Error al agregar el Cliente, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
        public string ModificarCliente(int ID, string NroDocumento, string TipoDocumento, string RazonSocial, string Direccion, string NroTelefono, string Correo, string Ciudad, string Barrio)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    bool ban = false;
                    var cl = db.CLIENTE.Where(x => x.CLIENTE_ID == ID).FirstOrDefault();
                    if (cl != null)
                    {
                        cl.NRO_DOCUMENTO = NroDocumento;
                        cl.TIPO_DOCUMENTO = TipoDocumento;
                        cl.RAZON_SOCIAL = RazonSocial;
                        cl.DIRECCION = Direccion;
                        cl.NRO_TELEFONO = NroTelefono;
                        cl.FECHA_INGRESO = DateTime.Now;
                        cl.CORREO = Correo;
                        cl.CIUDAD = Ciudad;
                        cl.BARRIO = Barrio;

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
                MessageBox.Show("Error al modificar el Cliente, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
        public string EliminarCliente(int Id)
        {
            try
            {
                using (PruebaEcopEntities db = new PruebaEcopEntities())
                {
                    bool ban = false;
                    var cl = db.CLIENTE.Where(x => x.CLIENTE_ID == Id).FirstOrDefault();
                    if (cl != null)
                    {
                        db.CLIENTE.Remove(cl);
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
                MessageBox.Show("Error al eliminar el cliente, " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
    }
}
