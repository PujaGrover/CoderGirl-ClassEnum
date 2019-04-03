using System;
using System.Collections.Generic;

namespace ClassEnum
{
    public static class Program
    {
        public static void Main()
        {
            List<CourseType> courseType = new List<CourseType>() {
                new CourseType() { teacherName = "Geography Teacher", CourseSubject = CourseSubject.Geography },
                new CourseType() { teacherName = "WorldHistory Teacher", CourseSubject = CourseSubject.WorldHistory },
                new CourseType() { teacherName = "Math Teacher", CourseSubject = CourseSubject.Math },
                new CourseType() { teacherName = "English Teacher", CourseSubject = CourseSubject.English },
                new CourseType() { teacherName = "Chemistry Teacher", CourseSubject = CourseSubject.Chemistry },
                new CourseType() { teacherName = "Biology Teacher", CourseSubject = CourseSubject.Biology },
                new CourseType() { teacherName = "MedicalScience Teacher", CourseSubject = CourseSubject.MedicalScience },
                new CourseType() { teacherName = "CreativeWriting Teacher", CourseSubject = CourseSubject.CreativeWriting },
            };

            foreach (var subject in courseType)
            {
                switch(subject.CourseSubject)
                {
                    case CourseSubject.Geography:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.Geography));
                        break;

                    case CourseSubject.WorldHistory:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.WorldHistory));
                        break;

                    case CourseSubject.Math:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.Math));
                        break;

                    case CourseSubject.English:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.English));
                        break;

                    case CourseSubject.Chemistry:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.Chemistry));
                        break;

                    case CourseSubject.Biology:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.Biology));
                        break;

                    case CourseSubject.MedicalScience:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.MedicalScience));
                        break;

                    case CourseSubject.CreativeWriting:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(GetCourseSubjectName(CourseSubject.CreativeWriting));
                        break;

                    default:
                        break;

                }
            }

            //Console.WriteLine(GetCourseSubjectName(CourseSubject.Geography));
            //Console.WriteLine(GetCourseSubjectName(CourseSubject.WorldHistory));

            Console.ReadLine();
        }

       
        

        public static string GetCourseSubjectName(CourseSubject subject)
        {
            return $"{subject}";
            
            //return the enum subject as a string. IOW, if you pass in CourseSubject.Math, the method should return "Math".
        }
    }
    public class CourseType
    {
        public string teacherName { get; set; }
        public CourseSubject CourseSubject { get; set; }
    }

    //Create an enum named CourseSubject. 
    //It should contain at least 8 subjects, two of which must be Geography and WorldHistory
    public enum CourseSubject
    {
       Geography,
       WorldHistory,
       Math,
       English,
       Chemistry,
       Biology,
       MedicalScience,
       CreativeWriting
    }
}
