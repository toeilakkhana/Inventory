using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Data.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Customer_Id);
            builder.ToTable("Customer", "dbo");
            builder.Property(e => e.Customer_Id).HasColumnName("Customer_Id");
            builder.Property(e => e.Customer_Name).HasColumnName("Customer_Name");
            builder.Property(e => e.Customer_Department).HasColumnName("Customer_Department");
            builder.Property(e => e.Customer_Company).HasColumnName("Customer_Company");
           
        }
    }
}