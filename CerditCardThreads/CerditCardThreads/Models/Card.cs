using System;
using System.Collections.Generic;
using System.Threading;

namespace CerditCardThreads.Models
{
    public static class Card
    {
        public static double limit = 10000;
        private static readonly object locker = new object();

	    public static string MakePayment(double amount)
        {
			lock (locker)
			{
                string response;

                if (amount <= limit)
                {
			        limit -= amount;
                    response = $"������� �������. �����: ${limit}";
                }
                else
                {
                    response = $"�������� �����. �����: ${limit}";
                }

                Thread.Sleep(1000);
                return response;
			}
        }
    }
}


