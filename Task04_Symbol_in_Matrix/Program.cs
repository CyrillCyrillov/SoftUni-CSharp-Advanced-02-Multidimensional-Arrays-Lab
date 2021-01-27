using System;
using System.Linq;

namespace Task04_Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] symbolsMatrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string nextLine = Console.ReadLine();
                for (int colum = 0; colum < size; colum++)
                {
                    symbolsMatrix[row, colum] = nextLine[colum];
                }
            }

            char lookFor = Console.ReadLine()[0];
            bool isFind = false;
            int rowIndex = -1;
            int columIndex = -1;

            for (int row = 0; row < size; row++)
            {
                for (int colum = 0; colum < size; colum++)
                {
                    if (symbolsMatrix[row, colum] == lookFor)
                    {
                        isFind = true;
                        rowIndex = row;
                        columIndex = colum;
                        break;
                    }
                }

                if (isFind)
                {
                    break;
                }
            }

            if (isFind)
            {
                Console.WriteLine($"({rowIndex}, {columIndex})");
            }
            else
            {
                Console.WriteLine($"{lookFor} does not occur in the matrix");
            }

        }
    }
}
