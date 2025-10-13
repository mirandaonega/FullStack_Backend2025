using Microsoft.AspNetCore.Http;
using EjemploAPI.AnimalesInterfaz;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalesController : ControllerBase
    {
        [HttpGet("perro")]
        public IActionResult GetPerro()
        {
            IAnimales perro = new Perro("Pancho");
            return Ok(new { Nombre = perro.Nombre, Sonido = perro.hacerRuido() });
        }

        [HttpGet("gato")]
        public IActionResult GetGato()
        {
            IAnimales gato = new Gato("Michi");
            return Ok(new { Nombre = gato.Nombre, Sonido = gato.hacerRuido() });
        }
    }
}
