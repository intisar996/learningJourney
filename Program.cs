namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Multi Array
            int[,] m = new int[3, 3];
            m[0,0] = 1;
            m[0,1] = 2;
            m[0,2] = 3;
            m[1,0] = 4;
            m[1,1] = 5;
            m[1,2] = 6;
            m[2,0] = 7;
            m[2,1] = 8;
            m[2,2] = 9;
            Console.WriteLine(m[0,1]);

            Console.WriteLine("-----------------");
             // Conditonal  Null  ?
             string MyName = null;
            string MName = MyName?.ToUpper();
            Console.WriteLine(MName);

            //  
            int userInput = 2;
            switch (userInput)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                    Console.WriteLine($"the number {userInput} is even");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine($"the number {userInput} is even");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from 1 - 10");
                    break;

            }



            // switch
            object o = "intisar";
            switch (o)
            {
                case int i:
                    Console.WriteLine($"it is int sqr of {i} = {i*i}");
                    break;
                case string s:
                    Console.WriteLine($"it is strin, the captial from of  {s} = {s.ToUpper()} ");
                    break;
                default:
                    Console.WriteLine("niether int nor string");
                    break;
             
            }


            bool isBuniessClass = true;
            switch (isBuniessClass)
            {
                case bool j when j == true:
                    Console.WriteLine($"the Customer is a business class + please faciliate the procedurse and take him to lounge ");
                    break;
                case bool j:
                    Console.WriteLine($"the Value og is Business class is {isBuniessClass}");
                    break;

            }


            // 
            int cardNo = 13;
            string cardName = cardNo switch
            {
                1 => "ACE",
                13 => "King",
                12 => "Queen",
                10 => "Jack",
                _ => cardNo.ToString()

                
            };
            Console.WriteLine(cardName);


















        }
    }
}