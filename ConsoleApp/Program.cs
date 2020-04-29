using System;
using ClassLibrary;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp
{
    class Program
    {
        public static IConfiguration Configuration { get; set; }
        
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            Configuration = config;
            
            Console.WriteLine(Configuration.GetSection("ConnectionStrings")["pgUser"]);
            new Class1(config);
        }
    }
}