using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Project.Models
{
    internal class HobbyConfig : IEntityTypeConfiguration<Hobby>
    {
        public void Configure(EntityTypeBuilder<Hobby> entity)
        {
           entity.HasData (
            new Hobby { HobbyId = 1, HobbyName = "Art", Desc = "Art is the best", AdminId = 1}
           );
        }
    }
}