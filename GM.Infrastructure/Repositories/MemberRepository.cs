using GM.Core.Interfaces;
using GM.Core.Models;
using GM.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM.Infrastructure.Repositories
{
    public class MemberRepository : IMemberRepository, IDisposable
    {
        private GMDbContext context;
        private bool disposed;

        public MemberRepository(GMDbContext context)
        {
            this.context = context; 
        }

        public void DeleteMember(int memberID)
        {
            throw new NotImplementedException();
        }

        public Member GetMemberByID(int memberID)
        {
            throw new NotImplementedException();
        }

        public Member GetMemberByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMemberRepository> GetMembers()
        {
            throw new NotImplementedException();
        }

        public void InsertMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
