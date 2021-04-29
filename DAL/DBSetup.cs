using System;
using Microsoft.EntityFrameworkCore;
using EFCore.NamingConventions;

namespace DAL
{
    public static class DBSetup
    {
        public static void Setup(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseNpgsql("Conn here")
                .UseSnakeCaseNamingConvention();
        }

        
    }
}
