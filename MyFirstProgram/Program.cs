/* NAME: ABU LABIB MOHAMMED ASHFAQUL AWAL */
/* CLASS: NET-23 */
/* SCHOOL: CHAS ACADEMY, STOCKHOLM */


using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12; // Creating a variable and assigned value 12.

            /*Creating 'if - else' statement, which will check the condition as
            x is smaller or bigger than 10*/
            if (x > 10)
                Console.WriteLine("Value is bigger.");
            else
                Console.WriteLine("Oh! Value is smaller.");



            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //takes input from user and store the value in the variable.
            Console.WriteLine("Hi,"+name+"!");


            //Creating a 'for-loop' to print out number from 0 to value of x
            for (int i=0; i<=x; i++)
            {
                Console.WriteLine(i); // printing number from 0 to x for every iteration of i till i=x
            }


        }
    }
}



