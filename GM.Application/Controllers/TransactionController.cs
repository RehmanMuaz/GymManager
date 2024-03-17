using GM.Core.Data;
using GM.Core.Interfaces;
using GM.Core.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace GM.Core.Controllers
{
	[ApiController]
	[Route("api")]
	public class TransactionController : ControllerBase
	{
		private ITransactionRepository repo;

		public TransactionController(ITransactionRepository repo)
		{
			this.repo = repo;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<Transaction>>> GetTransactions()
		{
			try
			{
				var transactions = await repo.GetTransactions();
				//return new ObjectResult(transactions);
				return Ok(transactions);
			}
			catch (Exception ex)
			{
				return StatusCode(500 ,ex.Message); ;
			}

		}

	}
}
