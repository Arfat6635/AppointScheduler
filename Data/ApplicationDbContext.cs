using Microsoft.EntityFrameworkCore;

namespace AppointmentScheduler.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ):base(options)
        {
            
        }
        
        
    }
}
