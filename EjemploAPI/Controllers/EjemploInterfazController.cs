using EjemploAPI.EjemploInterfaz;
using Microsoft.AspNetCore.Mvc;

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfazController : ControllerBase
    {
        [HttpGet]
        [Route("api/EjemploInterfaz")]
        public string EjemploInterfaz()
        {
            Auto Auto = new Auto();
            return Auto.Acelerar();
        }

        [HttpGet]
        [Route("api/EjemploInterfazImplementacion")]
        public string EjemploInterfazImplementacion()
        {
            IVehiculo Auto = new Auto();
            return Auto.ObtenerDistanciaRecorrida();
        }
    }
}
