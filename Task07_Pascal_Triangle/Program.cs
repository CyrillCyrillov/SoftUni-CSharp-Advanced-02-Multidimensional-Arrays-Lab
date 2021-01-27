using System;

namespace Task07_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[lines][];

            for (int row = 0; row < lines; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                for (int colum = 0; colum <= row ; colum++)
                {
                    if(colum == 0 || colum == row )
                    {
                        pascalTriangle[row][colum] = 1;
                    }
                    else
                    {
                        pascalTriangle[row][colum] = pascalTriangle[row - 1][colum - 1] + pascalTriangle[row - 1][colum];
                    }

                    Console.Write(pascalTriangle[row][colum]);
                    if(colum != row )
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }
            
            //Console.WriteLine("Hello World!");
        }
    }
}
