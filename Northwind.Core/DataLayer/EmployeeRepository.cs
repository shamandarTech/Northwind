﻿using System.Data.Entity;
using System.Linq;
using Northwind.Core.DataLayer.OperationContracts;
using Northwind.Core.EntityLayer;

namespace Northwind.Core.DataLayer
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public override Employee Get(Employee entity)
        {
            return DbSet
                .FirstOrDefault(item => item.EmployeeID == entity.EmployeeID);
        }
    }
}