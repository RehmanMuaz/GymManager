using GM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM.Core.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetTransactions();
        Task<Transaction> GetTransactionByID(string transactionID);
		Task<Transaction> GetTransactionByMemberID(int memberID);
        Task InsertTransaction(Transaction transaction);
		Task DeleteTransaction(int transactionID);
		Task UpdateTransaction(int transactionID);
		Task Save();
    }
}
