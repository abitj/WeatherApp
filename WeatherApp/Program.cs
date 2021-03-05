using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = File.ReadAllText("appsettings.json");
            string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

            Console.WriteLine("Hello, Do you want to know what the weather? Please enter zip code here:");
            Console.WriteLine();
            string zipCode = Console.ReadLine();
     
            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";
            Console.WriteLine();
            Console.WriteLine($"It is currently {WeatherMap.GetTemp(apiCall)} °F in your area.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------");

        }
    }
}
