﻿// <auto-generated />
using Mass_Burger_MVC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Mass_Burger_MVC.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mass_Burger_MVC.Entities.Concrete.Extra", b =>
                {
                    b.Property<int>("ExtraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExtraID"), 1L, 1);

                    b.Property<string>("ExtraName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ExtraPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ExtraID");

                    b.ToTable("Extras");

                    b.HasData(
                        new
                        {
                            ExtraID = 1,
                            ExtraName = "Barbeque",
                            ExtraPrice = 10m
                        },
                        new
                        {
                            ExtraID = 2,
                            ExtraName = "Ketchup",
                            ExtraPrice = 9m
                        },
                        new
                        {
                            ExtraID = 3,
                            ExtraName = "Ranch",
                            ExtraPrice = 12m
                        });
                });

            modelBuilder.Entity("Mass_Burger_MVC.Entities.Concrete.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MenuPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            MenuName = "Mass SteakHouse",
                            MenuPrice = 150m
                        },
                        new
                        {
                            ID = 2,
                            MenuName = "Double MassBurger",
                            MenuPrice = 140m
                        },
                        new
                        {
                            ID = 3,
                            MenuName = "Cheese & MassBurger",
                            MenuPrice = 130m
                        },
                        new
                        {
                            ID = 4,
                            MenuName = "MassBurger",
                            MenuPrice = 120m
                        });
                });

            modelBuilder.Entity("Mass_Burger_MVC.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"), 1L, 1);

                    b.Property<int>("ChosenExtraExtraID")
                        .HasColumnType("int");

                    b.Property<int>("ChosenMenuID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("ChosenExtraExtraID");

                    b.HasIndex("ChosenMenuID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Mass_Burger_MVC.Entities.Concrete.Order", b =>
                {
                    b.HasOne("Mass_Burger_MVC.Entities.Concrete.Extra", "ChosenExtra")
                        .WithMany()
                        .HasForeignKey("ChosenExtraExtraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mass_Burger_MVC.Entities.Concrete.Menu", "ChosenMenu")
                        .WithMany()
                        .HasForeignKey("ChosenMenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChosenExtra");

                    b.Navigation("ChosenMenu");
                });
#pragma warning restore 612, 618
        }
    }
}
