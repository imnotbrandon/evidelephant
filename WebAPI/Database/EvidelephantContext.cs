using Evidelephant.WebAPI.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Evidelephant.WebAPI.Database;

public class EvidelephantContext : DbContext
{
    public EvidelephantContext(DbContextOptions<EvidelephantContext> options) : base(options)
    {
    }
    
    public DbSet<Evidence> Evidence { get; set; }
}