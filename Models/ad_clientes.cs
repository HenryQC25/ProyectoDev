namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_clientes
    {
       
       

        [Key]
        public int codigoCliente { get; set; }

        [StringLength(45)]
        public string nombreCliente { get; set; }

        [StringLength(45)]
        public string estatus { get; set; }

       
    }
}
