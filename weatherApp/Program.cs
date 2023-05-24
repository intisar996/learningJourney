
using System.Drawing;

namespace weatherApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather w = new Weather(10);
            w.OnTempChange += W_OnTempChange;
            w.TempChanged(2);

        }

        private static void W_OnTempChange(Weather weather)
        {
            if (weather.temerature < 17)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();

                Console.WriteLine("Rainy and Cold");

            }
            else if (weather.temerature > 17 && weather.temerature < 25)
            {
                Console.WriteLine("cloudy and no rain");

            }
            else
            {
                Console.WriteLine("hot and melt");
            }

            }
        }


        class Weather
        {
            public int temerature;
            public string condition;

            public string Condition => this.condition;

            public int Temerature { get => this.temerature; set => this.temerature = value; }

            public Weather(int temerature)
            {

                this.temerature = temerature;
            }

            public delegate void WeatherOnChanged(Weather weather);

            public event WeatherOnChanged OnTempChange;


            public void TempChanged(int TempChange)
            {
                this.temerature += TempChange;

                if (OnTempChange != null)
                {
                    OnTempChange(this);

                }
            }









        }

    }

