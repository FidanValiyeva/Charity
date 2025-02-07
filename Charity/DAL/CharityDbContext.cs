using Charity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Charity.DAL
{
    public class CharityDbContext:IdentityDbContext
    {
           public DbSet<Donor> Donors { get; set; }  
        public CharityDbContext(DbContextOptions opt) : base(opt)
        {
        }

    }
}
