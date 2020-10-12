using System;

namespace frågesport
{
    class Program
    {
        static void Main(string[] args)
        {

            string answer1;

            Console.WriteLine("Hello, and welcome to the Rick and Morty quiz! You will be met by 5 questions and 3 options for each question, a, b, or c. Only one option is right and you will have to use your rick and morty knowledge to select the right option.");

            Console.WriteLine("Question 1: WHat is the name of Mortys father? a) Jerry   b) Rick   c) Joe");

            answer1 = Console.ReadLine().ToLower();

            while (answer1 != "a" && answer1 != "b" && answer1 != "c")
            {
                System.Console.WriteLine("Please select one of the options: a, b, or c");
                answer1 = Console.ReadLine().ToLower();
            }

            if (answer1 == "a")
            {
                Console.WriteLine("Correct!");

            }


            else if (answer1 == "b")
            {
                Console.WriteLine("WRONG!");

            }


            else if (answer1 == "c")
            {
                Console.WriteLine("...mama! Also, you were WRONG");

            }


            Console.ReadLine();

        }
    }
}
