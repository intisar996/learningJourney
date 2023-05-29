using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();

            d.sound();
             d.name = "bobbe";
             d.age = 1;
            Console.WriteLine($"{d.name} {d.age}");
            d.move();


            Cat c = new Cat();
             c.name = "lulu";
              c.age = 2;
            Console.WriteLine($"{c.name} {c.age}");
            c.sound();
            c.move();
            Console.WriteLine(c);



        }
    }
}