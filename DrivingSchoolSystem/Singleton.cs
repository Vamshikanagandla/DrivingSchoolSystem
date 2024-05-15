using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolSystem
{
    class Singleton
    {
        static List<Student> students = new List<Student>
        {
            new Student(1234, "Student 1", "st1@mail.com", "123456789", "Male", new DateTime(2001, 8, 25), "NA", "NA"),
            new Student(2345, "Student 2", "st2@mail.com", "987654321", "Female", new DateTime(1997, 8, 05), "NA", "NA"),
        };

        public static List<Student> Students { get => students; set => students = value; }


        static List<Course> courses = new List<Course>
        {
            new Course (1, "Test Drive", 25000),
            new Course (2, "Test Drive 1", 25000),
            new Course (3, "Test Drive 2", 52000),
            new Course (4, "Test Drive 3", 75000),
            new Course (5, "Test Drive 4", 67000),
            new Course (6, "Test Drive 5", 5000),
            new Course (7, "Test Drive 6", 200),
        };

        public static List<Course> Courses { get => courses; set => courses = value; }

        static List<Instructor> instructors = new List<Instructor>
        {
            new Instructor(1, "Emma Thompson", "emma@mail.com", "123-456-7890", "Urban Driving Techniques"),
            new Instructor(2, "Daniel White", "daniel@mail.com", "987-654-3210", "Night Driving Skills"),
            new Instructor(3, "Sophia Garcia", "sophia@mail.com", "456-789-1230", "Defensive Driving Strategies"),

        };

        public static List<Instructor> Instructors { get => instructors; set => instructors = value; }


    }
}
