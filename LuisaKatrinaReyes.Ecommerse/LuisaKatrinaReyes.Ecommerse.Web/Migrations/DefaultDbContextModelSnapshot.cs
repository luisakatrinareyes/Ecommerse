﻿// <auto-generated />
using System;
using LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LuisaKatrinaReyes.Ecommerse.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.Category", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("TagLine")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.Product", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CategoryId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("TagLine")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.ProductTag", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TagId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.Tag", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e8dbc96e-0017-4040-870a-bba392a940a0"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(7558),
                            Name = "Tag 1",
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(8174)
                        },
                        new
                        {
                            Id = new Guid("32febb22-f596-4b1e-b0a8-b11ad54be201"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9660),
                            Name = "Tag 2",
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9672)
                        },
                        new
                        {
                            Id = new Guid("32febb22-f596-4b1e-b0a8-b11ad54be202"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9703),
                            Name = "Tag 3",
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 36, DateTimeKind.Utc).AddTicks(9704)
                        });
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(7660),
                            EmailAddress = "luisakatrinareyes@mailinator.com",
                            FirstName = "Luisa Katrina",
                            LastName = "Reyes",
                            Role = 5,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(7663)
                        },
                        new
                        {
                            Id = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8945),
                            EmailAddress = "izzelkatereyes@gmail.com",
                            FirstName = "Izzel Kate",
                            LastName = "Reyes",
                            Role = 1000,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8947)
                        },
                        new
                        {
                            Id = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8997),
                            EmailAddress = "leojinbsenreyes@gmail.com",
                            FirstName = "Leoj Ibsen",
                            LastName = "Reyes",
                            Role = 1000,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 40, DateTimeKind.Utc).AddTicks(8998)
                        });
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.UserLogin", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Key")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ddfeb295-decb-4967-ad83-2bda117b1413"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 46, DateTimeKind.Utc).AddTicks(6926),
                            Key = "Password",
                            Type = 1,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 46, DateTimeKind.Utc).AddTicks(6950),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"),
                            Value = "$2b$10$i2jLvf4LR8VrnJLjwQHpEe5jFWh6Qrtf.Vd9qFHbo7Q05nmPxDml2"
                        },
                        new
                        {
                            Id = new Guid("7dd8c275-b0cd-41a4-92fc-9f834881fae4"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3049),
                            Key = "LoginStatus",
                            Type = 0,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3078),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"),
                            Value = "Active"
                        },
                        new
                        {
                            Id = new Guid("0ff847fd-a0df-4aed-979b-5cd7a01321c6"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3229),
                            Key = "LoginRetries",
                            Type = 1,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3230),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f00"),
                            Value = "0"
                        },
                        new
                        {
                            Id = new Guid("32605134-1fa4-4222-9a47-ad75da700cc8"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3467),
                            Key = "Password",
                            Type = 1,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 144, DateTimeKind.Utc).AddTicks(3468),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"),
                            Value = "$2b$10$ZtlA1XJMXLLLfapOQcbwS.OoCocJsjLT96mLYcGwKzow/sxwTLnEa"
                        },
                        new
                        {
                            Id = new Guid("dcb5e68c-9c5a-4573-b347-a4ff5c463aaa"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(2880),
                            Key = "LoginStatus",
                            Type = 0,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(2903),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"),
                            Value = "Active"
                        },
                        new
                        {
                            Id = new Guid("e27ede2c-8168-4dc6-a8eb-cab565f8209a"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3247),
                            Key = "LoginRetries",
                            Type = 1,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3248),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f01"),
                            Value = "0"
                        },
                        new
                        {
                            Id = new Guid("087e924c-5232-4e2d-8c77-bc7ed3527c3e"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3302),
                            Key = "Password",
                            Type = 1,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 236, DateTimeKind.Utc).AddTicks(3303),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"),
                            Value = "$2b$10$ad3IioJ0odaD.pULlBOVP.2uYHF3ktlGjFVhrZKpeeotoq6QAq6lK"
                        },
                        new
                        {
                            Id = new Guid("052c724d-fb53-47f4-bcc1-8cf5c86e857c"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1280),
                            Key = "LoginStatus",
                            Type = 0,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1301),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"),
                            Value = "Active"
                        },
                        new
                        {
                            Id = new Guid("1c34968f-15f2-4a65-a7c2-9db98471461f"),
                            CreatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1346),
                            Key = "LoginRetries",
                            Type = 1,
                            UpdatedAt = new DateTime(2021, 5, 30, 9, 7, 0, 332, DateTimeKind.Utc).AddTicks(1347),
                            UserId = new Guid("ecb5d292-ff66-484f-84ac-456a05f60f02"),
                            Value = "0"
                        });
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.ProductTag", b =>
                {
                    b.HasOne("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.UserLogin", b =>
                {
                    b.HasOne("LuisaKatrinaReyes.Ecommerse.Web.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
