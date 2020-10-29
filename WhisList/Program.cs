using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhisList
{
    class Program
    {
        static void Main(string[] args)
        {
            

 
            
           
            
            List<string> wishes = new List<string>();

            for (int i = 0; i < 3; i++)

            {
                Console.WriteLine($"What wishes you want?");
                wishes.Add(Console.ReadLine());
            }
           
             string filePath = @"C:\Users\opilane\data\WishList.txt";
            
            File.WriteAllLines(filePath, wishes);
            Console.ReadLine();
        }
    }
}
