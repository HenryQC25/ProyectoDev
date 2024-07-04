namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_areas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_areas()
        {
            ad_usuarios = new HashSet<ad_usuarios>();
        }

        [Key]
        public int codigoArea { get; set; }

        [StringLength(45)]
        public string nombre { get; set; }

        public DateTime? fechaCrea { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ad_usuarios> ad_usuarios { get; set; }
    }
}
