using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class AgreeUponContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            DBSetup.Setup(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            
        }

        #region dbsets

            public DbSet<ActionType> ActionTypes {get;set;}

            public DbSet<Entity> Entities {get;set;}

            public DbSet<EntityAttribute> EntityAttributes {get;set;}

            public DbSet<EntityType> EntityTypes {get;set;}

            public DbSet<Flow> Flows {get;set;}

            public DbSet<Language> Languages {get;set;}

            public DbSet<Lookup> Lookups {get;set;}

            public DbSet<Translation> Translations {get;set;}

            public DbSet<User> Users {get;set;}

            public DbSet<UserType> UserTypes {get;set;}

            public DbSet<Models.ValueType> ValueTypes {get;set;}

        #endregion
    }
}
