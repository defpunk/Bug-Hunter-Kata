namespace BugHunter
{
    public class Fizzer
    {
        public string Fizz(int number)
        {
            // Intentional bug: Should return "Fizz" if the number is divisible by 3.
            // Otherwise, it should return the number as a string.
            if (number / 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
