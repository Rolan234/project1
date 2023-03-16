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
            // Задание : Дан курс рубля за каждый день в феврале месяце (Случайным образом) 
            // Расчитать средний курс рубля , максимальный курс рубля и день с максимальным курсом,минимальный курс рубля и день с минимальным курсом
            double [] array = new double[28];
                Random random = new Random();
            for ( int i = 0; i < array.Length; i++)
            {
                array[i] = 55 + 10* random.NextDouble();
                Console.WriteLine($"array[{i}]={array[i]:f2}");
            }
            Console.Read();
        }
    }
}
