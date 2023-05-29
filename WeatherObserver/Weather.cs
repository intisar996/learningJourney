using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class Weather
    {
        public delegate void ChangingEvent(WeatherObserver observer, int temperature);

        public event ChangingEvent OnChanged;

        public int Temperature { get; set; }
       

        public Weather( int temperature  )
        {
            Temperature = temperature;
            
          
        }

        public void ChangeTemperature(int temperature)
        {
            Temperature = temperature;
            OnChanged?.Invoke(new WeatherObserver(Temperature), Temperature);
        }
    }
}
