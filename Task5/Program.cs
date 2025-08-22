using System.Text.Json.Serialization;

namespace Task5
{
    internal class Program
    {
        static void ShuffleArray(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int randomPosition = random.Next(array.Length);
                int temp = array[i];
                array[i] = array[randomPosition];
                array[randomPosition] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            Console.Write("Initial array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            ShuffleArray(arr);

            Console.Write("Mixed array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }


        }
    }
}
