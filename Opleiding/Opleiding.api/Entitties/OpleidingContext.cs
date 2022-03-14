using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using opleiding.api.Entitties;
using Opleiding.api.Entitties;

namespace Opleiding.api.DataLayer
{

    public class OpleidingContext : IdentityDbContext<
        Persoon,
        Rol,
        Guid,
        IdentityUserClaim<Guid>,
        PersoonRol,
        IdentityUserLogin<Guid>,
        IdentityRoleClaim<Guid>,
        IdentityUserToken<Guid>>
    {
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Student> Studenten { get; set; }
        public DbSet<Opo> Opos { get; set; }
        public DbSet<Entitties.Opleiding> Opleidingen { get; set; }
        public DbSet<Personeelslid> Personeelsleden { get; set; }
        public DbSet<OpoStudent> OpoStudenten { get; set; }
        public DbSet<OpoDocent> OpoDocenten { get; set; }
        public DbSet<OpoOpleiding> OpleidingOpos { get; set; }


        public OpleidingContext(DbContextOptions<OpleidingContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            if (builder == null) { throw new ArgumentNullException(nameof(builder)); }

            builder.Entity<PersoonRol>(p =>
            {
                
                p.HasOne(p => p.Persoon)
                .WithMany(p => p.PersoonRollen)
                .HasForeignKey(p => p.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


                p.HasOne(r => r.Rol)
                .WithMany(r => r.PersoonRollen)
                .HasForeignKey(r => r.RoleId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

                p.HasIndex(p => p.RoleId).IsUnique();
                p.HasIndex(p => p.UserId).IsUnique();
            });

            builder.Entity<OpoStudent>(s =>
            {
                s.ToTable("OpoStudenten");
                s.HasKey(s => new { s.StudentId, s.OpoId });
                s.HasIndex(s => s.StudentId).IsUnique();

            });
                

            builder.Entity<OpoStudent>(o =>
            {
                o.HasOne(o => o.Student)
                .WithMany(o => o.OpoStudenten)
                .HasForeignKey(o => o.StudentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


                o.HasOne(o => o.Opo)
                .WithMany(o => o.OpoStudenten)
                .HasForeignKey(o => o.OpoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<OpoDocent>(s =>
            {
                s.ToTable("OpoDocenten");
                s.HasKey(d => new { d.DocentId, d.OpoId });
                s.HasIndex(s => s.DocentId).IsUnique();
            });
                

            builder.Entity<OpoDocent>(o =>
            {
                o.HasOne(o => o.Docent)
                .WithMany(o => o.OpoDocenten)
                .HasForeignKey(o => o.DocentId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);


                o.HasOne(o => o.Opo)
                .WithMany(o => o.OpoDocenten)
                .HasForeignKey(o => o.OpoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<OpoOpleiding>(s =>
            {
                s.ToTable("OpleidingOpos");
                s.HasKey(s => new { s.OpoId, s.OpleidingId });
                s.HasIndex(s => s.OpleidingId).IsUnique();
            });
                

            builder.Entity<OpoOpleiding>(o =>
            {
                o.HasOne(o => o.Opleiding)
                .WithMany(o => o.OpoOpleiding)
                .HasForeignKey(o => o.OpleidingId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

                o.HasOne(o => o.Opo)
                .WithMany(o => o.OpoOpleiding)
                .HasForeignKey(o => o.OpoId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            });
        }}}
