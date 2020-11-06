using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace Array_first
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();

            //Массив из 10 элементов
            int[] Array = new int[10];

            //Заполняем массива элементами
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Rand.Next(-100, 100);
                Console.WriteLine("Array [" + i.ToString() + "] =" + Array[i]);
            }
        }
    }
}
