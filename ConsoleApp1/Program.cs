using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 Найти максимальный элемент  и его индекс одномерного массива 
            int[] array = { 8, -1, 4, 16, -5, 3 };
            int max = array[0]; int indexMax = 0;
            for (int i=1; i< array.Length; i++)
            {
                if ( array [i] > max )
                {
                   max = array[i]; indexMax = i;
                } 
            }
            Console.WriteLine($"max = {max}\t indexMax ={indexMax}");
            Console.Read();
        }
    }
}
