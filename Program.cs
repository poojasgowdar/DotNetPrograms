using System;
using System.Data;
namespace Transpose_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows;
            int cols;
            Console.WriteLine("Enter the Number of Rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number of Cols:");
            cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            //Input the Elements into the Matrix
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Element [{i}{j}]:");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }

            }

            //Transpose of Matrix
            int[,] transpose = new int[rows, cols];
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            //Print the Matrix
            Console.WriteLine("The Original Matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"{matrix[i, j]}");
                }
                Console.WriteLine();
            }

            //Print the transposed Matrix
            Console.WriteLine("\n Transpose Matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"{transpose[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

                  
        }
    }
}
