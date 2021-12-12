using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_z1_z5
{
    class Program
    {
        static void Main(string[] args)
        { //Сформировать массив из 7 элементов, вывести среднее арифметическое
            Console.WriteLine("Введите 7 разных чисел");
            int[] array = new int[7];
            double summa = 0;
            double srArifmeticheskoe;
            {
                for (int i = 0; i < 7; i++)
                    array[i] = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < 7; i++)
                    summa += array[i];
                srArifmeticheskoe = summa / 7;
            }
            Console.WriteLine(" Сумма элементов равна {0}, а среднее арифметиеское элементов равно {1:f2}", summa, srArifmeticheskoe);
            Console.ReadKey();
        }
    }
}
