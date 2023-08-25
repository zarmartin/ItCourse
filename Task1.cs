using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[4, 4];
            Console.WriteLine("Matrix before change:");
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = random.Next(2, 100);



                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("Matrix after change:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i <= j)

                        a[i, j] = 1;

                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}