using System.ComponentModel.DataAnnotations;

namespace ShopHub.entities
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Please Enter Product_Name!")]
        public string Product_Name { get; set; }

        [Required(ErrorMessage = "Please Enter Description!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Enter Price!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please Enter Stock!")]
        public int Stock { get; set; }


    }
}
