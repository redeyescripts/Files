using System;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
namespace ListAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<string> cookies = new List<string>();

            for(int i = 0; i < 3; i++)

            {
                Console.WriteLine("Enter a food");
                cookies.Add(Console.ReadLine());
            }
              int indexOfMilkcookie = cookies.IndexOf("Milkcookie");

               Console.WriteLine($"You choosed {indexOfMilkcookie}");

               cookies[indexOfMilkcookie] = "white";

             foreach(string cookieitem in cookies)
             {
                Console.WriteLine($"Cookie on the list : {cookieitem}");
             }
            cookies.RemoveAt(cookies.Count - 1);
                 
            foreach (string cookieitem in cookies)    
            {
                     Console.WriteLine($"Trimed cookike list {cookieitem}");
                 
            }
           
            


            Console.ReadLine();
        } 
    }
}

