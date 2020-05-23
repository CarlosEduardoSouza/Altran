using System.Collections.Generic;
using System.Threading.Tasks;
using Altran.Api.ViewModel;
using Altran.Data.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Altran.Api.Controllers
{
    [Route("api/Usuario")]
    public class UsuarioController : MainController
    {
        private readonly UsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioController(UsuarioRepository usuarioRepository,
            IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UsuarioViewModel>> ObterTodos()
        {
            var usuario = _mapper.Map<IEnumerable<UsuarioViewModel>>(await _usuarioRepository.ObterTodos());

            return usuario;
        }
    }
}
