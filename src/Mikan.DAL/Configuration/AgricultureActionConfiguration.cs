using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mikan.DAL.Models;

namespace Mikan.DAL.Configuration
{
   public class AgricultureActionConfiguration : IEntityTypeConfiguration<AgricultureAction>
    {
        public void Configure(EntityTypeBuilder<AgricultureAction> builder)
        {
            builder.HasKey(a => new { a.MachineId, a.ResourceId });
        }
    }
}
