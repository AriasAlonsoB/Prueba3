//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEViajaMas
{
    using System;
    using System.Collections.Generic;
    
    public partial class devDevol
    {
        public int id_devDevol { get; set; }
        public Nullable<int> id_reserva { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    
        public virtual reserva reserva { get; set; }
    }
}