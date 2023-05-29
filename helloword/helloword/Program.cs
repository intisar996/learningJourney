using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace helloword
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // My Information
            
            Console.WriteLine("my name intisar " + "\n " +  " I am 27 yers old ");

            string MyName = "intisar";
            int MyAge;
            MyAge = 27;
            bool CheckName = true;

            Console.WriteLine($"My name  :  {MyName}  \n " + $" my age {MyAge} ");


            int Mynum = 2;
            int Num2 = 3;
            Console.WriteLine(Mynum.GetHashCode());
            Console.WriteLine(Num2.GetHashCode());


           Object n1 = new Object();
            Object n12 = n1;

            n1 = "ALshezwi";
            Console.WriteLine(n1);
            Console.WriteLine(n12);



            int a = 2;
            int b = 3;
            int c = 2;
            int d = 3;


            bool aa = a == b; // f
            bool ab = a != b; // T
            bool ab1 = a < b; // T
            bool ab2 = a > b; // f
            bool ab3 = a >= b; // t
            bool ab4 = a <= b; // f
            Console.WriteLine(aa);
            Console.WriteLine(ab);
            Console.WriteLine(ab1);
            Console.WriteLine(ab2);
            Console.WriteLine(ab3);
            Console.WriteLine(ab4);

            
            if(a < b && c < d)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("True");
            }else if(a < b || c < d)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("False");
            }




















































        }
    }
}