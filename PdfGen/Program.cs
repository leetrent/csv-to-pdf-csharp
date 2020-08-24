using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using iText.Forms.Fields;
using PdfGen.Utils;

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
            Console.WriteLine(logSnippet + $"(template)........: '{template}'");

            string outputDirectory = config["AppConfiguration:OutputDirectory"];
            Console.WriteLine(logSnippet + $"(outputDirectory): '{outputDirectory}'");

            string outFile = "SF2806FieldNames.txt";
            Console.WriteLine(logSnippet + $"(outFile): '{outFile}'");

            string outputDestination = $"{outputDirectory}{outFile}";
            Console.WriteLine(logSnippet + $"(outputDestination): '{outputDestination}'");

            IDictionary<string, PdfFormField> pdfFields = PdfFieldsUtil.DiscoverPDFFields(template);
            PdfFieldsUtil.PrintPDFFields(pdfFields, outputDestination, false);
        }
    }
}