namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pr_hallazgosQA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pr_hallazgosQA()
        {
            pr_detalleQA = new HashSet<pr_detalleQA>();
        }

        [Key]
        public int codigoQA { get; set; }

        [StringLength(256)]
        public string descripcionHallazgos { get; set; }

        [StringLength(45)]
        public string comentario { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaFin { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoDetalleProyecto { get; set; }

        public virtual pr_detalleActividades pr_detalleActividades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pr_detalleQA> pr_detalleQA { get; set; }
    }
}
