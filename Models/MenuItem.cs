using System;
using System.Collections.Generic;

namespace Airport_Food_Court_API.Models;

public partial class MenuItem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Price { get; set; }

    public bool IsAvailable { get; set; }

    public int MenuCategoryId { get; set; }

    public virtual MenuCategory MenuCategory { get; set; } = null!;
}
