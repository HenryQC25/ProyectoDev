namespace DevProjectLocal.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ad_roles
    {
       

        public int codigoRol { get; set; }

        
        public string nombreRol { get; set; }

       
        public string descripcionRol { get; set; }

        public DateTime? fechaCrea { get; set; }

    
        public string estatus { get; set; }

    }
}
