using Microsoft.AspNetCore.Mvc;
using EjemploAPI.EjemploHerencia;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EjemploAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {

        [HttpGet]
        public Moto GetVehiculo()
        {
            Moto moto = new Moto();
            moto.TipoMoto = "cross";
            moto.Marca = "Zanella";
            moto.Modelo = "moto1";
            return moto;
        //Auto auto = new Auto();
        //return moto.Acelerar();
        }

        //[HttpGet]
        //public string GetAcelerar()
        //{
        //    Moto moto = new Moto();
        //    return moto.Acelerar();
        //}

        //[HttpGet]
        //public Cliente GetCliente()
        //{
        //    Cliente cliente = new Cliente();
        //    cliente.Nombre = "Miranda";
        //    cliente.Apellido = "Onega";
        //    cliente.Dni = "44630427";
        //    cliente.NroCliente = "12345";
        //    return cliente;
        //}

    }
}
