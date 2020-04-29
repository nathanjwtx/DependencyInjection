using System;
using Microsoft.Extensions.Configuration;

namespace ClassLibrary
{
    public class Class1
    {
        private readonly IConfiguration _configuration;

        public Class1(IConfiguration configuration)
        {
            _configuration = configuration;
            Testing();
        }

        public void Testing()
        {
            Console.WriteLine(_configuration.GetSection("ConnectionStrings")["pgHost"]);
        }
    }
}