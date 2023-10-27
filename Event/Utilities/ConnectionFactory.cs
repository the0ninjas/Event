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
        public DbSet<CreatedEvent> CreatedEvents { get; set; }
        public DbSet<JoinedEvent> JoinedEvents { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection String
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EventDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Copmposite primary key of EventId and UserId
            
            modelBuilder.Entity<CreatedEvent>()
                .HasKey(eu => new { eu.eventId, eu.userEmail});
            modelBuilder.Entity<JoinedEvent>()
                .HasKey(eu => new { eu.eventId, eu.userEmail });
        }

    }
}
