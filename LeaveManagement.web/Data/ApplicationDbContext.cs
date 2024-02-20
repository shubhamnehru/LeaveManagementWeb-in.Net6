using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.web.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>  // ApplicationDbContext is really a bridge b/w what the DB tables look like and 
                                                                     // capable of and how and what c# code wants it to see from the database
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}