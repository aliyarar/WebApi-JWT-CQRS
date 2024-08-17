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

        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<AppUser> AppUsers => this.Set<AppUser>();
        public DbSet<AppRole> AppRoles => this.Set<AppRole>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguation());
            base.OnModelCreating(modelBuilder);
        }
    }
}
