using Altran.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace Altran.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions<MeuDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; } 
    }
}
