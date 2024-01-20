
using RankingManagementApp.Models;
using System.Data.Entity;


namespace RankingManagementApp.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection") { }

        public DbSet<Ranking> Rankings { get; set; }
    }
}