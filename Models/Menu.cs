using System;
using System.Collections.Generic;

namespace Airport_Food_Court_API.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public virtual ICollection<MenuCategory> MenuCategories { get; set; } = new List<MenuCategory>();
}
