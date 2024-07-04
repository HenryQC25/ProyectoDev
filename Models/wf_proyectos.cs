namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class wf_proyectos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public wf_proyectos()
        {
            ad_costoProyecto = new HashSet<ad_costoProyecto>();
            pr_detalleActividades = new HashSet<pr_detalleActividades>();
            pr_proyectoPP = new HashSet<pr_proyectoPP>();
        }

        [Key]
        public int codigoProyecto { get; set; }

        [StringLength(45)]
        public string nombre { get; set; }

        [StringLength(45)]
        public string descripcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaInicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaFin { get; set; }

        public int? horasProyectadas { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoCliente { get; set; }

        public int? codigoFase { get; set; }

        public virtual ad_clientes ad_clientes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ad_costoProyecto> ad_costoProyecto { get; set; }

        public virtual ad_FaseProyecto ad_FaseProyecto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pr_detalleActividades> pr_detalleActividades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pr_proyectoPP> pr_proyectoPP { get; set; }
    }
}
