using System;

namespace MatrixMul
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.MulTwoDArray();
            Console.ReadLine();
        }

        void MulTwoDArray()
        {
            Console.Write("Enter Number of Rows & Column of Matrix:- ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[,] array = new int[arrayLength, arrayLength];
            int[,] arraySecond = new int[arrayLength, arrayLength];
            int[,] arrayMul = new int[arrayLength, arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("This is Your First Matrix:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(array[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + array[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Enter Your Second Matrix");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    Console.Write("Array Index [{0}][{1}]:- ", i, j);
                    arraySecond[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("This is Your Second Matrix:-");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(arraySecond[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arraySecond[i, j]);
                    }

                }
                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Do you want to multiply this Matrix:- (Y/N)");

            string userInput = Convert.ToString(Console.ReadLine());

            if (userInput.ToUpper() == "Y")
            {
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        arrayMul[i, j] = array[i, j] * arraySecond[i, j];
                    }
                }
                Console.WriteLine("---------------------------------------------------------------------");
                Console.WriteLine("Array is Multiplied Successfully And the Result is:");
                Console.WriteLine("---------------------------------------------------------------------");
                for (int i = 0; i < arrayLength; i++)
                {
                    for (int j = 0; j < arrayLength; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write(arrayMul[i, j]);
                        }
                        else
                        {
                            Console.Write(" " + arrayMul[i, j]);
                        }

                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Please Press Enter");
            }

        }
    }
}
