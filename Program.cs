using System;

namespace BranchAndLoops
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExploreIf();
            ExploreLoop();

             void ExploreIf()
            {
            Console.WriteLine("-----------------");
            Console.WriteLine("ExploreIf");
            Console.WriteLine("-----------------");
            int a = 5;
            int b = 6;
            if (a + b > 10) Console.WriteLine("The answer is greater than 10");

            Console.WriteLine("");
            Console.WriteLine("* If...Else");

            a = 5;
            b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");

            Console.WriteLine("");
            Console.WriteLine("* && Operator");

            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console
                    .WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console
                    .WriteLine("Or the first number is not equal to the second");
            }

            Console.WriteLine("");
            Console.WriteLine("* || Operator");

            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
            Console.WriteLine("");
            }
            
            void ExploreLoop()
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("ExploreLoop");
                Console.WriteLine("-----------------");

                Console.WriteLine("");
                Console.WriteLine("* While");

                int counter = 0;
                while (counter < 10)
                {
                     Console.WriteLine($"Hello World! The counter is {counter}");
                     counter++;
                }

                Console.WriteLine("");
                Console.WriteLine("* Do...While");
                counter = 0;
                do
                {
                    Console.WriteLine($"Hello World! The counter is {counter}");
                    counter++;
                } while (counter < 10);

                Console.WriteLine("");
                Console.WriteLine("* For");
                for (int index = 0; index < 10; index++)
                {
                     Console.WriteLine($"Hello World! The index is {index}");
                }

                Console.WriteLine("");
                Console.WriteLine("* Nested Loop");

                for (int row = 1; row < 11; row++)
                {
                     for (char column = 'a'; column < 'k'; column++)
                    {
                        Console.WriteLine($"The cell is ({row}, {column})");
                    }
                }
                
                Console.WriteLine("");
                Console.WriteLine("* Combine Branches And Loops");
                int sum = 0;
                for (int i = 1; i < 20; i++)
                {
                    if ((i % 3)==0)
                     {
                           sum= sum + i;
                     }
                }
                Console.WriteLine($"The Sum of no. divisible by 3 in (1-20) is {sum}");

            }
        }
    }
}
