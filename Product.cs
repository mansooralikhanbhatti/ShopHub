using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopHub.entities;

public partial class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}
