using EventManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventManagementSystem.Utilities
{
    public class ConnectionFactory : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<Attendee> Attendees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection String
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EventDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendee>()
                .HasKey(eu => new { eu.EventId, eu.UserId });
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Event>()
        //        .HasMany(e => e.Attendees)
        //        .WithMany(u => u.AttendingEvents)
        //        .Map(m =>
        //        {
        //            m.MapLeftKey("EventId");
        //            m.MapRightKey("UserId");
        //            m.ToTable("EventAttendees");
        //        });
        //}

    }
}
