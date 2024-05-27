using Microsoft.EntityFrameworkCore;
using WebApi_JWT_CQRS.Api.Core.Domain;
using WebApi_JWT_CQRS.Api.Persistance.Configurations;

namespace WebApi_JWT_CQRS.Api.Persistance.Context
{
    public class JwtCqrsContext: DbContext
    {
        public JwtCqrsContext(DbContextOptions<JwtCqrsContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguation());
            base.OnModelCreating(modelBuilder);
        }
    }
}
