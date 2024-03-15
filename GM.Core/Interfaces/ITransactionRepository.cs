using GM.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM.Core.Interfaces
{
    public interface ITransactionRepository : IDisposable
    {
        IEnumerable<IMemberRepository> GetTransactions();
        Member GetTransactionByID(int transactionID);
        Member GetTransactionByMemberID(int memberID);
        void InsertTransaction(Transaction transaction);
        void DeleteTransaction(int transactionID);
        void UpdateTransaction(int transactionID);
        void Save();
    }
}
