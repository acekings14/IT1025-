

namespace Adam_Davis_IT1025_Section_1assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleIntial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;
            int inchesperfoot = 12;
            double centimeters = 2.54;
            int totalInchesforft;
            double totalInches;
            double centimeterft;
            double centimeterin;
            double totalcentimeters;

            System.Console.Write("What is your firstName? ");
            firstName = System.Console.ReadLine();
            
            System.Console.Write("What is your middleIntial? ");
            middleIntial = System.Console.ReadLine();
           
           


            System.Console.Write("What is your lastName? ");
            lastName = System.Console.ReadLine();



            System.Console.Write(firstName + " " + middleIntial + "." + " " + lastName);
           

            

            System.Console.Write("How tall are you? (ft) ");
            heightFeet = int.Parse(System.Console.ReadLine());
            


            System.Console.Write("How many inches are you added to your base height in feet? ");
            heightInches = double.Parse(System.Console.ReadLine());



            totalInchesforft = heightFeet * inchesperfoot;
            centimeterft = totalInchesforft * centimeters;
            centimeterin = heightInches * centimeters;
            totalcentimeters = centimeterft + centimeterin;
            System.Console.Write(totalcentimeters = centimeterft + centimeterin);


            System.Console.Write("How old are  you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write(" Are you a citizen?");
            isCitizen = bool.Parse(System.Console.ReadLine());
            
            canVote = isCitizen && age >= 18;
            System.Console.WriteLine("Voter Eligibility:" + " " + canVote);


        }

    }





















      }
   

