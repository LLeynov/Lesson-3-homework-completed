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
            //Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
            string[,] matrix = new string [5, 2];

            matrix[0, 0] = "Лев Лейнов";
            matrix[0, 1] = " +79889498468/leynov@mail.ru";
            matrix[1, 0] = "Иван Иванов";
            matrix[1, 1] = " +79465465498/invanov@mail.ru"; 
            matrix[2, 0] = "Максим Губов";
            matrix[2, 1] = " +79484135165/gubov@mail.ru";
            matrix[3, 0] = "Шрэк Огров";
            matrix[3, 1] = " +78794968494/Shrek@ogr.ru";
            matrix[4, 0] = "Осёл Изшрэков";
            matrix[4, 1] = " +79846546544/Donkey@oslik.ru";

            Console.WriteLine("     Телефонный справочник!");
            Console.WriteLine("Имя контакта     телефон/e-mail");

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
