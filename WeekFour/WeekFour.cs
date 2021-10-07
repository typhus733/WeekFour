using System;

namespace WeekFour
{
    class WeekFour
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

        static string NumberThree(int num)
        {
            string result = "";

            num = num % 10;

            switch (num)
            {
                case 0:
                    result = "Zero";
                    break;
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case 8:
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
            }

            return result;
        }

        static int NumberSix(int[] arr)
        {
            int result = -1;
            for (int x = 1; x < arr.Length - 1; x++) 
            {
                if (arr[x] > arr[x-1] && arr[x] > arr[x+1])
                {
                    result = x;
                    return result;
                }
            }
            return result;

        }




        static void Main(string[] args)
        {
            //NumberTwo();
            //Console.WriteLine(NumberThree(55560));
            //int[] array = { 4, 1, 1, 2, 2, 2, 4, 4, 1, 2, 4, 4, 3 };
            //Console.WriteLine(NumberSix(array));
           

        }
    }
}
