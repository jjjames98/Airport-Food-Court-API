using System;
using System.Collections.Generic;

namespace Airport_Food_Court_API.Models;

public partial class MenuCategory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int MenuId { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
}
