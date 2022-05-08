using CerditCardThreads.Models;
using System.Collections.Generic;
using System.Threading;

namespace CerditCardThreads.Services
{
	public class CardService
	{
		public string MakePayment(double amount)
		{
			return Card.MakePayment(amount);
		}
	}
}
