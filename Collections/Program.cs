
using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Zeynep","Gani","Muhammed","Duygu"};

            List<string> names2 = new List<string>
            {
                "Zeynep","Gani","Muhammed","Duygu"
            };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ali");
            Console.WriteLine(names2[4]);
        }
    }
}

