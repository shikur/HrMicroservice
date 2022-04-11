using HR.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR.API.data
{
    public class HrContextSeed
    {
        public static void SeeData(IMongoCollection<Entities.Employees> employeeConllection)
        {
            bool existEmployees = employeeConllection.Find(e => true).Any();

            if(!existEmployees)
            {
                employeeConllection.InsertMany(GetConfigureEmployee());
            }
        }

        private static IEnumerable<Employees> GetConfigureEmployee()
        {
            return new List<Employees>()
            {
                new Employees()
                {
                    firstName="shikur",

                },

                 new Employees()
                {
                    firstName="oumer",

                },
                  new Employees()
                {
                    firstName="sinna",

                },


            };
        }
    }
}
