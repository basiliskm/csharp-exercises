namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;   // για να φαίνονται σωστά τα ελληνικά

            // 1. Απευθείας χρήση της Point
            Point p1 = new() { X = 1 };
            Console.WriteLine($"Αρχικό X: {p1.X}");

            p1.Move5();
            Console.WriteLine($"Μετά το Move5: {p1.X}");

            p1.Move10();
            Console.WriteLine($"Μετά το Move10: {p1.X}");
            Console.WriteLine();

            // 2. Μέσω της MovingSpace: δέχεται οποιοδήποτε IMoveable
            Point p2 = new() { X = 100 };
            MovingSpace space = new(p2);
            space.Move5();
            Console.WriteLine($"p2 μετά το space.Move5(): {p2.X}");

            // 3. MovingSpace με null: το ?. αποτρέπει το NullReferenceException
            MovingSpace emptySpace = new(null);
            emptySpace.Move5();
            Console.WriteLine("emptySpace.Move5() με null: δεν έγινε τίποτα, ούτε exception");
        }
    }
}
