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
    
    public partial class permiso
    {
        public permiso()
        {
            this.usuarios_perfiles_permisos = new HashSet<usuarios_perfiles_permisos>();
        }
    
        public int PermisoId { get; set; }
        public string Nombre_Permiso { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<usuarios_perfiles_permisos> usuarios_perfiles_permisos { get; set; }
    }
}