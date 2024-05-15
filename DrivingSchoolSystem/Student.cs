using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolSystem
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public DateTime EnrollmentDate { get; private set; }

        public string Instructor { get; set; }

        public string Duration { get; set; }

        public Student(int id, string name, string email, string phone, string gender, DateTime dob, string instructor, string duration)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Gender = gender;
            Dob = dob;
            EnrollmentDate = DateTime.Now;
            Instructor = instructor;
            Duration = duration;

        }
    }

}
