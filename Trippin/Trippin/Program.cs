using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Trippin
{
    class Program
    {
        private static readonly HttpClient HttpClient = new HttpClient() { BaseAddress = new Uri("https://services.odata.org/TripPinRESTierService/(S(xl0bqnlifipl440ghyxhyvmy))/") };

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var readUsers= await System.IO.File.ReadAllTextAsync("users.json");
            var users = JsonSerializer.Deserialize<User[]>(readUsers);

            foreach(User user in users)
            {
                if (!(await HttpClient.GetAsync(user.UserName)).IsSuccessStatusCode)
                {
                    var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
                    var userResponse = await HttpClient.PostAsync("People", content);
                    userResponse.EnsureSuccessStatusCode();
                    Console.WriteLine("Erstellt");
                }
            }
        }
    }
}
