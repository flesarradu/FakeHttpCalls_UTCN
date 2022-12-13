// See https://aka.ms/new-console-template for more information

using System.Net.Http.Json;
using FakeHttpCalls_UTCN;

int id = 4;
            foreach (var line in System.IO.File.ReadAllLines(@"C:\Users\flesa\OneDrive\Documents\paul_bolnav.txt"))
            {
                using (var client = new HttpClient())
                {
                    Message mess = new Message { Id = id, User = "paul", Text = line };
                
                    client.BaseAddress = new Uri("https://rest-apiproiect2utcn20221212231729.azurewebsites.net");
                    var response = client.PostAsJsonAsync("api/Messages", mess).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Bravoo");
                    }
                    else
                    {
                        Console.WriteLine("Nu bravoo");
                    }
                    id++;
                }
            }
