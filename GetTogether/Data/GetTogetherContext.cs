using GetTogether.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
