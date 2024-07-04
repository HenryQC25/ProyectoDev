using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DevProjectLocal.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=CNBD")
        {
        }

        public virtual DbSet<ad_areas> ad_areas { get; set; }
        public virtual DbSet<ad_clientes> ad_clientes { get; set; }
        public virtual DbSet<ad_costoProyecto> ad_costoProyecto { get; set; }
        public virtual DbSet<ad_departamento> ad_departamento { get; set; }
        public virtual DbSet<ad_FaseProyecto> ad_FaseProyecto { get; set; }
        public virtual DbSet<ad_puestos> ad_puestos { get; set; }
        public virtual DbSet<ad_roles> ad_roles { get; set; }
        public virtual DbSet<ad_subclientes> ad_subclientes { get; set; }
        public virtual DbSet<ad_usuarios> ad_usuarios { get; set; }
        public virtual DbSet<pr_detalleActividades> pr_detalleActividades { get; set; }
        public virtual DbSet<pr_detalleQA> pr_detalleQA { get; set; }
        public virtual DbSet<pr_hallazgosQA> pr_hallazgosQA { get; set; }
        public virtual DbSet<pr_proyectoPP> pr_proyectoPP { get; set; }
        public virtual DbSet<wf_proyectos> wf_proyectos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ad_areas>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ad_areas>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_clientes>()
                .Property(e => e.nombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<ad_clientes>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_departamento>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ad_departamento>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_FaseProyecto>()
                .Property(e => e.nombreFase)
                .IsUnicode(false);

            modelBuilder.Entity<ad_FaseProyecto>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_puestos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ad_puestos>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_roles>()
                .Property(e => e.nombreRol)
                .IsUnicode(false);

            modelBuilder.Entity<ad_roles>()
                .Property(e => e.descripcionRol)
                .IsUnicode(false);

            modelBuilder.Entity<ad_roles>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_subclientes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ad_subclientes>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<ad_usuarios>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<ad_usuarios>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<ad_usuarios>()
                .Property(e => e.foto)
                .IsUnicode(false);

            modelBuilder.Entity<ad_usuarios>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<pr_detalleActividades>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<pr_detalleActividades>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<pr_detalleActividades>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<pr_detalleQA>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<pr_detalleQA>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<pr_hallazgosQA>()
                .Property(e => e.descripcionHallazgos)
                .IsUnicode(false);

            modelBuilder.Entity<pr_hallazgosQA>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<pr_hallazgosQA>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<pr_proyectoPP>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<pr_proyectoPP>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<wf_proyectos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<wf_proyectos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<wf_proyectos>()
                .Property(e => e.estatus)
                .IsUnicode(false);
        }
    }
}
