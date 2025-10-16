using OrmAPI.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace OrmAPI.Repository
{
    public interface INorthwindRepository
    {
        Task<List<Employee>> ObtenerTodosLosEmpleados();
        Task<int> ObtenerlaCantidadDeEmpleados();
        Task<Employee?> ObtenerEmpleadoPorID(int id);
        Task<List<Employee>> ObtenerEmpleadosPorNombre(string nombre, string apellido);
        Task<List<int>> ObtenerEmpleadoIDporTitulo(string titulo);
        Task<Employee?> ObtenerEmpleadoPorPais(string pais);
        Task<List<Employee>> ObtenerTodosLosEmpleadosPorPais(string pais);
        Task<List<Employee>> ObtenerElEmpleadoMasGrande();
        Task<Dictionary<string, int>> CantidadEmpleadosPorTitulos();
        Task<List<Products>> ObtenerProductosConCategoria();
        Task<List<Products>> ObtenerProductosQueContienen(string palabra);
    }
}
