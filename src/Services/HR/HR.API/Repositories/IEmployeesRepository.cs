using HR.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.API.Repositories
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<Employees>> GetEmployees();
    }
}
