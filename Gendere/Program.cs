using System;

namespace Gendere
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a program that asks the user's gender:
             * m for "male"
             * f for "female"
             * the program greets the users by assuming 
             * the gender provided:
             * "Hello, Sir"
             * "Hello, Madam!"
             */
            Console.WriteLine("What's your gender!");
            string userinput = Console.ReadLine().ToLower();
            GuessGender(userinput);
            

        }

        public static void GuessGender(string Gender)
        {
           if (Gender == "male")
           {
                Console.WriteLine("Hello Sir!");
           } else
           {
                Console.WriteLine("Hello Madam!");
           }
        }
    }
}
