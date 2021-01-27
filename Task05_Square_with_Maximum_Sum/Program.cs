using System;
using System.Linq;

namespace Task05_Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = size[0];
            int colums = size[1];

            int[,] matrix = new int[rows, colums];
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    matrix[row, colum] = elements[colum];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = 0;
            int columIndex = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int colum = 0; colum < colums - 1; colum++)
                {
                    int curentSum = matrix[row, colum] + matrix[row + 1, colum] + matrix[row, colum + 1] + matrix[row + 1, colum + 1];
                    if(curentSum > maxSum)
                    {
                        maxSum = curentSum;
                        rowIndex = row;
                        columIndex = colum;
                    }
                }
            }

            Console.WriteLine($"{matrix[rowIndex, columIndex]} {matrix[rowIndex, columIndex + 1]}");
            Console.WriteLine($"{matrix[rowIndex + 1, columIndex]} {matrix[rowIndex + 1, columIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
