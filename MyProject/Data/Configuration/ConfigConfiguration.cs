using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Configuration
{
    public class ConfigConfiguration : IEntityTypeConfiguration<Config>
    {
        public void Configure(EntityTypeBuilder<Config> builder)
        {
            
            builder.ToTable("Config", "dbo");
            builder.Property(t => t.Conf_Code).HasColumnName("Conf_Code");
            builder.Property(t => t.Conf_Description).HasColumnName("Conf_Description");
            builder.Property(t => t.Conf_System).HasColumnName("Conf_System");
            builder.Property(t => t.Conf_Type).HasColumnName("Conf_Type");
           
        }
    }
    
    
}
