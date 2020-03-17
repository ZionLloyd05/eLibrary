using eLibrary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eLibrary.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<eLibraryContext>
    {

        public eLibraryContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<eLibraryContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-UU6UAJD;Database=Library_Devdb;Trusted_Connection=True");

            return new eLibraryContext(optionsBuilder.Options);
        }
    }
}
