using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    public enum Description { Cloudy, Clear, Sunny, Humid, Raining, Snowing, Stormy, Dry};
    public class Weather
    {
        public Description Description { get; set; }
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double Rainfall { get; set; }

    }

    public static class WeatherData
    {
        public static IEnumerable<Weather> Weathers = new Weather[]
        {
            new () { Description= Description.Cloudy, Date = new DateTime(2023, 2, 23), Temperature = 20.3, Rainfall = 2.4}, 
            new () { Description= Description.Clear, Date= new DateTime(2023, 2, 22), Temperature = 30.6, Rainfall = 0.15}
        };
    }
}
