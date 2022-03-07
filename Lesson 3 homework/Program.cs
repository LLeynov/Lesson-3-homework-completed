using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, выводящую элементы двухмерного массива по диагонали.
            
            int[,] matrix = new int[10, 10];

            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                matrix[a, a] = 1;
            }
               
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    System.Console.Write($"{matrix[i, j]} ");
                }
                System.Console.WriteLine();
            }
            
            

        }
    }
}
