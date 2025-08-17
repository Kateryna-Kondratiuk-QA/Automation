namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the temperature: ");
            bool isValid = int.TryParse(Console.ReadLine(), out int temperature);
            if (!isValid)
            {
                Console.WriteLine("Wrong input");
                return;
            }
       
            if (temperature < 15)
            {
                Console.WriteLine("Put on a warm clothes");
            }
            else if (temperature >= 15 && temperature <= 25)
            {
                Console.WriteLine("Put on a light jacket");
            }
            else
            {
                Console.WriteLine("Put on a T-shirt and shorts");
            }           
        }
    }
}
