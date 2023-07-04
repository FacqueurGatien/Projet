using System;
using System.Collections.Generic;

namespace ECF_SPA.Models;

public partial class Race
{
    public int Id { get; set; }

    public string Race1 { get; set; } = null!;

    public virtual ICollection<Chat> Chats { get; set; } = new List<Chat>();
}
