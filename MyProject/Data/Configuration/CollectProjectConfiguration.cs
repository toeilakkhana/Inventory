using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Data.Configuration
{
    public class CollectProjectConfiguration : IEntityTypeConfiguration<CollectProject>
    {
        public void Configure(EntityTypeBuilder<CollectProject> builder)
        {
            builder.HasKey(x => x.JobCode);
            builder.ToTable("CollectProject", "dbo");
            builder.Property(t => t.JobCode).HasColumnName("JobCode");
            builder.Property(t => t.ProjectName).HasColumnName("ProjectName");
            builder.Property(t => t.JobName).HasColumnName("JobName");
            builder.Property(t => t.Revenue).HasColumnName("Revenue");
            builder.Property(t => t.NumSR).HasColumnName("NumSR");
            builder.Property(t => t.NumPOT).HasColumnName("NumPOT");
            builder.Property(t => t.BusinessUnit).HasColumnName("BusinessUnit");
            builder.Property(t => t.BusinessAnalyst).HasColumnName("BusinessAnalyst");
            builder.Property(t => t.ProjectManager).HasColumnName("ProjectManager");
            builder.Property(t => t.ProjectStatus).HasColumnName("ProjectStatus");
            builder.Property(t => t.Type).HasColumnName("Type");
            builder.Property(t => t.PlanStartDate).HasColumnName("PlanStartDate");
            builder.Property(t => t.PlanEndDate).HasColumnName("PlanEndDate");
            builder.Property(t => t.ActualStartDate).HasColumnName("ActualStartDate");
            builder.Property(t => t.ActualEndDate).HasColumnName("ActualEndDate");

        }
    }
}
