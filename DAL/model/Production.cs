using System;
using System.Collections.Generic;

namespace DAL.model;

public partial class Production
{
    public int Id { get; set; }

    public string? Productname { get; set; }

    public string? Duration { get; set; }

    public string? NecessaryItems { get; set; }

    public string? AvailableItems { get; set; }
}
