using System;
using System.Data;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;
namespace Seminar9
{
    public class Program
    {
        public class Weather
        {
            public DateTimeOffset Date { get; set; }
            public int TemperatureCelsius { get; set; }
            public string? Summary { get; set; }
        }
        static void Main(string[] args)
        {
            //var filejson = @"{
            //  '@Id': 1,
            //  'Email': 'james@example.com',
            //  'Active': true,
            //  'CreatedDate': '2013-01-20T00:00:00Z'}"; 


            //object file = JsonSerializer.Deserialize<Object>(filejson);


           
        var weatherForecast = new Weather
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot"
            };

            var json = JsonSerializer.Serialize(weatherForecast);
            Console.WriteLine(json);
            Console.WriteLine();
            Weather filejson = JsonSerializer.Deserialize<Weather>(json);

            var seriolaze = new XmlSerializer(typeof(Weather));
            seriolaze.Serialize(Console.Out, filejson);




            //var filejson = @"{}";

            //List<string> result = new List<string>();

            //result =findValueInJSON(filejson);

            //var weather = JsonSerializer.Deserialize<WeatherInfo>(filejson);
            //Console.ReadLine();


            //List<string> findValueInJSON(string file)
            //{
            //    List<string> result = new List<string>();
            //    return result;
            //}

        }
    }
    //public class Weather
    //{
    //    public DateTime Time {  get; set; }
    //    public double Temperature { get; set; }
    //    public int Weathercode {  get; set; }
    //    public double Windspeed {  get; set; }
    //    public int Winddirection { get; set;  }




    //}
    //public class WeatherInfo
    //{
    //    public Weather Current;
    //    public List<Weather> History;
    //}
    
}
//string json = @"{
//  '@Id': 1,
//  'Email': 'james@example.com',
//  'Active': true,
//  'CreatedDate': '2013-01-20T00:00:00Z',
//  'Roles': [
//    'User',
//    'Admin'
//  ],
//  'Team': {
//    '@Id': 2,
//    'Name': 'Software Developers',
//    'Description': 'Creators of fine software products and services.'
//  }
//}";

//XNode node = JsonConvert.DeserializeXNode(json, "Root");

//Console.WriteLine(node.ToString());