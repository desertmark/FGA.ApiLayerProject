//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FGA.Congressus2.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Conferencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conferencia()
        {
            this.InscripcionConferencia = new HashSet<InscripcionConferencia>();
        }
    
        public int ConferenciaId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public int Cupo { get; set; }
        public Nullable<System.DateTime> FechaHora { get; set; }
        public string Lugar { get; set; }
        public int EventoId { get; set; }
        public Nullable<int> PaperId { get; set; }
    
        public virtual Eventos Eventos { get; set; }
        public virtual Paper Paper { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InscripcionConferencia> InscripcionConferencia { get; set; }
    }
}
