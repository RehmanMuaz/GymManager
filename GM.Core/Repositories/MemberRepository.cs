using GM.Core.Interfaces;
using GM.Core.Models;
using GM.Core.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GM.Core.Repositories
{
    public class MemberRepository : IMemberRepository, IDisposable
    {
        private GMDbContext context;
        private bool disposed;

        public MemberRepository(GMDbContext context)
        {
            this.context = context; 
        }

        public async Task DeleteMember(int memberID)
        {
            var member = await context.Members.FirstOrDefaultAsync(m => m.Id == memberID);
            if (member != default)
            {
                context.Members.Remove(member);
                await context.SaveChangesAsync(); // async
            }

        }

        public async Task<Member?> GetMemberByID(int memberID)
        {
            var member = await context.Members.FirstOrDefaultAsync(m => m.Id == memberID);
            if (member != default)
            {
                return member;
            }

            return default;
            
        }

        public async Task<Member> GetMemberByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<IMemberRepository>> GetMembers()
        {
            var members = await context.Members.ToListAsync();

            if (members.Any())
            {
                return (IEnumerable<IMemberRepository>)members;
            }
            else
            {
                return default;
            }

        }

        public async Task InsertMember(Member member)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMember(Member member)
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
