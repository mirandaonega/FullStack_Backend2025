using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrmAPI.Data;
using OrmAPI.Modelo;

namespace OrmAPI.Repository
{
    public class NorthwindRepository : INorthwindRepository
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

        public async Task<Employee?> ObtenerEmpleadoPorID(int id)
        {
            return await this._context.Employees.FirstOrDefaultAsync(e => e.EmployeeID == id);
        }

        public async Task<List<Employee>> ObtenerEmpleadosPorNombre(string nombre, string apellido)
        {
            return await this._context.Employees
                .Where(e => e.FirstName.Contains(nombre) || e.LastName.Contains(apellido))
                .ToListAsync();
        }

        public async Task<List<int>> ObtenerEmpleadoIDporTitulo(string titulo)
        {
            return await this._context.Employees
                .Where(e => e.Title.Contains(titulo))
                .Select(e => e.EmployeeID)
                .ToListAsync();
        }

        public async Task<Employee?> ObtenerEmpleadoPorPais(string pais)
        {
            return await this._context.Employees
                .Where(e => e.Country == pais)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Employee>> ObtenerTodosLosEmpleadosPorPais(string pais)
        {
            return await this._context.Employees
                .Where(e => e.Country == pais)
                .ToListAsync();
        }

        public async Task<List<Employee>> ObtenerElEmpleadoMasGrande()
        {
            return await this._context.Employees
                .OrderByDescending(e => e.BirthDate)
                .Take(1)
                .ToListAsync();
        }

        public async Task<Dictionary<string, int>> CantidadEmpleadosPorTitulos()
        {
            return await this._context.Employees
                .GroupBy(e => e.Title)
                .Select(g => new { Title = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.Title, x => x.Count);
        }

        public async Task<List<Products>> ObtenerProductosConCategoria()
        {
            return await this._context.Products.ToListAsync();
        }

        public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
        {
            return await this._context.Products
                .Where(p => p.ProductName.Contains(palabra))
                .ToListAsync();
        }
    }
 }
