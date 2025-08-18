namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int computerNumber = random.Next(1, 20);

            bool continueGuessing = true;
            do
            {
                Console.Write("Try to guess: ");
                bool isInputCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
                if (!isInputCorrect)
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                if (userNumber < 1 || userNumber > 20)
                {
                    Console.WriteLine("Not in range 1-20");
                    continue;
                }

                if (userNumber == computerNumber)
                {
                    continueGuessing = false;
                }
                else if (userNumber < computerNumber)
                {
                    Console.WriteLine("More");
                }
                else
                {
                    Console.WriteLine("Less");
                }
            }
            while (continueGuessing);
            Console.WriteLine("You guessed it!");
        }
    }
}
