using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Emp_ID);
            builder.ToTable("Employee", "dbo");
            builder.Property(e => e.Emp_ID).HasColumnName("Emp_ID");
            builder.Property(e => e.Emp_Name).HasColumnName("Emp_Name");
            builder.Property(e => e.Department).HasColumnName("Department");
            builder.Property(e => e.Company).HasColumnName("Company");
           
        }
    }
}