using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Project.Models
{
    internal class HobbiesConfig : IEntityTypeConfiguration<Hobbies>
    {
        public void Configure(EntityTypeBuilder<Hobbies> entity)
        {
            entity.HasData(
                new Hobbies { HobbyId = 1, Hobby = "Art", Desc = "Art is the best", UserId = 1 }
            );
        }
    }
}