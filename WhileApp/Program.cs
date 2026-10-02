namespace WhileApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = 0;
            int sum = 0;
            int i = 0;

            Console.Write("Enter Input: ");
            if (!int.TryParse(Console.ReadLine(), out inputNumber) || inputNumber < 0 )
            {
                Console.WriteLine("Wrong input type");
                return;
            }

            while (i < inputNumber)
            {
                sum += i;
                i++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
