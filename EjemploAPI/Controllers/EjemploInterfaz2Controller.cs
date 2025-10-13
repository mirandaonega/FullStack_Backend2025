using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EjemploAPI.EjemploInterfaz;

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfaz2Controller : ControllerBase
    {
        [HttpGet]
        public string EjemploInterfaz2(string tipovehiculo)
        {
            EjemploInterfaz.Base _base = new EjemploInterfaz.Base();
            Moto moto = new Moto();
            return _base.Acelerar(moto);
        } 
    }
}
