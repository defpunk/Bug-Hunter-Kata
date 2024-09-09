using System;

namespace BugHunter
{
    public class TheatreCreditReceipt
    {
        public string Print(Invoice invoice)
        {
            int totalCredits = 0;
            string result = string.Format("Statement for {0}\n", invoice.Customer);

            foreach (var performance in invoice.Performances)
            {
                // Bug: It should give extra credits for every ten attendees
                int credits = Math.Max(performance.Audience - 30, 0);
                credits += (int)Math.Floor(performance.Audience / 5.0);

                totalCredits += credits;
            }

            result += string.Format("You earned {0} credits\n", totalCredits);
            return result;
        }
    }
}
