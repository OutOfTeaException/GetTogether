using GetTogether.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace GetTogether.Data
{
    public class GetTogetherContext : DbContext
    {
        public GetTogetherContext(DbContextOptions<GetTogetherContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<DateProposal> DateProposals { get; set; }
        public DbSet<DateSearch> DateSearches { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserGroup>()
                .HasKey(t => new { t.UserId, t.GroupId });
                
            CreateSeedData(modelBuilder);
            
            base.OnModelCreating(modelBuilder);
        }

        private void CreateSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group>().HasData(
                new { Id = 1, Name = "Die Wandersleut", CreatedAt = new DateTime(2018, 05, 01, 12, 00, 00) },
                new { Id = 2, Name = "Kino", CreatedAt = new DateTime(2018, 05, 01, 12, 00, 00) }
                );

            modelBuilder.Entity<DateSearch>().HasData(
                new { Id = 1, GroupId = 1, Name = "Lüneburger Heide", Description = "Zur Heideblüte in die Lüneburger Heide", CreatedAt = new DateTime(2018, 05, 01, 12, 00, 00) },
                new { Id = 2, GroupId = 2, Name = "Deadpool 2", Description = "Sehr böse :)", CreatedAt = new DateTime(2018, 05, 01, 12, 00, 00) }
                );
        }
    }
}
