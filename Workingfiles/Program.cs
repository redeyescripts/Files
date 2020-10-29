using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Workingfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\data\test.txt";
            List<string> dataFromfile = File.ReadAllLines(filePath).ToList();
              foreach(string line in dataFromfile)
            {
                Console.WriteLine($"Data from {line}");
            }
            dataFromfile.Add("grapes");
            File.WriteAllLines(filePath, dataFromfile);
            Console.ReadLine();
        }
       
            
            
            

            



    }
          
}
