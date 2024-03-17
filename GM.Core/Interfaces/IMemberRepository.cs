using GM.Core.Models;

namespace GM.Core.Interfaces
{
    public interface IMemberRepository : IDisposable
    {
        Task<IEnumerable<IMemberRepository>> GetMembers();
        Task<Member?> GetMemberByID(int memberID);
        Task<Member> GetMemberByName(string name);
        Task InsertMember(Member member);
        Task DeleteMember(int memberID);
        Task UpdateMember(Member member);
        Task Save();
    }
}
