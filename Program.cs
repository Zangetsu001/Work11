using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        /// <summary>
        ///  найти сумму всех чисел
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] omas= { 5, 7, 1, 9, 5, 3, 6, 5, 4 };
            int sum = omas.Sum();
            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
