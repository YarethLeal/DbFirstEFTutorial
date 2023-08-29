using System;
using System.Collections.Generic;

namespace DbFirstEFTutorial.Models;

public partial class Character
{
    public int CharacterId { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public int? TvShow { get; set; }

    public virtual TvShow? TvShowNavigation { get; set; }
}
