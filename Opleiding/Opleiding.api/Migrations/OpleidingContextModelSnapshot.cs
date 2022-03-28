﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Opleiding.api.DataLayer;

#nullable disable

namespace opleiding.api.Migrations
{
    [DbContext(typeof(OpleidingContext))]
    partial class OpleidingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Opleiding", b =>
                {
                    b.Property<Guid>("OpleidingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("OpleidingId");

                    b.HasIndex("Naam")
                        .IsUnique();

                    b.ToTable("Opleidingen");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Opo", b =>
                {
                    b.Property<Guid>("OpoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<int>("Fase")
                        .HasColumnType("int");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<Guid>("OpoVerantwoordelijkeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<int>("Stp")
                        .HasColumnType("int");

                    b.HasKey("OpoId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("OpoVerantwoordelijkeID")
                        .IsUnique();

                    b.ToTable("Opos");
                });

            modelBuilder.Entity("opleiding.api.Entitties.OpoDocent", b =>
                {
                    b.Property<Guid>("DocentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OpoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DocentId", "OpoId");

                    b.HasIndex("OpoId");

                    b.ToTable("OpoDocenten", (string)null);
                });

            modelBuilder.Entity("opleiding.api.Entitties.OpoOpleiding", b =>
                {
                    b.Property<Guid>("OpoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OpleidingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OpoId", "OpleidingId");

                    b.HasIndex("OpleidingId");

                    b.ToTable("OpleidingOpos", (string)null);
                });

            modelBuilder.Entity("opleiding.api.Entitties.OpoStudent", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OpoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "OpoId");

                    b.HasIndex("OpoId");

                    b.ToTable("OpoStudenten", (string)null);
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Persoon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Familienaam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persoon");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.PersoonRol", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("opleiding.api.Entitties.RefreshToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByIp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expires")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PersoonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ReplacedByToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Revoked")
                        .HasColumnType("datetime2");

                    b.Property<string>("RevokedByIp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersoonId");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Rol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Personeelslid", b =>
                {
                    b.HasBaseType("Opleiding.api.Entitties.Persoon");

                    b.Property<string>("Personnelsnummer")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasDiscriminator().HasValue("Personeelslid");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Student", b =>
                {
                    b.HasBaseType("Opleiding.api.Entitties.Persoon");

                    b.Property<string>("StudentenNummer")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Docent", b =>
                {
                    b.HasBaseType("Opleiding.api.Entitties.Personeelslid");

                    b.Property<string>("Vakdomein")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("Docent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Persoon", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Persoon", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Persoon", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Opleiding", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Docent", "Opleidingshoofd")
                        .WithOne("opleiding")
                        .HasForeignKey("Opleiding.api.Entitties.Opleiding", "OpleidingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Opleidingshoofd");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Opo", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Docent", "OpoVerantwoordelijke")
                        .WithOne("opo")
                        .HasForeignKey("Opleiding.api.Entitties.Opo", "OpoVerantwoordelijkeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("OpoVerantwoordelijke");
                });

            modelBuilder.Entity("opleiding.api.Entitties.OpoDocent", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Docent", "Docent")
                        .WithMany("OpoDocenten")
                        .HasForeignKey("DocentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opleiding.api.Entitties.Opo", "Opo")
                        .WithMany("OpoDocenten")
                        .HasForeignKey("OpoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Docent");

                    b.Navigation("Opo");
                });

            modelBuilder.Entity("opleiding.api.Entitties.OpoOpleiding", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Opleiding", "Opleiding")
                        .WithMany("OpoOpleiding")
                        .HasForeignKey("OpleidingId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opleiding.api.Entitties.Opo", "Opo")
                        .WithMany("OpoOpleiding")
                        .HasForeignKey("OpoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Opleiding");

                    b.Navigation("Opo");
                });

            modelBuilder.Entity("opleiding.api.Entitties.OpoStudent", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Opo", "Opo")
                        .WithMany("OpoStudenten")
                        .HasForeignKey("OpoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opleiding.api.Entitties.Student", "Student")
                        .WithMany("OpoStudenten")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Opo");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.PersoonRol", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Rol", "Rol")
                        .WithMany("PersoonRollen")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Opleiding.api.Entitties.Persoon", "Persoon")
                        .WithMany("PersoonRollen")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Persoon");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("opleiding.api.Entitties.RefreshToken", b =>
                {
                    b.HasOne("Opleiding.api.Entitties.Persoon", "Persoon")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("PersoonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persoon");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Opleiding", b =>
                {
                    b.Navigation("OpoOpleiding");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Opo", b =>
                {
                    b.Navigation("OpoDocenten");

                    b.Navigation("OpoOpleiding");

                    b.Navigation("OpoStudenten");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Persoon", b =>
                {
                    b.Navigation("PersoonRollen");

                    b.Navigation("RefreshTokens");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Rol", b =>
                {
                    b.Navigation("PersoonRollen");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Student", b =>
                {
                    b.Navigation("OpoStudenten");
                });

            modelBuilder.Entity("Opleiding.api.Entitties.Docent", b =>
                {
                    b.Navigation("OpoDocenten");

                    b.Navigation("opleiding")
                        .IsRequired();

                    b.Navigation("opo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
