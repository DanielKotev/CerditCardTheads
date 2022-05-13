using CerditCardThreads.Models;
using System.Collections.Generic;
using System.Threading;

namespace CerditCardThreads.Services
{
	public class CardService
	{
		public CardResponse MakePayment(double amount)
		{
			return Card.MakePayment(amount);
		}

		public double Reset()
        {
			return Card.Reset();
        }
	}
}
