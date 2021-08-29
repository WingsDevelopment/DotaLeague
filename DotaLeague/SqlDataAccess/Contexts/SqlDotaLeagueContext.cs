using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DotaLeague.Domain.Entities;
using SqlDataAccess.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataAccess.Contexts
{
    public class SqlDotaLeagueContext : IdentityDbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Player> Players { get; set; }

        public SqlDotaLeagueContext(DbContextOptions<SqlDotaLeagueContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new MatchConfiguration());
            modelBuilder.ApplyConfiguration(new ReportConfiguration());
            modelBuilder.ApplyConfiguration(new LeagueConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
