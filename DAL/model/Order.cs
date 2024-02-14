using System;
using System.Collections.Generic;

namespace DAL.model;

public partial class Order
{
    public int Id { get; set; }

    public string? CoreProducts { get; set; }

    public string? Booking { get; set; }

    public string? CancelOrder { get; set; }

    public string? Reminder { get; set; }
}
