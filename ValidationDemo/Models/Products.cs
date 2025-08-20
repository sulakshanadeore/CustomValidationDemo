using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ValidationDemo.Models
{
    public class ProductsModel
    {
        [Required(ErrorMessage ="This is compulsory field")]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="Name is compulsory")]
        [MaxLength(100,ErrorMessage ="Cannot be greater than 100 chars")]
        [MinLength(10,ErrorMessage ="Cannot be less than 10 chars")]
        public string ProductName { get; set; }

        [Range(1, 100,ErrorMessage ="Qty not in range")]

        public int Qty { get; set; }

        [Range(10.00, 250.00,ErrorMessage ="Price not in range")]
        public Decimal Price { get; set; }


    }
}
