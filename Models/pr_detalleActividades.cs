namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pr_detalleActividades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pr_detalleActividades()
        {
            pr_hallazgosQA = new HashSet<pr_hallazgosQA>();
        }

        [Key]
        public int codigoDetalleProyecto { get; set; }

        [StringLength(45)]
        public string nombre { get; set; }

        [StringLength(45)]
        public string descripcion { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaFin { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoProyecto { get; set; }

        public int? codigoUsuario { get; set; }

        public virtual ad_usuarios ad_usuarios { get; set; }

        public virtual wf_proyectos wf_proyectos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pr_hallazgosQA> pr_hallazgosQA { get; set; }
    }
}
