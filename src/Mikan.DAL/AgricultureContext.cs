using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Mikan.DAL.Models;

namespace Mikan.DAL
{
  public class AgricultureContext : DbContext
  {
    public AgricultureContext(DbContextOptions<AgricultureContext> options) : base(options)
    {
    }

    public DbSet<AgricultureAction> Action { get; set; }
    public DbSet<MainResource> MainResource { get; set; }
    public DbSet<MechanicalResource> MechanicalResource { get; set; }
    public DbSet<MechanicalResourceByYear> MechanicalResourceByYear { get; set; }
    public DbSet<Resource> Resource { get; set; }
    public DbSet<ResourceAction> ResourceAction { get; set; }
    public DbSet<ResourceSubType> ResourceSubType { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}
