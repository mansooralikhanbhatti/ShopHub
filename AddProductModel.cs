using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ShopHub.Models
{
    public class AddProductModel
    {
        public int Product_ID { get; set; }


        [Required(ErrorMessage = "Please Enter Product_Name!")]
        public string  Product_Name { get; set; }


        [Required(ErrorMessage = "Please Enter Description!")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Please Enter Price!")]
        public int Price { get; set; }


        [Required(ErrorMessage = "Please Enter Stock!")]
        public int Stock { get; set; }
    }
}
