using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class MemberMembership
{
    public int MemberId { get; set; }

    public int MembershipId { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual Membership Membership { get; set; } = null!;
}
