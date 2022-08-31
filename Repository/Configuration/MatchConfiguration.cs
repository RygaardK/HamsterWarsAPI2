using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Configuration
{
    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasData
                (
                new Match
                {
                    Id = 1,
                    WinnerId = 1,
                    LoserId = 2,
                    Timestamp = DateTime.Now,
                },
                new Match
                {
                    Id = 2,
                    WinnerId = 2,
                    LoserId = 4,
                    Timestamp = DateTime.Now,

                });
        }
    }
}