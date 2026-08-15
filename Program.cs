using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;

            int result = 0;

            string  answer;
            
            Console.WriteLine("welcome to calculator");
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What type of operation would you like to perform?");
            Console.WriteLine("Please enter an a for add,s for subtraction,m for multiply,or d for divide. ");
            
            answer = Console.ReadLine();

            if(answer == "a")
            {
                result = num1 + num2;
            } 
            if (answer == "s")
            {
                result = num1 - num2;
            } 
            if (answer == "m")
            {
                result = num1 * num2;
            }
            if (answer == "d")
            {
                result = num1 / num2;
            }

            Console.WriteLine("output: "+ result);//end
           
        }
    }
}