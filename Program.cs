/* Program.cs
 * 
 * Console Application that presents a menu of options and allows the user to make selections. 
 * Each option corresponds to a specific task.
 * 
 * Revision History:
 *   Matheus Santos: Mar 15, 2024: Created 
 *  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3SantosMShahD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Global variables
            int choice;

            // Create do-while loop
            do
            {
                // Menu
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("MENU");
                Console.WriteLine("1. Perform Calculations of 10 sequential numbers.");
                Console.WriteLine("2. Solve the sum of two numbers.");
                Console.WriteLine("3. Exit the program.");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Please select an option by entering the corresponding number (1-3):");

                // Get user choice
                choice = Convert.ToInt32(Console.ReadLine());

                // Execute user choice
                switch (choice)
                {
                    case 1:
                        PerformCalculations();
                        break;
                    case 2:
                        SolveSumOfTwoNumbers();
                        break;
                    case 3:
                        Console.WriteLine("\nGoodbye!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice. Try again!\n");
                        break;
                }
            } while (choice != 3);

            Console.ReadKey();
        }

        // Create perform calculations method
        static void PerformCalculations()
        {
            Console.WriteLine();

            // Declare variables
            int startingNumber, result;

            // Get user input
            Console.Write("Enter the starting number: ");
            startingNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Below, we have the multiplication of 10 sequential numbers starting from {startingNumber}:");

            // Verify if number is even or odd, and display the results of each calculation to the user
            for (int i = 0; i < 10; i++)
            {
                if (startingNumber % 2 == 0)
                {
                    result = startingNumber * 3;
                    Console.WriteLine($"{startingNumber} * 3 = {result}");
                    startingNumber++;
                }
                else
                {
                    result = startingNumber * 2;
                    Console.WriteLine($"{startingNumber} * 2 = {result}");
                    startingNumber++;
                }
            }

            Console.WriteLine("Note: Odd numbers are multiplied by 2, and Even numbers are multiplied by 3.\n");
        }

        // Create arithmetic problem method
        static void SolveSumOfTwoNumbers()
        {
            // Create random number and variable playAgain
            Random random = new Random();
            string playAgain = "Y";

            // Create while loop
            while (playAgain.ToLower() == "y")
            {
                // Create variables
                int num1 = random.Next(0, 100);
                int num2 = random.Next(0, 100);
                int correctAnswer = num1 + num2;
                string userAnswer;

                // Create do-while loop
                do
                {
                    Console.WriteLine();

                    // Ask user for answer
                    Console.Write($"What is {num1} + {num2}?: ");
                    userAnswer = Console.ReadLine();

                    // Check if answer is correct
                    if (Convert.ToInt32(userAnswer) == correctAnswer)
                    {
                        Console.WriteLine("Correct! Well done!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect. Try again!");
                    }
                } while (true);

                Console.WriteLine();

                // Ask user if they want to play again
                Console.Write("Would you like another question? (y/n): ");
                playAgain = Console.ReadLine();
            }
        }
    }
}