using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        //int.TryParse - выводит true\ false, если число нужное\ ненужное 
        //void - если метод просто делает, не возвращает
        //что возвращает метод, название метода, параметры
        private static void InPutArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = int.Parse(Console.ReadLine());
        }

        private static void OutPutArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
        }

        private static void SortArray(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int k = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = k;
                    }
                }
            }
        }
        private static void HPENb()
        {
            int c = 1234;
            bool b;
            string k;
            do
            {
                k = Console.ReadLine();
                b = int.TryParse(k, out c);
                if (b) Console.WriteLine(k);
            }
            while (b);
        }


        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[] a = new int[n];

            HPENb();

            //InPutArray(a); 

            //OutPutArray(a);

            //SortArray(a);

            //OutPutArray(a);

            Console.ReadKey();
        }
    }
}
