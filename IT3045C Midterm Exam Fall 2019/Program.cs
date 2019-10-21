/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Solution to Midterm Exam IT3045C Fall 2019
 */
using System;

namespace IT3045C_Midterm_Exam_Fall_2019
{
    class Program
    {
        /// <summary>
        /// Briefly exercise the PrimeChecker class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            int input = 0;
            Console.WriteLine("Enter a positive integer please. ");
            input = Convert.ToInt32(Console.ReadLine());
            if (PrimeChecker.IsPrime(input)) {
                Console.WriteLine("Next prime = " + PrimeChecker.GetAdjacentPrime(input, 1));
                Console.WriteLine("Previous prime = " + PrimeChecker.GetAdjacentPrime(input, -1));

            } else {
                Console.WriteLine(input + " is not prime");
            }
        }
    }
}
