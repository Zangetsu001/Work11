﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// подсчитать количество числа со значением 5 одномерном массиве
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas = { 5, 7, 1, 9, 5, 3, 6, 5, 4 };
            /*int count = 0;
            foreach(var el in omas)
            {
                if (el == 5)
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);*/
            
            int count = omas.Count(x => x == 5);
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
