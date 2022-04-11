using HR.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.API.data
{
    public class HrContext : IhrContext
    {
        public HrContext(IConfiguration configration)
        {
            var client = new MongoClient(configration.GetValue<string>("DatabaseSettings:ConnectionString"));
            var database = client.GetDatabase(configration.GetValue<string>("DatabaseSettings:hrdata"));

            Employees = database.GetCollection<Employees>(configration.GetValue<string>("DatabaseSettings:CollectionName"));
            HrContextSeed.SeeData(Employees);


        }
        public IMongoCollection<Employees> Employees { get; }

    }
}
