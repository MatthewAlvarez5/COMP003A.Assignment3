/*
 * Author: Matthew Alvarez
 * Course: COMP003A
 * Purpose: Week 3 Assignment 3
 */
namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* If-Else section (Numeric to Letter Grade */
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("|Numeric to Letter Grade Using an if-else statement|");
            Console.WriteLine("|--------------------------------------------------|\n");
            Console.Write("Enter a numeric grade (0.00 -> 100.00): ");
            double numericGrade = Convert.ToDouble(Console.ReadLine());
            if(numericGrade <= 100 && numericGrade >= 0)
            {
                if(numericGrade >= 90)
                {
                    Console.WriteLine("The Grade entered is equivalent to an A");
                }
                else if(numericGrade >= 80 && numericGrade < 90)
                {
                    Console.WriteLine("The Grade entered is equivalent to a B");
                }
                else if(numericGrade >= 70 && numericGrade < 80)
                {
                    Console.WriteLine("The Grade entered is equivalent to a C");
                }
                else if(numericGrade >= 60 && numericGrade < 70)
                {
                    Console.WriteLine("The Grade entered is equivalent to a D");
                }
                else
                {
                    Console.WriteLine("The Grade entered is equivalent to an F. You Failed. Skill issue?");
                }
            }
            else
            {
                Console.WriteLine("Invalid Number! What you tryna pull?");
            }

            /* Integer to string day of the week */
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n|--------------------------------------------|");
            Console.WriteLine("|Integer to string day using switch statement|");
            Console.WriteLine("|--------------------------------------------|\n");
            Console.Write("Enter an integer for the day of the week (1 is Sunday, 7 is Saturday): ");
            int numericDay = Convert.ToInt32(Console.ReadLine());
            switch (numericDay) 
            {
                case 1: Console.WriteLine("The day is Sunday, the first day of the week.");
                    break;
                case 2:
                    Console.WriteLine("The day is Monday, the first day of the WORK-week.");
                    break;
                case 3:
                    Console.WriteLine("The day is Tuesday, the day that stands out the least.");
                    break;
                case 4:
                    Console.WriteLine("The day is Wednesday, hump-day: the hardest day to spell.");
                    break;
                case 5:
                    Console.WriteLine("The day is Thursday, it's basically the second Tuesday of the week.");
                    break;
                case 6:
                    Console.WriteLine("The day is Friday, TGIF.");
                    break;
                case 7:
                    Console.WriteLine("The day is Saturday, the best day of the week.");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Blue;













        }
    }
}