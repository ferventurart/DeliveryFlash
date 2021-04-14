﻿using ApplicationCore.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;

namespace Infraestructure.Data.Repositories
{
    public class MyRepository<T> : RepositoryBase<T>, IRepository<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public MyRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        // Not required to implement anything. Add additional functionalities if required.
    }
}
