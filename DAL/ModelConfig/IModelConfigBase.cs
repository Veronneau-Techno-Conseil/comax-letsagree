using System;
using Microsoft.EntityFrameworkCore;

namespace DAL.ModelConfig
{
    public interface IModelConfigBase
    {
        void ConfigureTables(ModelBuilder modelBuilder);
        
        void ConfigureFields(ModelBuilder modelBuilder);

        void ConfigureRelations(ModelBuilder modelBuilder);
    }
}
