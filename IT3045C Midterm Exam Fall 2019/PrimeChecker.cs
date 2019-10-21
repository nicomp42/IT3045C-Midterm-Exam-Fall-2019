/*
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 * Solution to Midterm Exam IT3045C Fall 2019
 */ 
using System;

namespace IT3045C_Midterm_Exam_Fall_2019
{
    class PrimeChecker
    {
        public static Boolean IsPrime(int num)
        {
            Boolean isPrime = true;     // Assume the best
            int limit = num / 2;
            if (num % 2 == 0) { return false; }
            for (int i = 3; i <= limit; i++)
            {
                if (num % i == 0) { isPrime = false; break; }
            }
            return isPrime;
        }
        /// <summary>
        /// Get the next higher or lower prime
        /// </summary>
        /// <param name="num">Number to start from</param>
        /// <param name="increment">1 for next highest, -1 for next lowest</param>
        /// <returns></returns>
        public static int GetAdjacentPrime(int num, int increment)
        {
            int nextPrime = num + increment;
            while (!IsPrime(nextPrime))
            {
                nextPrime += increment;
            }
            return nextPrime;
        }
    }
}
