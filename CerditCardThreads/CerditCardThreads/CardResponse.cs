namespace CerditCardThreads
{
    public class CardResponse
    {
        public string Status { get; set; }
        public double Limit { get; set; }

        public CardResponse(string status, double limit)
        {
            Status = status;
            Limit = limit;
        }
    }
}
