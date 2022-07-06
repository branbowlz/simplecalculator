using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Kiosk_Project
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Thank you for using my calculator. This calculator does simple adding, subtracting, multiplying and division");
            Console.WriteLine("Please press the corresponding number to the mathematical operation you would like to do.");
            Console.WriteLine("1: Addtion | 2: Subtraction | 3: Multiplication | 4: Division");
            int mathtime = int.Parse(Console.ReadLine());
            while(mathtime < 1 || mathtime > 4)
            {
                Console.WriteLine("Invalid number. Please enter in a number between 1 and 4");
                mathtime = int.Parse(Console.ReadLine());   
                
            }
            if(mathtime == 1)
            {
                    
               AdditionTime();
            }
            if(mathtime == 2)
            {
                SubtractionTime();
            }
            if(mathtime == 3) 
            {
                MultiplyTime();
            }
            if(mathtime == 4) 
            {
                DivideTIme();
            }
            
        }

        static double AdditionTime()
        {
            Console.Clear();
            Console.WriteLine("You have chosen: Addition");
            Console.WriteLine("Please enter in your first number");
             double add1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in your second number");
             double add2 = double.Parse(Console.ReadLine());
             double AddAnswer = add1 + add2;
            Console.WriteLine(add1 + " + " + add2 + " = " + AddAnswer);
            return AddAnswer;
        }
        static double SubtractionTime()
        {
            Console.Clear();
            Console.WriteLine("You have chosen: Subtraction");
            Console.WriteLine("Please enter in your first number");
            double sub1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in your second number");
            double sub2 = double.Parse(Console.ReadLine());
            double SubAnswer = sub1 - sub2;
            Console.WriteLine(sub1 + " - " + sub2 + " = " + SubAnswer);
            return SubAnswer;
        }
        static double MultiplyTime()
        {
            Console.Clear();
            Console.WriteLine("You have chosen: Multiplication");
            Console.WriteLine("Please enter in your first number");
            double mult1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in your second number");
            double mult2 = double.Parse(Console.ReadLine());
            double MultAnswer = mult1 * mult2;
            Console.WriteLine(mult1 + " * " + mult2 + " = " + MultAnswer);
            return MultAnswer;
        }
        static double DivideTIme()
        {
            Console.Clear();
            Console.WriteLine("You have chosen: Division");
            Console.WriteLine("Please enter in your first number");
            double div1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter in your second number");
            double div2 = double.Parse(Console.ReadLine());
            double DivAnswer = div1 / div2;
            Console.WriteLine(div1 + " / " + div2 + " = " + DivAnswer);
            return DivAnswer;
        }
    }
}
