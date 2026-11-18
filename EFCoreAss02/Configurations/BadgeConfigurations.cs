using EFCoreAss02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAss02.Configurations
{
    internal class BadgeConfigurations : IEntityTypeConfiguration<Badge>
    {
        public void Configure(EntityTypeBuilder<Badge> builder)
        {
            builder.HasOne(s => s.Attendee)
                .WithOne(a => a.Badge)
                .HasForeignKey<Badge>(x => x.AttendeeId)
                .IsRequired();
                
        }
    }
}
