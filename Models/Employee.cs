using System;
using System.Collections.Generic;

namespace mycode_demo.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? Organisation { get; set; }

    public DateTime? DateOfJoin { get; set; }

    public string? PhotofileName { get; set; }
}
