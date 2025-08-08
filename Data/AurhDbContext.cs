using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Test.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var readerId = "e419084b-b0d2-4b1a-8d43-445d16e54e1f";
            var writerId = "10889dac-54c8-45c9-b6a0-fddbae5aba17";
            var roles = new List<IdentityRole>
            {
                new IdentityRole {
                    Id = readerId,
                    ConcurrencyStamp = readerId,
                    Name = "Reader",
                    NormalizedName = "Reader"
                },
                new IdentityRole {
                    Id = writerId,
                    ConcurrencyStamp = writerId,
                    Name = "Writer",
                    NormalizedName = "Writer"
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}