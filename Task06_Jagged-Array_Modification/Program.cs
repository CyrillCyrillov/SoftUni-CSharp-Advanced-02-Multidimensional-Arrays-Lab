using System;
using System.Linq;

namespace Task06_Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            
            for (int row = 0; row < size; row++)
            {
                int[] nextLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int colum = 0; colum < size; colum++)
                {
                    matrix[row, colum] = nextLine[colum];
                }
            }

            while (true)
            {
                string[] comand = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(comand[0].ToUpper() == "END")
                {
                    break;
                }

                string typeComand = comand[0].ToUpper();
                int rowIndex = int.Parse(comand[1]);
                int columIndex = int.Parse(comand[2]);
                int value = int.Parse(comand[3]);

                if(rowIndex <= matrix.GetLength(0) - 1 && columIndex <= matrix.GetLength(1) - 1 && rowIndex >= 0 && columIndex >= 0)
                {
                    switch (typeComand)
                    {
                        case "ADD":
                            matrix[rowIndex, columIndex] += value;
                            break;

                        case "SUBTRACT":
                            matrix[rowIndex, columIndex] -= value;
                            break;


                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int colum = 0; colum < matrix.GetLength(1); colum++)
                {
                    Console.Write(matrix[row, colum]);
                    if(colum < matrix.GetLength(1) - 1)
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
