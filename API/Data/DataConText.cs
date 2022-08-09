using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataConText : DbContext
    {
        public DataConText(DbContextOptions options) : base(options)
        {
        }
        public DbSet<AppUser> Users { get; set; }
    }
}