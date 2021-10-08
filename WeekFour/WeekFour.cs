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


        static void Reverse()
        {
            int inputNum = 0;
            while (true)
            {
                Console.WriteLine("Enter a positive integer from 1 - 50000000");
                inputNum = int.Parse(Console.ReadLine());
                if (inputNum > 0 && inputNum < 50000001)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Bad input!");
                }
            }
            string result = inputNum.ToString();
            for (int x = result.Length-1; x >= 0; x--)
            {
                Console.WriteLine(result[x]);
            }

        }

        static void Average()
        {
            int sum = 0;
            int count = 0;

            bool run = true;

            while (run == true)
            {
                Console.WriteLine("Enter a number, enter x or X to exit");
                string input = Console.ReadLine();
                if (input == "x" || input == "X")
                {
                    if (count > 0)
                    {
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("The number count cannot be 0");
                    }
                }
                else
                {
                    count++;
                    sum += int.Parse(input);
                }
            }

            Console.WriteLine(sum / count);
        }

        static void Algebra()
        {
            float a, b, x;
            while (true)
            {
                Console.Write("Enter a: ");
                a = float.Parse(Console.ReadLine());
                Console.Write("Enter b: ");
                b = float.Parse(Console.ReadLine());
                if (a != 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("a cannot be zero");
                }
            }
            x = (0 - b)/a;

            Console.WriteLine("The x is equal to: {0}", x);
        }

        static void Menu()
        {
            bool run = true;
            string input = "";

            while (run == true)
            {
                Console.WriteLine("Enter a menu selection:\n1 for Reverse\n2 for Average\n3 for Algebra\nx to exit");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Reverse();
                        break;
                    case "2":
                        Average();
                        break;
                    case "3":
                        Algebra();
                        break;
                    case "x":
                        run = false;
                        break;
                    case "X":
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Bad selection, choose again");
                        break;
                }
            }


        }
        static void Main(string[] args)
        {
            //NumberTwo();
            //Console.WriteLine(NumberThree(55560));
            //int[] array = { 4, 1, 1, 2, 2, 2, 4, 4, 1, 2, 4, 4, 3 };
            //Console.WriteLine(NumberSix(array));
            Menu();

        }
    }
}
