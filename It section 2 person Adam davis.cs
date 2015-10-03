using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Section_2assignmentAdam_davis
{
    class Person
    {
        public int age;
        public string firstName;
        public string lastname;
        public Person spouse;

        public static int count;
        public static int SumOfAllAges;

        public static double AverageAge()
        {
            return (double)Person.SumOfAllAges / (double)Person.count;
        }

        public string GetFullName()
        {
            return this.firstName + " " + this.lastname;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
            System.Console.WriteLine(this.age);
        }

       
        public void AskforNameAge()
        {
            System.Console.Write(" first Name:   ");
            this.firstName = System.Console.ReadLine();

            System.Console.Write(" last Name:  ");
            this.lastname = System.Console.ReadLine();

            System.Console.Write(" Age:  ");
            this.age = int.Parse(System.Console.ReadLine());
            SumOfAllAges += this.age;
            Person.count++;
        }

            public void AskifMArried()
        {
            
            System.Console.Write("Are you married?  (y/n)");
            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                Person spouse = new Person();
                System.Console.WriteLine("Spouse Information");
                AskforNameAge(); 

            }  
          
            
           
            

        }




     






    }
}
