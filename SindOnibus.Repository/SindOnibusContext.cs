using Microsoft.EntityFrameworkCore;
using SindOnibus.Domain;


namespace SindOnibus.Repository
{
    public class SindOnibusContext : DbContext
    {
        public SindOnibusContext(DbContextOptions<SindOnibusContext> options) : base (options) {}
        
        public DbSet<Cadastro> Cadastros { get; set; }
    }
}