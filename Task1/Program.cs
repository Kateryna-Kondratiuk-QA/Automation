namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the purchase amount: ");

            bool isValidValue = double.TryParse(Console.ReadLine(), out double amount);
            if (!isValidValue)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            if (amount > 5000)
            {
                amount = amount - ((amount * 10) / 100);
                Console.WriteLine($"Your discount is 10%! Payable amount: {amount}");
            }
            else if (amount <= 5000 && amount > 1000)
            {
                amount = amount - ((amount * 5) / 100);
                Console.WriteLine($"Your discount is 5%! Payable amount: {amount}");
            }
            else
            {
                Console.WriteLine("Unfortunately, you don't have a discount");
            }


        }
    }
}
