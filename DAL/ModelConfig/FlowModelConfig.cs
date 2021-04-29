using System;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.ModelConfig
{
    public class FlowModelConfig : IModelConfigBase
    {
        public void ConfigureFields(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityType>()
                .ToTable("EntityTypes")
                .HasKey(x => x.Id);
            modelBuilder.Entity<EntityType>()
                .HasIndex(x => x.Name)
                .IncludeProperties("Id")
                .IsUnique();

            modelBuilder.Entity<EntityAttribute>()
                .ToTable("EntityAttributes")
                .HasKey(x => x.Id);
            modelBuilder.Entity<EntityAttribute>()
                .HasIndex(x => x.Name)
                .IsUnique()
                .IncludeProperties(
                    "Id",
                    "EntityTypeId",
                    "ValueTypeId",
                    "ActionTypeId",
                    "TranslationId",
                    "Index"
                );

            modelBuilder.Entity<EntityAttribute>()
                .HasIndex(x => x.TranslationId)
                .IsUnique();

            modelBuilder.Entity<EntityAttribute>()
                .HasIndex("Index", "EntityTypeId")
                .IsUnique();

            modelBuilder.Entity<Models.ValueType>()
                .ToTable("ValueTypes")
                .HasKey(x=>x.Id);
            
            modelBuilder.Entity<Models.ValueType>()
                .HasIndex(x=>x.Name)
                .IsUnique()
                .IncludeProperties("Id", "Component", "TranslationId", "LookupCode");

            modelBuilder.Entity<Models.ActionType>()
                .HasKey(x=>x.Id);

            modelBuilder.Entity<Models.ActionType>()
                .HasIndex(x=>x.Name)
                .IsUnique()
                .IncludeProperties("Id", "Component");

            modelBuilder.Entity<Models.Lookup>()
                .ToTable("Lookups")
                .HasKey(x=>x.Id);
            
            modelBuilder.Entity<Models.Lookup>()
                .HasIndex("ValueTypeId", "TranslationId")
                .IsUnique();

            modelBuilder.Entity<Models.Translation>()
                .ToTable("Translations")
                .HasKey(x=>x.Id);
            
            modelBuilder.Entity<Models.Translation>()
                .HasIndex("Code", "LanguageCode")
                .IsUnique()
                .IncludeProperties("Value", "Id");

            modelBuilder.Entity<Models.Language>()
                .ToTable("Languages")
                .HasKey(x=>x.Id);
            
            modelBuilder.Entity<Models.Language>()
                .HasIndex("Code")
                .IsUnique()
                .IncludeProperties("Name", "Id");

        }

        public void ConfigureRelations(ModelBuilder modelBuilder)
        {
            
        }

        public void ConfigureTables(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<EntityType>()
                .ToTable("EntityTypes");
            modelBuilder.Entity<EntityAttribute>()
                .ToTable("EntityAttributes");
            modelBuilder.Entity<Models.ValueType>()
                .ToTable("ValueTypes");
            modelBuilder.Entity<Models.ActionType>()
                .ToTable("ActionTypes");
            modelBuilder.Entity<Models.Lookup>()
                .ToTable("Lookups");
            modelBuilder.Entity<Models.Translation>()
                .ToTable("Translations");
            modelBuilder.Entity<Models.Language>()
                .ToTable("Languages");
        }
    }
}