using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqlDataAccess.EntityConfigurations
{
    public class PlayerShortConfiguration : IEntityTypeConfiguration<PlayerShort>
    {
        public void Configure(EntityTypeBuilder<PlayerShort> builder)
        {

        }
    }
}
