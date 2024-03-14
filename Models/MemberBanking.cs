using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class MemberBanking
{
    public int MemberId { get; set; }

    public int? AccountId { get; set; }

    public virtual Banking? Account { get; set; }

    public virtual Member Member { get; set; } = null!;
}
