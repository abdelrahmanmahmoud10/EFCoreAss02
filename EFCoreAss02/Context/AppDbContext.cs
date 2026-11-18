using EFCoreAss02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreAss02.Context
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFAssignment02;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Event>()
                .HasOne(x => x.Organizer)
                .WithMany(z => z.Events)
                .HasForeignKey(f => f.OrganizerId)
                .IsRequired();
        }


        DbSet<Organizer> Organizers { get; set; }
        DbSet<OrganizerProfile> organizerProfiles { get; set; }
        DbSet<Event> Events { get; set; }
        DbSet<Badge> Badges { get; set; }
        DbSet<Attendee> Attendees { get; set; }

    }
}
