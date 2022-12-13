using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/*
 *  Test 1: Read the list of IP Addresses from appsettings.json and output to the console Window. You may edit any required Objects
 */


namespace BraintreeCSharpTest
{
    internal class Test01
    {
        private readonly IConfiguration config;
        private readonly Settings settings;

        public Test01()
        {
            // Build a config object, using env vars and JSON providers.
            config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();

            // Get values from the config given their key and their target type.
            settings = config.GetRequiredSection("Settings").Get<Settings>();
        }

        public void Run()
        {
            Console.Clear();
            // Write the values to the console.
            Console.WriteLine($"KeyOne = {settings.KeyOne}");
            Console.WriteLine($"KeyTwo = {settings.KeyTwo}");
            Console.WriteLine($"KeyThree:Message = {settings.KeyThree.Message}");

            // Your solution goes here

            if (settings.IPAddressRange != null) {

                foreach(var ip in settings.IPAddressRange )
                {
                    Console.WriteLine($"IP Address = {ip}");
                }
               
            }
      
            Console.WriteLine();
            Console.WriteLine("Enter to continue");
            Console.ReadLine();
        }
    }
}
