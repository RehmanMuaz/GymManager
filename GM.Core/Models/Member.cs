using GM.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace GM.Core.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateOnly BirthDate { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string MembershipType { get; set; }
        public string? CardId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly? CancelDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public int InstitutionNumber { get; set; }
        public int BranchNumber { get; set; }
        public int AccountNumber { get; set; }
        public ICollection<Transaction>? Transactions { get; set; }
    }
}
