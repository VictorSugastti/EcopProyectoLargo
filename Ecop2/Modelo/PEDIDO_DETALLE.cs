//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ecop2.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class PEDIDO_DETALLE
    {
        public int DETALLE_ID { get; set; }
        public Nullable<int> PEDIDO_ID { get; set; }
        public Nullable<int> PRODUCTO_ID { get; set; }
        public Nullable<decimal> PRECIO { get; set; }
        public Nullable<double> CANTIDAD { get; set; }
        public string PRODUCTO_DESCRIPCION { get; set; }
    }
}
