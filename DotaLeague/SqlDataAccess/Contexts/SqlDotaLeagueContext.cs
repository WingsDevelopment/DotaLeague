using DotaLeague.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using SqlDataAccess.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataAccess.Contexts
{
    public class SqlDotaLeagueContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }

        public SqlDotaLeagueContext(DbContextOptions<SqlDotaLeagueContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new MatchConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new LeagueConfiguration());
        }
    }
}
