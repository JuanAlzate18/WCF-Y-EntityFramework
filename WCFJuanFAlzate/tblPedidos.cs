//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFJuanFAlzate
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblPedidos
    {
        public int NroFactura { get; set; }
        public string Cliente { get; set; }
        public string DireccionEntrega { get; set; }
        public string Fecha { get; set; }
        public Nullable<bool> Pagado { get; set; }
        public string Producto { get; set; }
        public Nullable<decimal> TotalFactura { get; set; }
    }
}
