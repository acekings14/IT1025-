using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Davis_section_3
{
    class student
    {
        
        public string studentName;
        public int grade;
        public instructor teacher; 

        public void SetGrade(int Grade)
        {
            this.grade = grade;
        }


            public  string printInformation(string studentName, int grade)
        {

            return studentName + " " + grade;
        }

        public string GetStudentandTeacherName()
        {
            return studentName + teacher;
        }

        public student(string studentName, int grade, instructor teacher)
        {
            this.studentName = studentName;
            this.grade = grade;
            this.teacher = teacher;
        }

        public string Print()
        {
            return studentName + teacher + grade; 
        }



    }
    






    }

}