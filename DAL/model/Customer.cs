using System;
using System.Collections.Generic;

namespace DAL.model;

public partial class Customer
{
    public int Id { get; set; }

    public string? CustomerName { get; set; }

    public long? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? CustomerPwd { get; set; }

    public string? CustomerAddress { get; set; }
}
