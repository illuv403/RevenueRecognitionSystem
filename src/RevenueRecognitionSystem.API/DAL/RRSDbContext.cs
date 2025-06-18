using Microsoft.EntityFrameworkCore;

namespace RevenueRecognitionSystem.DAL;

public class RRSDbContext : DbContext
{
    public RRSDbContext(DbContextOptions<RRSDbContext> options) : base(options) { }
}