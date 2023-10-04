using System;

namespace FunctiiRec
{
    class Program
    {
        static void Main(string[] args)
        {
            var n =int.Parse(Console.ReadLine());

            ShowPiramid(n);

            //Console.WriteLine(GaussSum(n));

        }
        static int GaussSum(int n)
        {
            // conditie de iesire ! , cuprinzatoare
            if (n <= 0)
            {
                return 0;
            }
            return n + GaussSum(n - 1);
            // apel recursiv
            //operatiile din iteratia curenta
        }

        static void ShowPiramid(int n)
        {
            if (n <= 0)
            {
                return;
            }

          
            ////operatiile din iteratia curenta
            //for (var i = 0; i < n; i++)
            //{
            //    Console.Write(n);
            //}
            //Console.WriteLine();
            ShowLine(0, n);
            // apel recursiv
            ShowPiramid(n - 1);
        }
        static void ShowLine(int i, int n)
        {
            if (i >= n)
            {
                Console.WriteLine();
                return;
            }

            Console.Write(n);
            ShowLine(i + 1, n);
        }

        /*
         * 55555
         * 4444
         * 333
         * 22
         * 1
         */
    }
}
