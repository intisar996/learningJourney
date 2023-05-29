namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] em = new Employee[]

            {


            new Employee { Name = "intisar", age = 27, salary = 2000, Totalsale = 100000m},
            new Employee { Name = "Fatma", age = 23, salary = 350, Totalsale = 200m },
            new Employee { Name = "Safa", age = 28, salary = 300, Totalsale = 300m },
            new Employee { Name = "Noor", age = 24, salary = 400, Totalsale = 1000m },
            new Employee { Name = "bayan", age = 20, salary = 500, Totalsale = 3000m },

        };
           

       



            Fillter f = new Fillter();
            


            f.EmpInfo(em,"Employee Age Less Than 25", (emp)=> emp.age < 25);



        }






    }
}