using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFcoreApp.Controllers
{
    public class AppDbContext:DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
    }
}
