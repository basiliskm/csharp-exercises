namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;   // για να φαίνονται σωστά τα ελληνικά

            Point a = new(3);
            Point b = new(4);
            Point c = new(3);   // ίδιο X με το a, αλλά ΔΙΑΦΟΡΕΤΙΚΟ αντικείμενο

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine();

            // 1. Αριθμητικοί τελεστές: επιστρέφουν ΝΕΟ Point
            Console.WriteLine("=== + και - ===");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"b - a = {b - a}");
            Console.WriteLine($"a μετά τις πράξεις: {a}  (δεν άλλαξε)");
            Console.WriteLine();

            // 2. Ισότητα
            Console.WriteLine("=== == και != ===");
            Console.WriteLine($"a == c                  : {a == c}   (ίδιο X)");
            Console.WriteLine($"ReferenceEquals(a, c)   : {ReferenceEquals(a, c)}  (όμως δεν είναι το ίδιο αντικείμενο)");
            Console.WriteLine($"a.Equals(c)             : {a.Equals(c)}");
            Console.WriteLine($"a != b                  : {a != b}");
            Console.WriteLine();

            // 3. Σύγκριση
            Console.WriteLine("=== <, >, <=, >= ===");
            Console.WriteLine($"a < b   : {a < b}");
            Console.WriteLine($"a > b   : {a > b}");
            Console.WriteLine($"a <= c  : {a <= c}");
            Console.WriteLine($"b >= a  : {b >= a}");
            Console.WriteLine($"a.CompareTo(b): {a.CompareTo(b)}  (αρνητικό => a μικρότερο)");
            Console.WriteLine();

            // 4. Με null
            Console.WriteLine("=== με null ===");
            Point? nothing = null;
            Console.WriteLine($"a == null     : {a == nothing}");
            Console.WriteLine($"null == null  : {nothing == null}");
            Console.WriteLine($"null < a      : {nothing < a}   (το null θεωρείται το μικρότερο)");
            Console.WriteLine();

            // 5. Μπόνους: Sort χάρη στο IComparable<Point>
            Console.WriteLine("=== Sort ===");
            List<Point> points = [new(5), new(1), new(3)];
            Console.WriteLine("Πριν:  " + string.Join(", ", points));
            points.Sort();
            Console.WriteLine("Μετά:  " + string.Join(", ", points));
            Console.WriteLine();

            // 6. Μπόνους: HashSet χάρη στα Equals + GetHashCode
            Console.WriteLine("=== HashSet ===");
            HashSet<Point> set = [a, b, c];
            Console.WriteLine($"Βάλαμε a, b, c → Count = {set.Count}  (τα a και c μετράνε ως ένα)");
        }
    }
}
