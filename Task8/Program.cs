namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLetter(word[i]))
                {
                    Console.WriteLine("Wrong input");
                    return;
                }
            }

            char[] wordArray = word.ToCharArray();
            char[] reversedWordArray = word.ToCharArray();
            Array.Reverse(reversedWordArray);

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (wordArray[i] == reversedWordArray[i])
                {
                    Console.Write(reversedWordArray[i] + " ");
                }
                else
                {
                    Console.WriteLine("Your word is not palindrome");
                    return;
                }
            }

            Console.WriteLine("\nYour word is palindrome");

        }
    }
}
