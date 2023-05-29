using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class WeatherObserver
    {
        public int Temperature { get; set; }
        public string Location { get; set; }
        public string Condition { get; set; }

        public WeatherObserver(int temperature )
        {
            Temperature = temperature;
            
            DetectCondition(Temperature);
        }

        public void DetectCondition(int temperature)
        {
            if (Temperature < 17)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Condition = "raining and Cold";
            }
            else if (Temperature > 17 && Temperature < 25)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Condition = "Cloudy without Raining ";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Condition = "Hot and Melt ";
            }
        }

        public void ChangeWeather(WeatherObserver observer, int temperature)
        {
            Console.WriteLine($"{this.Location} Weather Changed");
            Temperature = temperature;
            DetectCondition(temperature);
            Console.WriteLine($"The Temperature is CHANGED to {Temperature}");
            Console.WriteLine($"The Condition is now {Condition}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
