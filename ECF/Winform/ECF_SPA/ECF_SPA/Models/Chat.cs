using System;
using System.Collections.Generic;

namespace ECF_SPA.Models;

public partial class Chat
{
    public long NumeroPuce { get; set; }

    public string? Nom { get; set; }

    public int? Age { get; set; }

    public int Race { get; set; }

    public virtual Race RaceNavigation { get; set; } = null!;
}
