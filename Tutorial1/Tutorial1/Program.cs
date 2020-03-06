using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tutorial1
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            //    int g = 0;
            //    bool b = true;

            //    int age = 25;

            //    Console.WriteLine($"I am {age} years old");
            //    Console.WriteLine("Hello World!");

            var url = @"https://pja.edu.pl/dziekanat";

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var regex = new Regex("[a-z]+[a-z0-9]*@[a-z]+\\.[a-z]+", RegexOptions.IgnoreCase);

                    var matches = regex.Matches(content);

                    foreach (var match in matches)
                    {
                        Console.WriteLine(match.ToString());
                    }
                }
            }

        
            
        }
    }
}
