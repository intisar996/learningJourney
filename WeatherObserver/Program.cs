namespace WeatherObserver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherObserver observer = new WeatherObserver(15 );
            WeatherObserver observer2 = new WeatherObserver(22);
            observer.Location = "Muscat";
            observer2.Location = "Salalah";
            Weather Muscat = new Weather(15);
            Weather Salalah = new Weather(22);

            Muscat.OnChanged += observer.ChangeWeather;
            Salalah.OnChanged += observer2.ChangeWeather;
            Muscat.ChangeTemperature(20);
            Muscat.ChangeTemperature(35);

            Salalah.ChangeTemperature(30);
        }
    }
}