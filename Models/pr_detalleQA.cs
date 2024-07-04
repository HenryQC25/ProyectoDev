namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pr_detalleQA
    {
        [Key]
        public int codigoDetalle { get; set; }

        [StringLength(256)]
        public string descripcion { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaFin { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoQA { get; set; }

        public virtual pr_hallazgosQA pr_hallazgosQA { get; set; }
    }
}
