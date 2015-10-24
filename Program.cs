using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adam_Davis_section_3
{
    class Program
    {
        static void Main(string[] args)
        {
            instructor john = new instructor("john", "English");
            instructor mike = new instructor("john", "Math");
            student jane = new student ("jane", 0, john );
            student joe = new student("joe", 0, john);
            student Melissa = new student("Melissa", 0, mike);
            student Matt = new student("Matt", 0, mike);
            john.SetStudentGrade(jane, 95);
            john.SetStudentGrade(joe, 85);
            mike.SetStudentGrade(Melissa, 90);
            mike.SetStudentGrade(Matt, 92);

            
          
            
        }

    }
}
