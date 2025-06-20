using generator;

namespace sourcegen {
    class Program 
    {
        static void Main(string[] args){
            Console.WriteLine("Hello, World!");

            var p = new Person {
                Name = "John",
                Age = 30,
                Email = "john@example.com"
            };

            Console.WriteLine(p.ToString());
        }
    }
}