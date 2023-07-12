using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        //create array
        string[] fortuneArray = { "lucky", "married", "divorced", "rich", "stronger", "more confident" };
        //asks user to enter a number
        Console.WriteLine("Please select a number from 0 to 5 and I will tell your fortune:");
        int choice = Convert.ToInt32(Console.ReadLine());
        bool fortune = false;

        while (!fortune)
        {
            try
            {
                Console.WriteLine("You will get " + fortuneArray[choice] + " within the next two years.");
                fortune = true;
            }
            //displays error
            catch 
            {
                Console.WriteLine("Sorry, I dont see your future in that number. Please select 0-5.");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }

        //create list
        List<string> traitlist = new List<string>()
        {
        "Kind",
        "Generous",
        "Helpful",
        "fair",
        "humble",
        "loyal",
         };

        //asks user to enter number
        Console.WriteLine("Please select another number from 0 to 5 and I tell you what kind of person you are.");
        int choice2 = Convert.ToInt32(Console.ReadLine());
        bool personality = false;

        while (!personality) 
        {
            try
            {
                Console.WriteLine("Your main personality trait is: " + traitlist[choice2] + ".");
                personality = true;
            }
            //error message
            catch 
            {
                Console.WriteLine("No, that is definitely not you. Please select 0 to 5");
                choice2 = Convert.ToInt32(Console.ReadLine());  
            }
        }

        Console.ReadLine();
       
    }

}
