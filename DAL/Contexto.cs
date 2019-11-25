using Entidades;
using System.Data.Entity;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Analisis { get; set; }
        public DbSet<Pacientes> Pacientes { get; set; }
        public DbSet<TipoAnalisis> TipoAnaliss { get; set; }
        public DbSet<OrdenAnalisis> OrdenAnalisis { get; set; }
        public DbSet<EntradaResultados> EntradaResultados { get; set; }


        public Contexto() : base("ConStr")

        { }

    }

}