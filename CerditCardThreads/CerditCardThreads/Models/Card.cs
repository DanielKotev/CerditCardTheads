using System;
using System.Collections.Generic;
using System.Threading;

namespace CerditCardThreads.Models
{
    public class Card
    {
	    public double Limit { get; private set; }
        static readonly object locker = new object();

        //private Semaphore semaphore = new Semaphore(0, 1);

        public Card(double limit)
        {
            Limit = limit;
        }

	    public string MakePayment(double amount, int username)
        {
			//semaphore.WaitOne();

			lock (locker)
			{
                string result = "";

                if (amount <= Limit)
                {
			        Limit -= amount;
                    result += $"User: {username} payed {amount}. Limit: {Limit}";
                } 
			
                //semaphore.Release();
                return result;
			}
        }
    }
}


