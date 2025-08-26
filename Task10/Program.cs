namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runningProgram = true;
            double balance = 1000;

            while (runningProgram)
            {
                Console.WriteLine("Menu" +
                    "\n1. Top up balance" +
                    "\n2. Withdraw money" +
                    "\n3. Check balance" +
                    "\n4. Exit");

                bool isValidValue = int.TryParse(Console.ReadLine(), out int choice);
                if (!isValidValue)
                {
                    Console.WriteLine("Wrong input");
                    continue;

                }
                else if (choice <= 0 || choice > 4)
                {
                    Console.WriteLine("Wrong number");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter sum: ");
                        double amountToTopUp = Convert.ToDouble(Console.ReadLine());
                        balance = balance + amountToTopUp;
                        break;
                    case 2:
                        Console.WriteLine("Enter sum to withdraw: ");
                        double amountToWithdraw = Convert.ToDouble(Console.ReadLine());
                        balance = balance - amountToWithdraw;
                        break;
                    case 3:
                        Console.WriteLine($"Your balance is {balance}");
                        break;
                    case 4:
                        Console.WriteLine("Bye");
                        runningProgram = false;
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
