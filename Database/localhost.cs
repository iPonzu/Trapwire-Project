using Microsoft.EntityFrameworkCore;
using System;

namespace MyData{
    public class Context : DbContext{





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=trapwire;user=root;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}