using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marik_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"../../input.txt";
            string outputFile = @"../../output.txt";

            try
            {
                string content = File.ReadAllText(inputFile);
                string capitalizedContent = CapitalizeWords(content);

                File.WriteAllText(outputFile, capitalizedContent);

                Console.WriteLine("File successfully processed!");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while processing the file:");
                Console.WriteLine(e.Message);
            }

        }
        static string CapitalizeWords<T>(T input)
        {
            string content = input.ToString();

            return content.ToUpper();
        }
    }
}
