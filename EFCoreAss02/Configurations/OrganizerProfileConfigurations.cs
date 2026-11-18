using EFCoreAss02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAss02.Configurations
{
    internal class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {
        public void Configure(EntityTypeBuilder<OrganizerProfile> builder)
        {
            builder.HasOne(x => x.Organizer)
                .WithOne(y => y.OrganizerProfile)
                .HasForeignKey<OrganizerProfile>(s => s.OrganizerId)
                .IsRequired();

        }
    }
}
