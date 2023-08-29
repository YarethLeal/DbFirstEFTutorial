using System;
using System.Collections.Generic;

namespace DbFirstEFTutorial.Models;

public partial class TvShow
{
    public int ShowId { get; set; }

    public string? Name { get; set; }

    public int? Chapters { get; set; }

    public virtual ICollection<Character> Characters { get; set; } = new List<Character>();
}
