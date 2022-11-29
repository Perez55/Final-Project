using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Final_Project.Models {

    internal class AboutConfig :IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> entity)
        {
            entity.HasData(
                 new About { AboutId = 1, Info = "Hello my name is hilbert" }
            );
        }
    }



}