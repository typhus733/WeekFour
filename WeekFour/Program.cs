using System;

namespace WeekFour
{
    class Program
    {

        static int GetMax(int nOne, int nTwo)
        {
            int max = 0;
            if (nOne > nTwo)
            {
                max = nOne;
            }

            else
            {
                 max = nTwo;
            }

            return max;
        }

        static void NumberTwo()
        {
            Console.WriteLine("Enter the first number");
            int intOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int intTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int intThree = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(intOne, intTwo), intThree));
        
        }


        static void Main(string[] args)
        {
            NumberTwo();
        }
    }
}
