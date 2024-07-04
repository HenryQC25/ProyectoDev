namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ad_usuarios()
        {
            pr_detalleActividades = new HashSet<pr_detalleActividades>();
        }

        [Key]
        public int codigoUsuario { get; set; }

        [StringLength(45)]
        public string nombres { get; set; }

        [StringLength(45)]
        public string apellidos { get; set; }

        public DateTime? fechaIngreso { get; set; }

        [StringLength(45)]
        public string foto { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoRol { get; set; }

        public int? codigoDepartamento { get; set; }

        public int? codigoPuesto { get; set; }

        public int? codigoArea { get; set; }

        public virtual ad_areas ad_areas { get; set; }

        public virtual ad_departamento ad_departamento { get; set; }

        public virtual ad_puestos ad_puestos { get; set; }

        public virtual ad_roles ad_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pr_detalleActividades> pr_detalleActividades { get; set; }
    }
}
