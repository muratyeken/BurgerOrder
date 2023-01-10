using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mass_Burger_MVC.Entities.Concrete
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }        
        public int Quantity { get; set; }
        public bool Status { get; set; } = true;
        public decimal TotalPrice { get; set; }         
        public Menu ChosenMenu { get; set; }
        public Extra ChosenExtra { get; set; }
    }
}
