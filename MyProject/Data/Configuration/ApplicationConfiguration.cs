using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Data.Configuration
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.HasKey(x => x.SupportId);
            builder.ToTable("Application", "dbo");
            builder.Property(e => e.AppId).HasColumnName("AppId");
            builder.Property(e => e.AppName).HasColumnName("AppName");
            builder.Property(e => e.AppObj).HasColumnName("AppObj");
            builder.Property(e => e.AppUrl).HasColumnName("AppUrl");
            builder.Property(e => e.Company).HasColumnName("Company");
            builder.Property(e => e.DocPath).HasColumnName("DocPath");
            builder.Property(e => e.FucDes).HasColumnName("FucDes");
            builder.Property(e => e.Remark).HasColumnName("Remark");
            builder.Property(e => e.Port).HasColumnName("Port");
            builder.Property(e => e.OcioName).HasColumnName("OcioName");
            builder.Property(e => e.DatabaseName).HasColumnName("DatabaseName");
            builder.Property(e => e.ProjectManager).HasColumnName("ProjectManager");
            builder.Property(e => e.Bu).HasColumnName("Bu");

            builder.Property(e => e.AppStatusName).HasColumnName("AppStatusName");
            builder.Property(e => e.AppStatus).HasColumnName("AppStatus");
            builder.Property(e => e.Department).HasColumnName("Department");
            builder.Property(e => e.OsSystem).HasColumnName("OsSystem");
            builder.Property(e => e.ServerType).HasColumnName("ServerType");
            builder.Property(e => e.Smtp).HasColumnName("Smtp");
            builder.Property(e => e.SoftwareVer).HasColumnName("SoftwareVer");

            builder.Property(e => e.Criticality).HasColumnName("Criticality");
        }
    }
}