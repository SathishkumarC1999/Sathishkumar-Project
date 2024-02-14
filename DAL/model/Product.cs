using System;
using System.Collections.Generic;

namespace DAL.model;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? MaterialType { get; set; }

    public string? Color { get; set; }

    public decimal? Price { get; set; }
}
