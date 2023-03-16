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
            // 1 Найти минимальный элемент  и его индекс одномерного массива 
            int[] array = { 8, -1, 4, 16, -5, 3 };
            int max = array[0];
            int indexMax = 0;
            int min = array[0];
            int indexMin = 0;


            for (int i=1; i< array.Length; i++)
            {
                if ( array [i] > max)
                {
                   max = array[i];
                    indexMax = 1;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                } 
            }
            Console.WriteLine($"max = {max}\t indexMax ={indexMax}");
            Console.WriteLine($"min = {min}\t indexMin ={indexMin}");
            Console.Read();
        }
    }
}
