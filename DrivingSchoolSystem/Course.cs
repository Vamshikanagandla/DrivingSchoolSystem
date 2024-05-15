using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingSchoolSystem
{
    public class Course
    {
        public int CourseId { get; private set; }
        public String Type { get; private set; }
        public decimal Fee { get; private set; }

        public Course(int courseId, String type, decimal fee)
        {
            CourseId = courseId;
            Type = type;
            Fee = fee;
        }
    }

}
