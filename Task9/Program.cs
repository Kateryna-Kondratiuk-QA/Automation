namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your occupations: ");

            List<string> occupations = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                occupations.Add(Console.ReadLine());
            }

            Console.WriteLine("\nDo you want to delete item? y/n");
            string choice = Console.ReadLine();

            if (choice == "y")
            {
                Console.WriteLine("Which item should be removed?");
                string removedItem = Console.ReadLine();
                occupations.Remove(removedItem);
            }
            else
            {
                return;
            }

            Console.WriteLine("\nList of your occupations after deleting: ");
            foreach (string item in occupations)
            {
                Console.WriteLine(item);
            }

        }
    }
}
