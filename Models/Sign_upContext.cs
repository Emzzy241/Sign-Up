using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sign_up.Models;

public class Sign_upContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<SignUp> SignUp { get; set; }
    public Sign_upContext(DbContextOptions options) : base(options) { }
}