
using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[]args)
        {
            Course course = new Course();
            course.CourseName = "Yazılım Geliştirici Yetiştirme Kampı";
            course.Teacher = "Engin Demiroğ";
            course.Viewership = 96;
            Course course1 = new Course();
            course1.CourseName = "C#";
            course1.Teacher = "Engin Demiroğ";
            course1.Viewership = 85;
            Course course2 = new Course();
            course2.CourseName = "Java";
            course2.Teacher = "Kerem Varış";
            course2.Viewership = 68;
            Course course3 = new Course();
            course3.CourseName = "Python";
            course3.Teacher = "Berkay Bilgin";
            course3.Viewership = 60;

            //Console.WriteLine(course.CourseName+ " : "+ course.Teacher+ " " + " % "+ course.Viewership);
            //Console.WriteLine();
            //Console.WriteLine(course1.CourseName+ " : "+ course1.Teacher+ " "+ " % "+ course1.Viewership);
            //Console.WriteLine();
            //Console.WriteLine(course2.CourseName+ " : "+ course2.Teacher+ " "+ " % "+ course2.Viewership);
            //Console.WriteLine();
            //Console.WriteLine(course3.CourseName + " : " + course3.Teacher + " " + " % " + course3.Viewership);
            Course[] courses = new Course[] { course,course1, course2, course3 };
            foreach (var kurs in courses)
            {
                Console.WriteLine(kurs.CourseName + " : "+ kurs.Teacher+ " "+ " % "+ kurs.Viewership);
            }

        }
    }
    class Course
    {
        public string CourseName { get;set; }
        public string Teacher { get;set; }
        public int Viewership { get; set; }

    }




}