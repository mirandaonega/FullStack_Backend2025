using Microsoft.EntityFrameworkCore;
using OrmAPI.Data;
using OrmAPI.Modelo;

namespace OrmAPI.Repository
{
    public class NorthwindRepository: INorthwindRepository
    {
        private readonly DataContext _context;
        
        public NorthwindRepository(DataContext context)
        {
            this._context = context;
        }

        public async Task<List<Employee>> ObtenerTodosLosEmpleados()
        {
            return await this._context.Employees.ToListAsync();
        }

        public async Task<int> ObtenerlaCantidadDeEmpleados()
        {
            return await this._context.Employees.CountAsync();
        }

    }
 }
