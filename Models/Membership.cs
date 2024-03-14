using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class Membership
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<MemberMembership> MemberMemberships { get; set; } = new List<MemberMembership>();
}
