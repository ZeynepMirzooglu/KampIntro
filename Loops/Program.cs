using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] courses = new string[]
            {
                "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java","C#","Pyhton"
            };

            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }
            Console.WriteLine("***********");
            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            Console.WriteLine("***********");

            Console.WriteLine("sayfa sonu- footer");
            
        }
    }
    
}
