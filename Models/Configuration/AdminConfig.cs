using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Project.Models
{
    internal class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> entity)
        {
            entity.HasData(
                 new Admin { AdminId = 1, FirstName = "Hilbert", LastName = "Perez", AboutId = 1}
            );
        }
    }
}