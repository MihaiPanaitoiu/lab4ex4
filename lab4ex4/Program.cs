using System;

namespace lab4ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 4
            Scrieti o functie recursiva care va afisa in ordine elementele unui vector de
            intregi.
             */
            Console.WriteLine("introduceti n");

            int[] mat = ReadMatrix(int.Parse(Console.ReadLine()));

            ShowMatNumbers(mat);
        }

        static int[] ReadMatrix(int n)
        {
            Console.WriteLine("introduceti elementele arrayului");
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
            {
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void ShowMatNumbers(int[] mat, int i = 0)
        {
            if (mat.Length <= i )
            {
                return;
            }

            Console.WriteLine(mat[i]);
            ShowMatNumbers(mat, i+1);
        }
    }
}
