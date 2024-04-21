using System;
using System.Collections.Generic;

namespace CoreProject.DataAccessLayer.Models;

public partial class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Slug { get; set; }

    public virtual ICollection<Post> Posts { get; } = new List<Post>();
}
