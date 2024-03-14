using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class Banking
{
    public int AccountId { get; set; }

    public int? InsitutionNumber { get; set; }

    public int? TransitNumber { get; set; }

    public int? AccountNumber { get; set; }

    public virtual ICollection<MemberBanking> MemberBankings { get; set; } = new List<MemberBanking>();
}
