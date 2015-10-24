using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Davis_section_3
{
    class instructor
    {
        public string teacherName;
        public string courseName;

        public instructor(string teacherName, string courseName)
        {
            teacherName = teacherName;
            courseName = courseName;
        }





        public void SetStudentGrade(student Student, int Grade)
        {
            Student.SetGrade(Grade);
        }


        

    }
}

