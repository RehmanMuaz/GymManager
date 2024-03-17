using GM.Core.Interfaces;
using GM.Core.Models;
using GM.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GM.Core.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private GMDbContext context;


        public TransactionRepository(GMDbContext context)
        {
            this.context = context;
        }

        public async Task DeleteTransaction(int transactionID)
        {
            throw new NotImplementedException();
        }

        public async Task<Transaction> GetTransactionByID(string transactionID)
        {
            var result = await context.Transactions
                .SingleAsync(b => b.Id.ToString() == transactionID);

            return result;

        }

        public async Task<Transaction> GetTransactionByMemberID(int memberID)
        {
			var result = await context.Transactions
	            .SingleAsync(b => b.MemberId.ToString() == memberID.ToString());

			return result;
		}

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
			var result = await context.Transactions
                .ToListAsync();

			return result;
		}

        public async Task InsertTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateTransaction(int transactionID)
        {
            throw new NotImplementedException();
        }

    }
}
