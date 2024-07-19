using System.Text.Json;
using System.Xml.Serialization;

namespace Seminar9
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var filejson = @"{}";

            List<string> result = new List<string>();

            result =findValueInJSON(filejson);

            var weather = JsonSerializer.Deserialize<WeatherInfo>(filejson);
            Console.ReadLine();


            List<string> findValueInJSON(string file)
            {
                List<string> result = new List<string>();
                return result;
            }

        }
    }
    public class Weather
    {
        public DateTime Time {  get; set; }
        public double Temperature { get; set; }
        public int Weathercode {  get; set; }
        public double Windspeed {  get; set; }
        public int Winddirection { get; set;  }




    }
    public class WeatherInfo
    {
        public Weather Current;
        public List<Weather> History;
    }
    
}
