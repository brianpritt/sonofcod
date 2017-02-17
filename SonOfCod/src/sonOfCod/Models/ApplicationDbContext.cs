using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace sonOfCod.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<MailingList> Inventories { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}