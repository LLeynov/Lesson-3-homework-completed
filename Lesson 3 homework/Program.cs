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
            //Написать программу, выводящую введенную пользователем строку в обратном порядке(olleH вместо Hello).
            {
                char[] chars = { 'H', 'E', 'L', 'L', 'O' };
                Array.Reverse(chars);
                Console.WriteLine(chars);
            }
        }
    }
}
