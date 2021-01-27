using System;
using System.Linq;

namespace Task03_Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                int[] nextLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int colum = 0; colum < size; colum++)
                {
                    matrix[row, colum] = nextLine[colum];
                    if(row == colum)
                    {
                        sum += matrix[row, colum];
                    }
                }
            }
            
            Console.WriteLine(sum);
        }
    }
}
