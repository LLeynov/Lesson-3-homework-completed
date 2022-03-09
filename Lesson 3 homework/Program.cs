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
            //*«Морской бой»: вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.

            string[,] matrix = new string[10, 10];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = "0";
                }
            }

            matrix[0, 0] = "Х"; matrix[2, 0] = "Х";
            matrix[9, 0] = "Х"; matrix[2, 1] = "Х";
            matrix[0, 9] = "Х"; matrix[2, 4] = "Х";
            matrix[9, 9] = "Х"; matrix[2, 5] = "Х";
            matrix[0, 3] = "Х"; matrix[2, 6] = "Х";
            matrix[0, 4] = "Х"; matrix[2, 7] = "Х";
            matrix[0, 6] = "Х"; matrix[3, 9] = "Х";
            matrix[0, 7] = "Х"; matrix[2, 9] = "Х";
            matrix[4, 9] = "Х"; matrix[6, 3] = "Х";
            matrix[6, 4] = "Х"; matrix[6, 5] = "Х";
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
