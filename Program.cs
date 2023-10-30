using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GeekTrust
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputData = File.ReadAllLines(args[0]);
                List<string> inputDataAsString = inputData.ToList<string>();
                //Add your code here to process the input commands
                inputDataAsString.ForEach(input => Console.WriteLine(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}
