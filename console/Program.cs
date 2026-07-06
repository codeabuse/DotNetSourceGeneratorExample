using shared;

namespace sourcegen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var p = new Person
            {
                Name = "John",
                Age = 30,
                Email = "john@example.com"
            };
            var text = p.ToString();
            Console.WriteLine(text);
            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();
        }
    }
}