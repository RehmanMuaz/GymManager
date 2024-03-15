using GM.Core.Models;

namespace GM.Core.Interfaces
{
    public interface IMemberRepository : IDisposable
    {
        IEnumerable<IMemberRepository> GetMembers();
        Member GetMemberByID(int memberID);
        Member GetMemberByName(string name);
        void InsertMember(Member member);
        void DeleteMember(int memberID);
        void UpdateMember(Member member);
        void Save();
    }
}
