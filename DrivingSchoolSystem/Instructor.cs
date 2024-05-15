using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolSystem
{
    public class Instructor
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Specialization { get; private set; }
        public DateTime EnrollmentDate { get; private set; }

        public Instructor(int id, string name, string email, string phone, string specialization)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Specialization = specialization;
            EnrollmentDate = DateTime.Now;
        }
    }

}
