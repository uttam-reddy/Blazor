using Blazor.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
                
        }

        public DbSet<Users> Users { get; set; }
    }
}
