using Altran.Business.Interfaces;
using Altran.Business.Models;
using Altran.Data.Context;

namespace Altran.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MeuDbContext context) : base(context) { }
    }
}

