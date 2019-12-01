//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compartido.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Facturas = new HashSet<Factura>();
            this.Pagos = new HashSet<Pago>();
        }
    
        public int Id { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Clave { get; set; }
        public string NombreUsuario { get; set; }
        public string Profesion { get; set; }
        public System.DateTime FechaNac { get; set; }
        public string Dirreccion { get; set; }
        public int RolId { get; set; }
        public int PersonaId { get; set; }
        public Nullable<double> Salario { get; set; }
    
        public virtual Rol Rol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pago> Pagos { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
