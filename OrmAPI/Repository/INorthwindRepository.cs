using OrmAPI.Modelo;

namespace OrmAPI.Repository
{
    public interface INorthwindRepository
    {
        Task<List<Employee>> ObtenerTodosLosEmpleados();
        Task<int> ObtenerlaCantidadDeEmpleados();

    }
}
