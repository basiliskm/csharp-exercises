namespace AbstractApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractAnimal cat = new Cat { Id = 1, Name = "Tom", Age = 3 };

            cat.Speak();
            cat.Eat();
            Console.WriteLine(cat.ToString());
        }
    }
}
