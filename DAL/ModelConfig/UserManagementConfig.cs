using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.ModelConfig
{
    public class UserManagementConfig : IModelConfigBase
    {
        public void ConfigureFields(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(x=>x.Id);

            modelBuilder.Entity<User>()
                .HasIndex(x=>x.AccountId)
                .IsUnique()
                .IncludeProperties("Id", "Name", "UserType");

            modelBuilder.Entity<UserType>()
                .HasKey(x=>x.Id);
            
            modelBuilder.Entity<UserType>()
                .HasIndex(x=>x.Code)
                .IsUnique();
        }

        public void ConfigureRelations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne<UserType>(x=>x.UserType)
                .WithMany(x=>x.Users)
                .HasForeignKey(x=>x.UserTypeId);

            modelBuilder.Entity<User>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(c=>c.ParentId);
        }

        public void ConfigureTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Users");

            modelBuilder.Entity<UserType>()
                .ToTable("UserTypes");
        }
    }
}
