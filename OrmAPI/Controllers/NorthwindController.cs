using Microsoft.AspNetCore.Mvc;
using System.Linq;
using OrmAPI.Modelo;
using OrmAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrmAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private readonly INorthwindRepository _repository;

        public NorthwindController(INorthwindRepository repository)
        {
            this._repository = repository;
        }

        [HttpGet]
        [Route("api/TodosLosEmpleados")]
        public async Task<List<Employee>> GetAll()
        {
            return await _repository.ObtenerTodosLosEmpleados();
        }

        [HttpGet]
        [Route("api/CantidadEmpleados")]
        public async Task<int> ObtenerlaCantidadDeEmpleados()
        {
            return await _repository.ObtenerlaCantidadDeEmpleados();
        }

        [HttpGet]
        [Route("api/EmpleadoPorID/{id}")]
        public async Task<Employee?> ObtenerEmpleadoPorID(int id)
        {
            return await _repository.ObtenerEmpleadoPorID(id);
        }

        [HttpGet]
        [Route("api/EmpleadosPorNombre/{nombre}/{apellido}")]
        public async Task<List<Employee>> ObtenerEmpleadosPorNombre(string nombre, string apellido)
        {
            var todos = await _repository.ObtenerTodosLosEmpleados();
            return todos.Where(e => e.FirstName.Contains(nombre, StringComparison.OrdinalIgnoreCase) || e.LastName.Contains(apellido, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        [HttpGet]
        [Route("api/EmpleadoIDporTitulo/{titulo}")]
        public async Task<List<int>> ObtenerEmpleadoIDporTitulo(string titulo)
        {
            var todos = await _repository.ObtenerTodosLosEmpleados();
            return todos.Where(e => e.Title.Contains(titulo, StringComparison.OrdinalIgnoreCase)).Select(e => e.EmployeeID).ToList();
        }

        [HttpGet]
        [Route("api/EmpleadoPorPais/{pais}")]
        public async Task<Employee?> ObtenerEmpleadoPorPais(string pais)
        {
            return await _repository.ObtenerEmpleadoPorPais(pais);
        }

        [HttpGet]
        [Route("api/TodosLosEmpleadosPorPais/{pais}")]
        public async Task<List<Employee>> ObtenerTodosLosEmpleadosPorPais(string pais)
        {
            var todos = await _repository.ObtenerTodosLosEmpleados();
            return todos.Where(e => e.Country.Equals(pais, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        [HttpGet]
        [Route("api/ElEmpleadoMasGrande")]
        public async Task<Employee?> ElEmpleadoMasGrande()
        {
            var todos = await _repository.ObtenerTodosLosEmpleados();
            return todos.OrderBy(e => e.BirthDate).FirstOrDefault();
        }

        [HttpGet]
        [Route("api/CantidadEmpleadosPorTitulos")]
        public async Task<Dictionary<string, int>> CantidadEmpleadosPorTitulos()
        {
            var todos = await _repository.ObtenerTodosLosEmpleados();
            return todos.GroupBy(e => e.Title)
                        .ToDictionary(g => g.Key, g => g.Count());
        }

        [HttpGet]
        [Route("api/ObtenerProductosConCategoria")]
        public async Task<IActionResult> ObtenerProductosConCategoria()
        {
            var productosCompletos = await _repository.ObtenerProductosConCategoria();
            var productosProyectados = productosCompletos
                .Select(p => new
                {
                    NombreProducto = p.ProductName,
                    CategoriaProducto = p.CategoryID
                })
                .ToList();
            return Ok(productosProyectados);
        }

        [HttpGet]
        [Route("api/ObtenerProductosQueContienen/{palabra}")]
        public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
        {
            var todos = await _repository.ObtenerProductosConCategoria();
            return todos.Where(p => p.ProductName.Contains(palabra, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
