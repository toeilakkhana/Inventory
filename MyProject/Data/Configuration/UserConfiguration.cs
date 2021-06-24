using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.User_Id);
            builder.ToTable("User", "dbo");
            builder.Property(e => e.User_Email).HasColumnName("User_Email");
            builder.Property(e => e.User_Pass).HasColumnName("User_Pass");
           
           
        }
    }
}