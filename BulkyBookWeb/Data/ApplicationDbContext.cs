

using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext :DbContext

    /*
     * private ApplicationDbContext _context;
     * _context = new ApplicationDbContext();
     * var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
    optionsBuilder.UseSqlServer(Configuration.GetConnectionStringSecureValue("DefaultConnection"));
    _context = new ApplicationDbContext(optionsBuilder.Options); */

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
