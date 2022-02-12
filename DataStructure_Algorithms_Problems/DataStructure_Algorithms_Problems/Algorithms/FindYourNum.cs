using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithms_Problems.Algorithms
{
    internal class FindYourNum
    {
        public static void FindYourNumber()
        {
            Console.WriteLine("Think of a number between 0 and 99");

            int leftValue = 0, rightValue = 100;

            while ((rightValue - leftValue) > 0)
            {
                int midValue = (rightValue + leftValue) / 2;

                Console.WriteLine("Is {0} your number ? \nEnter y or n", midValue);
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    Console.WriteLine("Your number is " + midValue);
                    break;
                }

                Console.WriteLine("Is your number between {0} and {1}\nEnter y or n", leftValue, midValue);
                string userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "y":
                        rightValue = midValue;
                        break;
                    case "n":
                        leftValue = midValue;
                        break;
                }
            }
        }
    }
}
