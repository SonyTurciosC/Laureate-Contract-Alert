//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sistema_alertas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_tarjetas
    {
        public tipo_tarjetas()
        {
            this.tarjetas = new HashSet<tarjeta>();
        }
    
        public int Tipo_TarjetaId { get; set; }
        public string Nombre_Tarjeta { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<tarjeta> tarjetas { get; set; }
    }
}