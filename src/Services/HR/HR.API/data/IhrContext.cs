using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;

using HR.API.Entities;

namespace HR.API.data
{
    public interface IhrContext
    {
        IMongoCollection<Employees> Employees { get; }
    }
}
