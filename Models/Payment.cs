using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class Payment
{
    public long Id { get; set; }

    public decimal Amount { get; set; }

    public DateTime Time { get; set; }

    public virtual ICollection<MemberPayment> MemberPayments { get; set; } = new List<MemberPayment>();
}
