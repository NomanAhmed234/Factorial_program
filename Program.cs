//Write a program to explain method in C#. Create a static function factorial() that 
//accept a number from user and returns factorial of the number.

using System.ComponentModel;

namespace Lab_6q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the nimber for Fctorial");
             number = Convert.ToInt32(Console.ReadLine());
            factorial(number);

        }
        public static int factorial(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
                //Console.WriteLine(i);
                fact = fact * i;

            }
            Console.WriteLine("factorial of {0} is {1}", number, fact);
            return fact;
           
        }
    }
}