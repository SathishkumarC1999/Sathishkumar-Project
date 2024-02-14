using System;
using System.Collections.Generic;

namespace DAL.model;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpAddress { get; set; }

    public string? Attendance { get; set; }

    public string? WorkingHours { get; set; }
}
