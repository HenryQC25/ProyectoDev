namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pr_proyectoPP
    {
        [Key]
        public int codigoPP { get; set; }

        [StringLength(256)]
        public string comentario { get; set; }

        public DateTime? fechaInicioInstalacion { get; set; }

        public DateTime? fechaFinalInstalacion { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoProyecto { get; set; }

        public virtual wf_proyectos wf_proyectos { get; set; }
    }
}
