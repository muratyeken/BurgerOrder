using Mass_Burger_MVC.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Mass_Burger_MVC
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BALIM\\MSSQLSERVER2019;Database=MassBurgerDb;Trusted_Connection=True;");
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Extra> Extras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Menu>().HasData(
                new Menu() { ID = 1, MenuName = "Mass SteakHouse", MenuPrice = 150 },
                new Menu() { ID = 2, MenuName = "Double MassBurger", MenuPrice = 140 },
                new Menu() { ID = 3, MenuName = "Cheese & MassBurger", MenuPrice = 130 },
                new Menu() { ID = 4, MenuName = "MassBurger", MenuPrice = 120 }
                );

            modelBuilder.Entity<Extra>().HasData(
                new Extra() { ExtraID = 1, ExtraName = "Barbeque", ExtraPrice = 10 },
                new Extra() { ExtraID = 2, ExtraName = "Ketchup", ExtraPrice = 9 },
                new Extra() { ExtraID = 3, ExtraName = "Ranch", ExtraPrice = 12 }
            );
        }
    }

}
