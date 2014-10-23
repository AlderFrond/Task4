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
        private static void ReadInt()
        {
            int Number = 0;
            bool isNumber = false;
            do
            {
                string strInt = Console.ReadLine();
                isNumber = int.TryParse(strInt, out Number);
                if (isNumber)
                    Console.WriteLine(Number);
            }
            while (!isNumber);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Введите нужное число");
            ReadInt();

            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            Console.WriteLine("Введите массив");

            InputArray(a);

            OutputArray(a);

            Console.ReadKey();
        }
    }
}
