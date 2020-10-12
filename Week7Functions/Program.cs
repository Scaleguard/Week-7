using System;

namespace Week7Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write a function that takes in user's
            year of birth, calculates
            and displays the user's age*/
            Console.WriteLine("Enter your year of birth");
            string userInput = Console.ReadLine();
            CalculateAge(userInput);
        }
        public static void CalculateAge(string yearOfBirth)
        {
            int usersYearofBirth = Int32.Parse(yearOfBirth);
            Console.WriteLine($"You are {2020-usersYearofBirth} years old");
        }

    }
}
