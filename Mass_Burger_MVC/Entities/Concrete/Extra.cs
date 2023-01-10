using System.ComponentModel.DataAnnotations;

namespace Mass_Burger_MVC.Entities.Concrete
{
    public class Extra
    {
        [Key]
        public int ExtraID { get; set; }
        public string ExtraName { get; set; }
        public decimal ExtraPrice { get; set; }
    }
}
