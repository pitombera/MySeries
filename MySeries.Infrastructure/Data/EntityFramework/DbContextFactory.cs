﻿using Microsoft.EntityFrameworkCore;

namespace MySeries.Infrastructure.Data.EntityFramework
{
    public class DbContextFactory : DesignTimeDbContextFactoryBase<ApplicationDbContext>
    {
        protected override ApplicationDbContext CreateNewInstance(DbContextOptions<ApplicationDbContext> options)
        {
            return new ApplicationDbContext(options);
        }
    }
}