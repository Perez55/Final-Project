using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Project.Models
{
    internal class AdminHobbyConfig : IEntityTypeConfiguration<AdminHobby>
    {
        public void Configure(EntityTypeBuilder<AdminHobby> entity)
        {
           entity.HasData (
            new AdminHobby {AdminHobbyId=1, HobbyId = 1, AdminId = 1}
           );
        }
    }
}