namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] priceArray = { 12.5, 10, 5, 1.5, 24 };
            double[] copiedPriceArray = new double[priceArray.Length];

            Console.WriteLine("Original array: ");
            for (int i = 0; i < priceArray.Length; i++)
            {
                Console.Write($"{priceArray[i]} ");
                copiedPriceArray[i] = priceArray[i];
            }



            Console.WriteLine("\nCoppied array: ");
            for (int i = 0; i < copiedPriceArray.Length; i++)
            {
                Console.Write($"{copiedPriceArray[i]} ");
            }


            Console.WriteLine("\nChanged original array: ");
            for (int i = 0; i < priceArray.Length; i++)
            {
                priceArray[i] = priceArray[i] * 2;
                Console.Write($"{priceArray[i]} ");
            }


            Console.WriteLine("\nCoppied array: ");
            for (int i = 0; i < copiedPriceArray.Length; i++)
            {
                Console.Write($"{copiedPriceArray[i]} ");
            }
            Console.WriteLine();

        }
    }
}
