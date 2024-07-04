namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_subclientes
    {
        [Key]
        public int codigoSubCliente { get; set; }

        [StringLength(45)]
        public string nombre { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

        public int? codigoCliente { get; set; }

        public virtual ad_clientes ad_clientes { get; set; }
    }
}
