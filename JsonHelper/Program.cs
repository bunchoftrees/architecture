using System;
using Newtonsoft.Json;

namespace JsonHelper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fileName = @"/Users/forrest.hartley/git/cSharp/JsonHelper/Products_Course_Mapping_b2c.json";

            string jsonText = File.ReadAllText(fileName);

            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<Product>(jsonText);

            
        }
    }
}

