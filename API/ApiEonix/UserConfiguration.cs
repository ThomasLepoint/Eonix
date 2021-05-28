using ApiEonix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEonix
{
    public class UserConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Contact");
            builder.HasKey("Id");
            builder.Property(nameof(Users.Id)).ValueGeneratedOnAdd();
            builder.Property(nameof(Users.Name)).IsRequired();
            builder.Property(nameof(Users.LastName)).IsRequired();

        }
    }
}
