using System;
using System.Collections.Generic;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        private static int counter;
        private static int i;

        static void Main(string[] args)
        {
            Counter();

            PauseConsole();

            CounterThree();

            PauseConsole();

            var NumInput1 = GiveMeANumber();
            var NumInput2 = GiveMeANumber();

            EqualOrNot(NumInput1, NumInput2);

            PauseConsole();

            NumInput1 = GiveMeANumber();
            OddOrEven(NumInput1);

            PauseConsole();

            NumInput1 = GiveMeANumber();
            PositiveOrNegative(NumInput1);

            PauseConsole();

            var yourAge = "";
            Console.Write("Please enter your age: ");
            yourAge = Console.ReadLine();
            AgeChecker(yourAge);

            Console.WriteLine("But wait, there's more...");
            NumInput1 = GiveMeANumber();
            RangeFinder(NumInput1);

            PauseConsole();

            Console.WriteLine("Let's multiply!!");
            Console.WriteLine("Now we will multipy the number you enter by numbers 1 - 12," +
                " displaying the products of each number." +
                " Prepare to be dazzled!");
            NumInput1 = GiveMeANumber();

            MultipyThis(NumInput1);
          
        }

        private static void MultipyThis(int num)
        {
            for(int counter = 0; counter <= 12; counter++)
            {
                Console.WriteLine($"{num} * {counter} = " + (num * counter));
            }
           
        }

        //Determines whether an integer is in the range -10 to 10.
        private static void RangeFinder(int num)
        {
            if (num >= -10 && num <= 10)
            {
                Console.WriteLine($"{num} is within the range -10 to 10. Rock on.");
            }
            else
            {
                Console.WriteLine($"{num} is not in the range -10 to 10. I know, anti-climactic.");
            }

        }

        //Determines whether a user can vote based on their age
        private static void AgeChecker(string yourAge)
        {
            //bool canVote;
            //object TryParse = null;
            var age = 0;

            if (Int32.TryParse(yourAge, out age))
            {
                if (age >= 18)
                {
                    Console.WriteLine($"You are {age}, and gosh darn it, you can vote!");
                }
                else
                {
                    Console.WriteLine($"You are {age}. Legally, you can't vote. Saw-weee.");
                }
            }
            else
            {
                Console.WriteLine("Try entering a number next time...");
            }


        }

        //Determines whether a number is positive or negative
        private static void PositiveOrNegative(int num1)
        {
            bool isPositive;
            if (num1 > 0)
            {
                isPositive = true;
                Console.WriteLine($"{num1} is positive. Learn something new everyday.");
            }
            else if (num1 < 0)
            {
                isPositive = false;
                Console.WriteLine($"{num1} is negative. Is that okay?.");

            }
            else
            {
                isPositive = false;
                Console.WriteLine($"{num1} is neither positive, nor negative. This is intense.");
            }
        }

        //Determines whether a number is odd or even
        private static void OddOrEven(int num1)
        {
            bool isEven;
            if (num1 % 2 == 0)
            {
                isEven = true;
                Console.WriteLine($"{num1} is an even number. Amazing.");
            }
            else
            {
                isEven = false;
                Console.WriteLine($"{num1} is odd. Very odd.");

            }

        }

        //For anytime you want user to enter a number
        private static int GiveMeANumber()
        {
            Console.Write("Give me a number: ");
            int NumInput = int.Parse(Console.ReadLine());

            return NumInput;
        }

        //Pauses between each method
        private static void PauseConsole()
        {
            Console.WriteLine();
            Console.WriteLine("Press enter to see what's next!");
            Console.ReadLine();

        }

        //Compares two integars to determine whether they are equal
        private static void EqualOrNot(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Looks like they're equal!");
            }
            else
            {
                Console.WriteLine($"{num1} is not equal to {num2}. Womp womp.");
            }

        }

        //Count by 3's to 999
        private static void CounterThree()
        {
            var num = 0;
            do
            {
                num += 3;
                Console.WriteLine(num);
            } while (num < 999);
        }

        //Print 1000 thru -1000 method
        private static void Counter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
