using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiPrimerAPI.Controllers
{
    /// <summary>
    /// Creación de clase para manipular instrumentos.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class InstrumentController : ControllerBase
    {
        /// <summary>
        /// Lista en memoria con valores iniciales.
        /// </summary>
        private static List<string> instruments = new() { "Guitarra", "Batería", "Piano" };

        /// <summary>
        /// Devuelve los instrumentos de la lista.
        /// </summary>
        /// <returns></returns>
        // GET api/<InstrumentController>/5
        [HttpGet]
        public ActionResult GetInstruments()
        {
            return Ok(instruments);
        }

        /// <summary>
        /// Agrega un instrumento a la lista.
        /// </summary>
        /// <param name="instrumentNew"></param>
        /// <returns></returns>
        // POST api/<EjerciciosController>
        [HttpPost]
        public ActionResult <string> AddNewInstrument([FromBody] string instrumentNew)
        {
            if (instrumentNew == null)
            {
                return BadRequest("el campo es obligatorio");
            }
            instruments.Add(instrumentNew);
            return Ok($"instrumento agregado a la lista: {instrumentNew}");
        }

        /// <summary>
        /// Actualizar un instrumento existente.
        /// </summary>
        /// <param name="instrumentIndex"></param>
        /// <param name="newInstrument"></param>
        /// <returns></returns>
        // PUT api/<EjerciciosController>/5
        [HttpPut("{instrumentId}")]
        public ActionResult <string> UpdateInstrument([FromRoute] int instrumentId, [FromBody] string newInstrument)
        {
            if (newInstrument == null)
            {
                return BadRequest("el campo es obligatorio");
            }
            instruments[instrumentId] = newInstrument;
            return Ok($"Instrumento agregado a la lista: {newInstrument}, en posición {instrumentId}");
        }

        /// <summary>
        /// Elimina un instrumento.
        /// </summary>
        /// <param name="instrumentId"></param>
        /// <returns></returns>
        // DELETE api/<EjerciciosController>/5
        [HttpDelete("{instrumentId}")]
        public ActionResult <string> DeleteInstrument([FromRoute] int instrumentId)
        {
            if (instrumentId < 0 || instrumentId >= instruments.Count)
            {
                return NotFound("Instrumento no encontrado");
            }
            string instrumentoEliminado = instruments[instrumentId];
            instruments.RemoveAt(instrumentId);
            return Ok($"Instrumento {instrumentoEliminado} de la posición {instrumentId} eliminado correctamente");
        }
    }
}
