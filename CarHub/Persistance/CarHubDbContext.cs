using CarHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CarHub.Persistance
{
    public class CarHubDbContext : DbContext
    {
    public CarHubDbContext(DbContextOptions<CarHubDbContext> options)
    :base(options)
    {
    }
    public DbSet<Make> Makes { get; set; }
       
    }
}