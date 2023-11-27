using Microsoft.EntityFrameworkCore;

namespace ServerDeclara.Datos
{
    public class DeclaraContext : DbContext
    {
        public DeclaraContext(DbContextOptions<DeclaraContext> options): base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ParametrosIRPF> ParametrosIRPFs { get; set; }
        public DbSet<EntradaIVADiario> EntradasIVAsDiarios { get; set; }
        public DbSet<DeclaracionMensualIRPF> DeclaracionsMensualesIRPFs { get; set; }
        public DbSet<Comercio> Comercios { get; set; }
        public DbSet<BPC> BPCs { get; set; }
        public DbSet<BimensualRPF> BimensualesRPFs { get; set; }
    }
}
