using System;

namespace FunctionsReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your year of birth: ");
            string UserInput = Console.ReadLine();
            ValidateAge(CalculateAge(UserInput));
            //int userAge = CalculateAge(UserInput);
            //ValidateAge(userAge);
            //Console.WriteLine($"You are {userAge} years old");
        }

        public static int CalculateAge(string userInput)
        {
            int userAge = 2020 - Int32.Parse(userInput);
            return userAge; 
        }

        public static void ValidateAge(int age)
        {
            if(age < 18)
            {
                Console.WriteLine("You are not old enough to drive a car.");
            }else
            {
                Console.WriteLine("Go get your driving license!");
            }
        }

    }
}
