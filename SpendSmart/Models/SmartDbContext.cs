using Microsoft.EntityFrameworkCore;

namespace SpendSmart.Models
{
    public class SmartDbContext:DbContext
    {
        public SmartDbContext(DbContextOptions<SmartDbContext>options):base(options) {
        }
        public DbSet<Expense> Expenses { get; set; }    
       
    }
}
