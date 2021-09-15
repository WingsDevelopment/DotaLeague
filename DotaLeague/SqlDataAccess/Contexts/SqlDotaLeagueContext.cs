using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DotaLeague.Domain.Entities;
using SqlDataAccess.EntityConfigurations;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using DotaLeague.Domain.Entities.MatchEntities;

namespace SqlDataAccess.Contexts
{
    public class SqlDotaLeagueContext : IdentityDbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<PlayerShort> Queue { get; set; }

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
            modelBuilder.ApplyConfiguration(new PlayerShortConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
