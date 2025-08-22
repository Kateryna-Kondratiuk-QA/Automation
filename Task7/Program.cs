using System.Transactions;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] weeklyTemperature = { 19, 22.5, 30, 28.1, 18, 25.3, 21.8 };

            double min = weeklyTemperature[0];
            double max = weeklyTemperature[0];
            double sum = 0;


            for (int i = 0; i < weeklyTemperature.Length; i++)
            {
                sum += weeklyTemperature[i];

                if (weeklyTemperature[i] > max)
                {
                    max = weeklyTemperature[i];
                }
                else if (weeklyTemperature[i] < min)
                {
                    min = weeklyTemperature[i];
                }
            }

            double average = Math.Round(sum / weeklyTemperature.Length, 1);

            Console.Write($"Highest temperature: {max}\n");
            Console.Write($"Lowest  temperature: {min}\n");
            Console.Write($"Average  temperature: {average}\n");
        }
    }
}
