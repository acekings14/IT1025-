
namespace IT_1050_Section_2assignmentAdam_davis
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.AskforNameAge();
            person1.AskifMArried();

            Person person2 = new Person();
            person2.AskforNameAge();
            person2.AskifMArried();


            Person person3 = new Person();
            person3.AskforNameAge();
            person3.AskifMArried();


            System.Console.WriteLine("Average age" + Person. AverageAge());



        }
    }
}
