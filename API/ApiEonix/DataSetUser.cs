using ApiEonix.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEonix
{
    public class DataSetUser : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasData(
                new Users
                {
                    Id = Guid.NewGuid(),
                    Name = "Thomas",
                    LastName = "Lepoint"
                },
                new Users
                {
                    Id = Guid.NewGuid(),
                    Name = "Juste",
                    LastName = "Leblanc"
                }
                );
        }
    }
}
