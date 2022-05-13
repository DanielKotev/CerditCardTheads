using System;
using System.Collections.Generic;
using System.Threading;

namespace CerditCardThreads.Models
{
    public static class Card
    {
        public static double limit = 10000;
        private static readonly object locker = new object();

	    public static CardResponse MakePayment(double amount)
        {
			lock (locker)
			{
                CardResponse response;

                if (amount <= limit)
                {
			        limit -= amount;
                    response = new CardResponse("successful", limit);
                }
                else
                {
                    response = new CardResponse("failed", limit);
                }

                Thread.Sleep(1000);
                return response;
			}
        }

        public static double Reset()
        {
            limit = 10000;
            return limit;
        }
    }
}


