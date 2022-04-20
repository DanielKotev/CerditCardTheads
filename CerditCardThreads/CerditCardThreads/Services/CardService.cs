using CerditCardThreads.Models;
using System.Collections.Generic;
using System.Threading;

namespace CerditCardThreads.Services
{
	public class CardService
	{
		Card card = new Card(9000);

		public CardService()
		{

		}

		public List<string> MakePayment(double amount)
		{
			var results = new List<string>();

			var userThreads = new Thread[5];
			for (int i = 0; i < 5; i++)
			{
				userThreads[i] = new Thread(() =>
				{
					results.Add(card.MakePayment(amount, i));
				});
				userThreads[i].Start();
				//userThreads[i].Join();
			}
			return results;
		}
	}
}
