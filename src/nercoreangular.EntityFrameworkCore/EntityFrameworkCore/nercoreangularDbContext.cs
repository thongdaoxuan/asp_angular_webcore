using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using nercoreangular.Authorization.Roles;
using nercoreangular.Authorization.Users;
using nercoreangular.MultiTenancy;

namespace nercoreangular.EntityFrameworkCore
{
    public class nercoreangularDbContext : AbpZeroDbContext<Tenant, Role, User, nercoreangularDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Models.Author> author { get; set; }

        public nercoreangularDbContext(DbContextOptions<nercoreangularDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>(nercoreangularConsts.prefix);

            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Models.Author>(entity =>
            {
                entity.ToTable(typeof(Models.Author).Name);
                entity.Property(e => e.au_code).HasDefaultValueSql("''");
                entity.Property(e => e.au_name).HasDefaultValueSql("''");
                entity.Property(e => e.au_dob).HasDefaultValueSql("''");
                entity.Property(e => e.au_address).HasDefaultValueSql("''");
                entity.Property(e => e.au_decs).HasDefaultValueSql("''");
                entity.Property(e => e.au_email).HasDefaultValueSql("''");
                entity.Property(e => e.au_academic_rank).HasDefaultValueSql("''");
                entity.Property(e => e.au_degree).HasDefaultValueSql("''");
                entity.Property(e => e.au_pen_name).HasDefaultValueSql("''");
                entity.Property(e => e.au_infor).HasDefaultValueSql("'{}'");
                entity.Property(e => e.au_is_deleted).HasDefaultValueSql("0");
                entity.Property(e => e.fi_id).HasDefaultValueSql("'[]'");
                entity.Property(e => e.au_created_at).HasDefaultValueSql("  ( GETDATE() )  ");
                entity.Property(e => e.au_updated_at).HasDefaultValueSql("  ( GETDATE() )  ");
            });
        }
    }
}
