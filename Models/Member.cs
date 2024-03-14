using System;
using System.Collections.Generic;

namespace GymManager.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly Dob { get; set; }

    public string Address { get; set; } = null!;

    public List<string> PostalCode { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? CancelDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public virtual MemberBanking? MemberBanking { get; set; }

    public virtual MemberMembership? MemberMembership { get; set; }

    public virtual MemberPayment? MemberPayment { get; set; }
}
