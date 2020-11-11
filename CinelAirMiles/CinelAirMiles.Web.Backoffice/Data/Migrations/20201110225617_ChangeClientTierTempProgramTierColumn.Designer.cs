﻿// <auto-generated />
using System;
using CinelAirMiles.Common.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CinelAirMiles.Web.Backoffice.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201110225617_ChangeClientTierTempProgramTierColumn")]
    partial class ChangeClientTierTempProgramTierColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CinelAirMiles.Common.Entities.ChangeClientTierTemp", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId");

                    b.Property<int?>("ProgramTierId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ProgramTierId");

                    b.ToTable("ChangeClientsTierTemp");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("FlownSegments");

                    b.Property<bool>("IsInReferrerProgram");

                    b.Property<DateTime>("MembershipDate");

                    b.Property<string>("MilesProgramNumber");

                    b.Property<int>("ProgramTierId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProgramTierId");

                    b.HasIndex("UserId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.ContactForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ContactForms");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.CreditCardInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CVC");

                    b.Property<int>("ClientId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Month");

                    b.Property<string>("Number");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("CreditCardsInfo");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Mile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("CreditDate");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ExpiryDate");

                    b.Property<int>("Miles");

                    b.Property<int>("MilesTypeId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MilesTypeId")
                        .IsUnique();

                    b.ToTable("Miles");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.MilesTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId");

                    b.Property<int?>("MileId");

                    b.Property<DateTime>("TransactionDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MileId");

                    b.ToTable("MilesTransactions");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.MilesType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("MilesTypes");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsRead");

                    b.Property<int>("NotificationTypeId");

                    b.Property<int>("TempTableId");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("NotificationTypeId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.NotificationType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("NotificationsTypes");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.NotificationUser", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("UserId");

                    b.HasKey("Id", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("NotificationsUsers");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.ProgramTier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("ProgramTiers");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.ReferrerProgram", b =>
                {
                    b.Property<int>("ReferredClientId");

                    b.Property<int>("ReferrerClientId");

                    b.HasKey("ReferredClientId", "ReferrerClientId");

                    b.HasIndex("ReferredClientId")
                        .IsUnique();

                    b.HasIndex("ReferrerClientId")
                        .IsUnique();

                    b.ToTable("ReferrersProgram");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MainRole");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<bool>("RequirePasswordChange");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.ChangeClientTierTemp", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("CinelAirMiles.Common.Entities.ProgramTier", "ProgramTier")
                        .WithMany()
                        .HasForeignKey("ProgramTierId");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Client", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.ProgramTier", "ProgramTier")
                        .WithMany()
                        .HasForeignKey("ProgramTierId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinelAirMiles.Common.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.CreditCardInfo", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Mile", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.Client", "Client")
                        .WithMany("Miles")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinelAirMiles.Common.Entities.MilesType", "MilesType")
                        .WithOne()
                        .HasForeignKey("CinelAirMiles.Common.Entities.Mile", "MilesTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.MilesTransaction", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("CinelAirMiles.Common.Entities.Mile", "Mile")
                        .WithMany()
                        .HasForeignKey("MileId");
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.Notification", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.NotificationType", "NotificationType")
                        .WithMany()
                        .HasForeignKey("NotificationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.NotificationUser", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.Notification", "Notification")
                        .WithMany("NotificationUsers")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinelAirMiles.Common.Entities.User", "User")
                        .WithMany("NotificationUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CinelAirMiles.Common.Entities.ReferrerProgram", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.Client", "ReferredClient")
                        .WithOne()
                        .HasForeignKey("CinelAirMiles.Common.Entities.ReferrerProgram", "ReferredClientId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CinelAirMiles.Common.Entities.Client", "ReferrerClient")
                        .WithOne()
                        .HasForeignKey("CinelAirMiles.Common.Entities.ReferrerProgram", "ReferrerClientId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CinelAirMiles.Common.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CinelAirMiles.Common.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
