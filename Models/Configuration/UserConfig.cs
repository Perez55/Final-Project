using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Project.Models
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasData(
                 new User { UserId = 1, FirstName = "John", LastName = "Doe", UserName = "jdoe", Password = "joe", Desc = "I am Smart"}
            );
        }
    }
}