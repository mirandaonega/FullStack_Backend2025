using EjemploAPI.EjemploConDY;
using EjemploAPI.EjemploSinDY;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploConDYController : ControllerBase
    {
        private UsuarioService usuarioService;
        public EjemploConDYController(UsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        [HttpGet("{email}")]
        public string Get(string email)
        {
            return this.usuarioService.NotificarEnvioMail(email);
        }
    }
}
