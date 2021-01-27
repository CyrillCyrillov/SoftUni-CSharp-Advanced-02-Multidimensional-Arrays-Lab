using System;
using System.Linq;

namespace Task01_Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int colums = size[1];

            int[,] matrix = new int [rows, colums];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    matrix[row, colum] = elements[colum];
                    sum += elements[colum];
                }
            }
            
            Console.WriteLine(rows);
            Console.WriteLine(colums);
            Console.WriteLine(sum);
        }
    }
}
