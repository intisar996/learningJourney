namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Wel = "Welcome To My First Website"; // This Wel varible
            Console.WriteLine("-------------------" + Wel + "-------------------------");
            Console.WriteLine("--------------------------------------------------------------------");

            //  Concat string
            String MyName = "Intisar Said";
            int MyAge = 27;
            Console.WriteLine("My Name IS : " + MyName + " My Age :" + MyAge);
            Console.WriteLine("--------------------------------------------------------------------");

            // && , || , !=

            int a = 2;
            int b = 3;
            int c = 4;

            Console.WriteLine((a > b) && (c > b));
            Console.WriteLine((a == b) || (c == b));
            Console.WriteLine((a != b) || (c == b));
            Console.WriteLine("--------------------------------------------------------------------");

            // sum 
            int x = 4, y = 5;
            Console.WriteLine(x + y);

            //
            Console.WriteLine(x.GetHashCode());

            Object bx = new Object();
            

























        }
    }
}