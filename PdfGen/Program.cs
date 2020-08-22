using System;
using Microsoft.Extensions.Configuration;

namespace PdfGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string logSnippet = "[Program][Main] => ";

            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Environment.GetEnvironmentVariable("APPSETTINGS_DIRECTORY"))
                .AddJsonFile("PdfGen.config.json", optional: false, reloadOnChange: true)
                .Build();
            string template = config["AppConfiguration:Templates:SF2806:Filename"];
            Console.WriteLine(logSnippet + $"(template): '{template}'");
        }
    }
}