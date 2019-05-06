﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using e_yama.Data;

namespace e_yama.Migrations
{
    [DbContext(typeof(EfDataContext))]
    partial class EfDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

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
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

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

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("e_yama.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("EYUserId");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Phone");

                    b.Property<int>("PostCode");

                    b.HasKey("Id");

                    b.HasIndex("EYUserId");

                    b.ToTable("Addres");
                });

            modelBuilder.Entity("e_yama.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EYUserId");

                    b.Property<int?>("ProductDetailId");

                    b.Property<int>("Quantity");

                    b.Property<bool>("SavedForLater");

                    b.Property<DateTime>("TimeAdded");

                    b.HasKey("Id");

                    b.HasIndex("EYUserId");

                    b.HasIndex("ProductDetailId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("e_yama.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("e_yama.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("DiscountName");

                    b.Property<int>("Quantity");

                    b.Property<int>("Type");

                    b.Property<DateTime>("Valid");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("e_yama.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressId");

                    b.Property<int>("Amount");

                    b.Property<DateTime>("Created");

                    b.Property<int?>("DiscountId");

                    b.Property<string>("EYUserId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("EYUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("e_yama.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderId");

                    b.Property<int?>("ProductDetailId");

                    b.Property<int>("Quantity");

                    b.Property<int?>("UnitId");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductDetailId");

                    b.HasIndex("UnitId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("e_yama.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<decimal>("Price");

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("e_yama.Models.ProductDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<int?>("ProductId");

                    b.Property<string>("Size");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductDetails");
                });

            modelBuilder.Entity("e_yama.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ProductId");

                    b.Property<string>("TagName");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("e_yama.Models.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UnitName");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("e_yama.Models.EYUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<DateTime>("DateJoined");

                    b.Property<bool>("Deleted");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("Type");

                    b.HasDiscriminator().HasValue("EYUser");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("e_yama.Models.Address", b =>
                {
                    b.HasOne("e_yama.Models.EYUser", "EYUser")
                        .WithMany()
                        .HasForeignKey("EYUserId");
                });

            modelBuilder.Entity("e_yama.Models.CartItem", b =>
                {
                    b.HasOne("e_yama.Models.EYUser", "EYUser")
                        .WithMany()
                        .HasForeignKey("EYUserId");

                    b.HasOne("e_yama.Models.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetailId");
                });

            modelBuilder.Entity("e_yama.Models.Order", b =>
                {
                    b.HasOne("e_yama.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("e_yama.Models.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId");

                    b.HasOne("e_yama.Models.EYUser", "EYUser")
                        .WithMany()
                        .HasForeignKey("EYUserId");
                });

            modelBuilder.Entity("e_yama.Models.OrderItem", b =>
                {
                    b.HasOne("e_yama.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("e_yama.Models.ProductDetail", "ProductDetail")
                        .WithMany()
                        .HasForeignKey("ProductDetailId");

                    b.HasOne("e_yama.Models.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");
                });

            modelBuilder.Entity("e_yama.Models.Product", b =>
                {
                    b.HasOne("e_yama.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("e_yama.Models.ProductDetail", b =>
                {
                    b.HasOne("e_yama.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("e_yama.Models.Tag", b =>
                {
                    b.HasOne("e_yama.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
