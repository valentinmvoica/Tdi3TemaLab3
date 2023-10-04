using System;

namespace Tdi3TemaLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = CitireVector();

            ShowNumbersDivisibleBy3(vector);

            int max = GetCelMaiMare(vector);
            Console.WriteLine($"cel mai mare din vector: {max}");

            int min = GetCelMaiMic(vector);
            Console.WriteLine($"cel mai mic din vector: {min}");


            Console.WriteLine("vector inversat:");
            InversareElemente(vector);
            foreach(var elem in vector)
            {
                Console.WriteLine(elem);
            }
        }
        static void InversareElemente(int[] vector)
        {
            // 1 2 3 4
            // 0 1 2 3
            for(var i =0; i < vector.Length / 2;i++)
            {
                var aux = vector[i];
                vector[i] = vector[vector.Length - 1 - i];
                vector[vector.Length - 1 - i] = aux;
            }
        }
        static void ShowNumbersDivisibleBy3(int[] vec)
        {
            Console.WriteLine("numere div cu 3");
            foreach (var elem in vec)
            {
                if (elem%3 == 0)
                {
                    Console.WriteLine(elem);
                }
            }
        }

        static int GetCelMaiMic(int[] vec)
        {
            int min = vec[0];
            foreach (var elem in vec)
            {
                if (elem < min)
                {
                    min = elem;
                }
            }

            return min;
        }
        static int GetCelMaiMare(int[] vec) {
            int max = vec[0];
            foreach(var elem in vec)
            {
                if (elem > max)
                {
                    max = elem;
                }
            }

            return max;
        }
        static int[] CitireVector()
        {
            Console.WriteLine("Cate elemente are vect");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("introduceti elementele");
            int[] result = new int[n];
            for(var i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
    }
}
