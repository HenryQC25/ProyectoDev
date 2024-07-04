namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_costoProyecto
    {
        [Key]
        public int codigo { get; set; }

        public int? valorPorHora { get; set; }

        public int? valorDelProyecto { get; set; }

        public int? horasEstimadasProyecto { get; set; }

        public int? codigoProyecto { get; set; }

        public virtual wf_proyectos wf_proyectos { get; set; }
    }
}
