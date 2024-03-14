using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class MemberPayment
{
    public int MemberId { get; set; }

    public long PaymentId { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual Payment Payment { get; set; } = null!;
}
