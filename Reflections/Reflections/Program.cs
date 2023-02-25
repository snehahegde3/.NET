namespace Reflections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new CSVGenerator<Book>(BookData.Books, "Book").Generate();
            new CSVGenerator<Weather>(WeatherData.Weathers, "Weather").Generate();
        }
    }
}