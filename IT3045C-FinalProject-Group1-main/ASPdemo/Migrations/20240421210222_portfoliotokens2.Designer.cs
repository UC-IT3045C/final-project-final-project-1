﻿// <auto-generated />
using System;
using ASPdemo.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPdemo.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240421210222_portfoliotokens2")]
    partial class portfoliotokens2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("ASPdemo.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AvgPriceChange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CMCCategoryId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<double>("LastUpdated")
                        .HasColumnType("REAL");

                    b.Property<string>("MarketCap")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MarketCapChange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumTokens")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Volume")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("VolumeChange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ASPdemo.Entities.Conversion", b =>
                {
                    b.Property<int>("ConversionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double?>("MarketCap")
                        .HasColumnType("REAL");

                    b.Property<string>("Pair1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pair2")
                        .HasColumnType("TEXT");

                    b.Property<double?>("PercentChange1hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange24Hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange7d")
                        .HasColumnType("REAL");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("SecondDescription")
                        .HasColumnType("TEXT");

                    b.Property<double?>("SecondMarketCap")
                        .HasColumnType("REAL");

                    b.Property<double?>("SecondPercentChange1hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("SecondPercentChange24Hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("SecondPercentChange7d")
                        .HasColumnType("REAL");

                    b.Property<double?>("SecondPrice")
                        .HasColumnType("REAL");

                    b.Property<double?>("SecondTotalSupply")
                        .HasColumnType("REAL");

                    b.Property<double?>("SecondVolume24")
                        .HasColumnType("REAL");

                    b.Property<double?>("TotalSupply")
                        .HasColumnType("REAL");

                    b.Property<double?>("Volume24")
                        .HasColumnType("REAL");

                    b.HasKey("ConversionId");

                    b.ToTable("Conversions");
                });

            modelBuilder.Entity("ASPdemo.Entities.CurrenciesPortfolios", b =>
                {
                    b.Property<int>("CurrenciesPortfoliosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CurrenciesPortfoliosId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("PortfolioId");

                    b.ToTable("CurrenciesPortfolios");
                });

            modelBuilder.Entity("ASPdemo.Entities.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CMCId")
                        .HasColumnType("TEXT");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CurrencyName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double?>("MarketCap")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange1hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange24Hr")
                        .HasColumnType("REAL");

                    b.Property<double?>("PercentChange7d")
                        .HasColumnType("REAL");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Slug")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Symbol")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<double?>("TotalSupply")
                        .HasColumnType("REAL");

                    b.Property<double?>("Volume24")
                        .HasColumnType("REAL");

                    b.HasKey("CurrencyId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("ASPdemo.Entities.Portfolio", b =>
                {
                    b.Property<int>("PortfolioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("PortfolioValue")
                        .HasColumnType("REAL");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WalletAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PortfolioId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Portfolios");
                });

            modelBuilder.Entity("ASPdemo.Entities.PortfolioToken", b =>
                {
                    b.Property<int>("PortfolioTokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TokenAmount")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TokenName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PortfolioTokenId");

                    b.ToTable("PortfolioToken");
                });

            modelBuilder.Entity("ASPdemo.Entities.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "a94c3698-13e4-4c98-ba3a-be341f99f3c9",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("ASPdemo.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<int>("PermissionsLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PortfolioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7b2167f2-1fc8-4245-89f2-837ef86c3408",
                            Email = "grantrynders@outlook.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "GRANTRYNDERS@OUTLOOK.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAEA+4RxxlhWrUAsrpZ09k+etnk+XcOo2I9jEHM711r/UPXSlMeu9NZiAtcuvk2OUfxw==",
                            PermissionsLevel = 0,
                            PhoneNumberConfirmed = false,
                            PortfolioId = 0,
                            SecurityStamp = "b7cb266c-a44a-4c0f-9fa7-e3e2adf3a1d5",
                            TwoFactorEnabled = false,
                            UserId = 0,
                            UserName = "admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IdentityRoleClaim<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IdentityUserClaim<string>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<string>("RolesId")
                        .HasColumnType("TEXT");

                    b.Property<string>("UsersId")
                        .HasColumnType("TEXT");

                    b.HasKey("RolesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("ASPdemo.Entities.CurrenciesPortfolios", b =>
                {
                    b.HasOne("ASPdemo.Entities.Currency", "currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPdemo.Entities.Portfolio", "portfolio")
                        .WithMany()
                        .HasForeignKey("PortfolioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("currency");

                    b.Navigation("portfolio");
                });

            modelBuilder.Entity("ASPdemo.Entities.Currency", b =>
                {
                    b.HasOne("ASPdemo.Entities.Category", null)
                        .WithMany("Coins")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPdemo.Entities.Portfolio", b =>
                {
                    b.HasOne("ASPdemo.Entities.User", "user")
                        .WithOne("portfolio")
                        .HasForeignKey("ASPdemo.Entities.Portfolio", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("ASPdemo.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASPdemo.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASPdemo.Entities.Category", b =>
                {
                    b.Navigation("Coins");
                });

            modelBuilder.Entity("ASPdemo.Entities.User", b =>
                {
                    b.Navigation("portfolio")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
