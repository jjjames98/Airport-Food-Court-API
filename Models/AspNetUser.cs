using System;
using System.Collections.Generic;

namespace Airport_Food_Court_API.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public bool? IsOpen { get; set; }

    public string Name { get; set; } = null!;
}
