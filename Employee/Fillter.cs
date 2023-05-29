using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Fillter
    {
     public  delegate  bool Fillteration(Employee e);


     public void EmpInfo(Employee[] emp,string Title, Fillteration fillter)
        {




            Console.WriteLine(Title);
            Console.WriteLine("**********************");
            Console.WriteLine("Name | Age | Salary | Totalsale");


            foreach (Employee e in emp)
            {
              if(fillter(e))
                {

                    Console.WriteLine($"{e.Name} | {e.age} | {e.salary} | {e.Totalsale}");
                }
            }
            Console.WriteLine("\n\n");

        }


    }
}








