namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_FaseProyecto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_FaseProyecto()
        {
            wf_proyectos = new HashSet<wf_proyectos>();
        }

        [Key]
        public int codigoFase { get; set; }

        [StringLength(45)]
        public string nombreFase { get; set; }

        public DateTime? fechaCrea { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wf_proyectos> wf_proyectos { get; set; }
    }
}
