using System;
using System.Collections.Generic;

namespace FirstAPI.Models;

public partial class Warehouse
{
    public int Whnumber { get; set; }

    public string Location { get; set; } = null!;
}
