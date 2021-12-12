using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            Console.WriteLine("Сформируем массив ");
            for (int i = 0; i < N; i++)

            {
                for (int j = 0; j < N; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                            array[i, j] = 1;
                        else
                            array[i, j] = 0;
                    }
                    else
                          if (j % 2 == 0)
                        array[i, j] = 0;

                    else
                        array[i, j] = 1; 
                    
                    Console.Write(" {0 }", array[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}

