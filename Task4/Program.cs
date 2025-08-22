using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            Console.Write("Enter length of password: ");
            bool isValidValue = int.TryParse(Console.ReadLine(), out int passwordLength);

            if (!isValidValue || passwordLength <= 0)
            {
                Console.WriteLine("Wrong input");
                return;
            }

            int digitsAmount = passwordLength / 2;
            int lettersAmount = passwordLength - digitsAmount;

            int[] arrayOfDigits = new int[digitsAmount];
            char[] arrayOfLetters = new char[lettersAmount];
            string[] combined = new string[passwordLength];

            for (int i = 0; i < digitsAmount; i++)
            {
                arrayOfDigits[i] = random.Next(0, 10);
                combined[i] = arrayOfDigits[i].ToString();
            }

            for (int i = 0; i < lettersAmount; i++)
            {
                arrayOfLetters[i] = chars[random.Next(chars.Length)];
                combined[digitsAmount + i] = arrayOfLetters[i].ToString();
            }

            for (int i = 0; i < combined.Length; i++)
            {
                int randomPosition = random.Next(0, combined.Length);
                string temp = combined[i];
                combined[i] = combined[randomPosition];
                combined[randomPosition] = temp;
            }

            Console.WriteLine("Password: " + string.Join("", combined));

        }
    }
}
