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
    public class TransactionRepository : ITransactionRepository, IDisposable
    {
        private bool disposedValue; 
        private GMDbContext context;


        public TransactionRepository(GMDbContext context)
        {
            this.context = context;
        }

        public void DeleteTransaction(int transactionID)
        {
            throw new NotImplementedException();
        }

        public Member GetTransactionByID(int transactionID)
        {
            throw new NotImplementedException();
        }

        public Member GetTransactionByMemberID(int memberID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IMemberRepository> GetTransactions()
        {
            throw new NotImplementedException();
        }

        public void InsertTransaction(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaction(int transactionID)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~TransactionRepository()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
