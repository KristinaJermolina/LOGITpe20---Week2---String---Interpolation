using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1. Program asks for user´s first and lastname
            2. Program asks for user´s year of birth
            3. Program greets the user by their name and displays their age

            NB! To display the result use one WriteLine line only!+
             */

            String FirstName;
            String LastName;
            Console.WriteLine("What is your first name?");
            FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            LastName = Console.ReadLine();
            Console.WriteLine("What is your birth of year?");
            string UserInput;
            UserInput = Console.ReadLine();
            int Age;
            Age = Int32.Parse(UserInput);
            int Year = 2020 - Age;
            Console.WriteLine("You were born in" + Age);
            Console.WriteLine($"Hello, {FirstName} {LastName} {Age}");



        }
    }
}
