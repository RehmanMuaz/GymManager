using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class Card
{
    public int MemberId { get; set; }

    public long CardId { get; set; }

    public virtual Member Member { get; set; } = null!;
}
