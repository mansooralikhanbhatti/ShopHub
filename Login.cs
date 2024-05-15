using System;
using System.Collections.Generic;

namespace ShopHub.entities;

public partial class Login
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? MobileNo { get; set; }
}
