using System.Collections.Generic;

namespace BugHunter
{
    public class Invoice
    {
        public string Customer { get; set; }
        public List<Performance> Performances { get; set; }

        public Invoice(string customer, List<Performance> performances)
        {
            Customer = customer;
            Performances = performances;
        }
    }
}
