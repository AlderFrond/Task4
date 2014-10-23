using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        private static void InputArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());
        }

        private static void OutputArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }
        private static int ReadInt()
        {
            int number = 0;
            bool isNumber = false;
            do
            {
                string strInt = Console.ReadLine();
                isNumber = int.TryParse(strInt, out number);
                if (isNumber)
                    Console.WriteLine(number);
            }
            while (!isNumber);
            return number;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = ReadInt(); 
            int[] a = new int[n];

            Console.WriteLine("Введите массив");

            InputArray(a);

            OutputArray(a);

            Console.ReadKey();
        }
    }
}
