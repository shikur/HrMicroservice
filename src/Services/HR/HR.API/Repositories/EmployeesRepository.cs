using HR.API.data;
using HR.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.API.Repositories
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly IhrContext _hrContext;

        public EmployeesRepository(IhrContext context)
        {
            _hrContext = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<IEnumerable<Employees>> GetEmployees()
        {
            return await _hrContext.Employees.Find(p => true).ToListAsync();
              
        }
    }
}
