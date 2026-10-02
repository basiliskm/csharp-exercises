using System.Numerics;

namespace PowerApp
{
    /// <summary>
    /// Gets base and power and calculates the result.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 0;
            int powerNumber = 0;
            BigInteger result = 1;

            Console.WriteLine("Εισάγετε τιμή Βάσης");
            if (!int.TryParse(Console.ReadLine(), out baseNumber) || baseNumber < 0)
            {
                Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος αριθμός");
                return;
            }
            Console.WriteLine("Εισάγετε τιμή Δύναμης");
            if (!int.TryParse(Console.ReadLine(), out powerNumber) || powerNumber < 0)
            {
                Console.WriteLine("Η τιμή που εισάγατε δεν είναι έγκυρος αριθμός");
                return;
            }
            

            for (int i = 1; i <= powerNumber; i++)
            {
                result *= baseNumber;
            }
            Console.WriteLine($"Αποτέλεσμα: {result}");
        }
    }
}
