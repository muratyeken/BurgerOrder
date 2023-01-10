using System.ComponentModel.DataAnnotations;

namespace Mass_Burger_MVC.Entities.Concrete
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public string MenuName { get; set; }
        public decimal MenuPrice { get; set; }
    }
}
